using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jint;
using Jint.Native;
using Hush.Tools;
using Jint.Parser;
using Jint.Runtime;

namespace Hush.Tools.Scripting
{

    class HushScript
    {

        private JsValue _BodyFunction;
        private Engine _Engine;
        private JsValue _HeadFunction;
        private Boolean _Loaded;
        private String _Name;
        private String _Source;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public HushScript()
        {

            _Engine = new Engine();
            _Loaded = false;
            _Name = String.Empty;
            _Source = String.Empty;

        }

        private void InitValues()
        {

            _Engine.SetValue("output", new Action<String>(Hush.Tools.FileUtil.OutputScriptData));
            _Engine.SetValue("print", new Action<Object>(Console.WriteLine));
            _Engine.SetValue("WebHandler", new WebHandler());

        }

        public ReturnValue Load()
        {

            ReturnValue ReturnValue = new ReturnValue("", true);

            _Loaded = false;
            _Source = String.Empty;

            if (_Name == String.Empty)
            {
                ReturnValue.Message = "script name is empty";
                ReturnValue.Success = false;
                return ReturnValue;
            }

            _Source = FileUtil.ReadScriptFile(_Name);

            if (_Source.Length < 1)
            {
                ReturnValue.Message = "script source was not loaded";
                ReturnValue.Success = false;
                return ReturnValue;
            }

            try
            {

                _Engine.Execute(_Source);
                InitValues();

                _HeadFunction = _Engine.GetValue("head");
                _BodyFunction = _Engine.GetValue("body");

                if (_HeadFunction == JsValue.Undefined)
                {
                    ReturnValue.Message = "head function not defined";
                    ReturnValue.Success = false;
                    return ReturnValue;
                }

                if (_BodyFunction == JsValue.Undefined)
                {
                    ReturnValue.Message = "body function not defined";
                    ReturnValue.Success = false;
                    return ReturnValue;
                }

            }
            catch (Exception E)
            {
                ReturnValue.Message = "problemo";
                ReturnValue.Success = false;
                return ReturnValue;
            }

            _Loaded = true;
            return ReturnValue;

        }

        public ReturnValue Run()
        {

            ReturnValue ReturnValue = new ReturnValue("", true);

            if (!_Loaded)
            {

                Console.WriteLine("script class not loaded on run");

            }

            try
            {

                JsValue HeadResult;
                JsValue BodyResult;
                
                HeadResult = _HeadFunction.Invoke();
                BodyResult = _BodyFunction.Invoke();

            }
            catch (JavaScriptException JSE)
            {

                Console.WriteLine("problem in run" + JSE.Message);
//                return false;

            }

            return ReturnValue;

        }

    }

}

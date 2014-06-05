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

            _Engine.SetValue("print", new Action<Object>(Console.WriteLine));

        }

        public Boolean Load()
        {

            _Loaded = false;
            _Source = String.Empty;

            if (_Name == String.Empty)
            {

                Console.WriteLine("script name is empty");
                return false;

            }

            _Source = FileUtil.ReadScriptFile(_Name);

            if (_Source.Length < 1)
            {

                Console.WriteLine("script source wasn't loaded");
                return false;

            }

            try
            {

                _Engine.Execute(_Source);
                InitValues();

                _HeadFunction = _Engine.GetValue("head");
                _BodyFunction = _Engine.GetValue("body");

                if (_HeadFunction == JsValue.Undefined)
                {

                    Console.WriteLine("head function not defined");
                    return false;

                }

                if (_BodyFunction == JsValue.Undefined)
                {

                    Console.WriteLine("body function not defined");
                    return false;

                }

            }
            catch (Exception E)
            {

                System.Windows.Forms.MessageBox.Show(E.Message);
                System.Console.WriteLine("problemo");
                return false;

            }

            _Loaded = true;
            return true;

        }

        public Boolean Run()
        {

            if (!_Loaded)
            {

                Console.WriteLine("script class not loaded on run");
                return false;

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

                Console.WriteLine("problem in run");
                return false;

            }

            return true;

        }

    }

}

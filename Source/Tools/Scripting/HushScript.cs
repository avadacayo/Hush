﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jint;
using Jint.Native;
using Hush.Tools;
using Jint.Parser;
using Jint.Runtime;
using Hush.Display;
using Hush.Tools.Scripting.Handlers;

namespace Hush.Tools.Scripting
{

    class HushScript
    {

        private AccessHandler _AccessHandler;
        private Engine _Engine;
        private Int32 _State;
        private Boolean _Loaded;
        private ParentWindow _ParentWindow;
        private String _Name;
        private String _Source;
        private ViewHandler _ViewHandler;
        private WebHandler _WebHandler;

        private JsValue _BodyFunction;
        private JsValue _HeadFunction;

        public String Name
        {

            get { return _Name; }
            set { _Name = value; }

        }

        public HushScript(ParentWindow ParentWindow)
        {

            _AccessHandler = new AccessHandler();
            _Engine = new Engine();
            _State = 0;
            _Loaded = false;
            _ParentWindow = ParentWindow;
            _Name = String.Empty;
            _Source = String.Empty;
            _ViewHandler = new ViewHandler(this, ParentWindow);
            _WebHandler = new WebHandler();

            _BodyFunction = JsValue.Undefined;
            _HeadFunction = JsValue.Undefined;

        }

        private void InitValues()
        {

            _Engine.SetValue("AccessHandler", _AccessHandler);
            _Engine.SetValue("ViewHandler", _ViewHandler);
            _Engine.SetValue("WebHandler", _WebHandler);

            _Engine.SetValue("output", new Action<String>(Hush.Tools.FileUtil.OutputScriptData));
            _Engine.SetValue("print", new Action<Object>(Console.WriteLine));

        }

        public ReturnValue Load()
        {

            ReturnValue ReturnValue = new ReturnValue();
            ReturnValue.Message = String.Empty;
            ReturnValue.Success = true;

            _Loaded = false;
            _Source = String.Empty;

            if (_Name == String.Empty)
            {

                ReturnValue.Message = "No script name provided.";
                ReturnValue.Success = false;
                return ReturnValue;

            }

            _Source = FileUtil.ReadScriptFile(_Name);

            if (_Source.Length < 1)
            {

                ReturnValue.Message = "Script source could not be loaded.";
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

                    ReturnValue.Message = "Head function not defined.";
                    ReturnValue.Success = false;
                    return ReturnValue;

                }

                if (_BodyFunction == JsValue.Undefined)
                {

                    ReturnValue.Message = "Body function not defined.";
                    ReturnValue.Success = false;
                    return ReturnValue;

                }

            }
            catch (Exception E)
            {

                ReturnValue.Message = "Problem with initalizing the script.";
                ReturnValue.Success = false;
                return ReturnValue;

            }

            _Loaded = true;

            return ReturnValue;

        }

        public ReturnValue Run()
        {

            ReturnValue ReturnValue = new ReturnValue("", true);

            RunHead();
            RunBody(0, "");

            return ReturnValue;

        }

        public ReturnValue RunHead()
        {

            ReturnValue ReturnValue = new ReturnValue();
            ReturnValue.Message = String.Empty;
            ReturnValue.Success = true;

            if (!_Loaded)
            {

                ReturnValue.Message = "Script class not loaded.";
                ReturnValue.Success = false;
                return ReturnValue;

            }

            try
            {

                _HeadFunction.Invoke();

            }
            catch (JavaScriptException JSE)
            {

                ReturnValue.Message = "Error running script.";
                ReturnValue.Success = false;
                return ReturnValue;

            }

            return ReturnValue;

        }

        public ReturnValue RunBody(Int32 Mode, String Value)
        {

            ReturnValue ReturnValue = new ReturnValue();
            ReturnValue.Message = String.Empty;
            ReturnValue.Success = true;

            if (!_Loaded)
            {

                ReturnValue.Message = "Script class not loaded.";
                ReturnValue.Success = false;
                return ReturnValue;

            }

            try
            {

                _BodyFunction.Invoke(
                    new JsValue(_State++),
                    new JsValue(Mode),
                    new JsValue(Value)
                );

            }
            catch (JavaScriptException JSE)
            {

                ReturnValue.Message = "Error running script.";
                ReturnValue.Success = false;
                return ReturnValue;

            }

            return ReturnValue;

        }

    }

}

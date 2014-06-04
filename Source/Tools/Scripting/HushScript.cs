using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jint;
using Jint.Native;
using Hush.Tools;

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

        public Boolean Load()
        {
            _Loaded = false;
            if (_Name == String.Empty)
                return false;
            _Source = FileUtil.ReadScriptFile(_Name);
            if (_Source.Length < 1)
                return false;
            _Engine.Execute(_Source);
            _BodyFunction = _Engine.GetValue("body");
            _HeadFunction = _Engine.GetValue("head");
            if (_BodyFunction == JsValue.Undefined || _HeadFunction == JsValue.Undefined)
                return false;
            _Loaded = true;
            return true;
        }

        public Boolean Run()
        {
            if (!_Loaded)
                return false;
            var x = _HeadFunction.Invoke();
            var y = _BodyFunction.Invoke();
            return true;
        }

    }

}

using Hush.Client.Model;
using Jint.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hush.Tools.Scripting.Handlers
{

    class AccessHandler
    {

        private String _AccessKey;
        private Record _Record;

        public AccessHandler(String AccessKey, Record Record)
        {

            _AccessKey = AccessKey;
            _Record = Record;

        }

        public JsValue Access(String Name)
        {

            String ReturnValue = String.Empty;

            if (_Record != null && _Record.Fields.Count > 0)
            {
                foreach (Field Item in _Record.Fields)
                {
                    if (Item.Key == Name)
                    {
                        ReturnValue = Item.Value;
                        break;
                    }
                }
            }

            if (ReturnValue != String.Empty)
                return new JsValue(ReturnValue);
            return JsValue.Undefined;

        }

    }

}

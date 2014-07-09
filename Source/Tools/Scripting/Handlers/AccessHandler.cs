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

        public JsValue AccessNameByIndex(Int32 Index)
        {

            Int32 CurrentIndex = 0;
            String ReturnValue = String.Empty;

            if (_Record != null && _Record.Fields.Count > 0)
            {
                foreach (Field Item in _Record.Fields)
                {
                    if (CurrentIndex == Index)
                    {
                        ReturnValue = Item.Key;
                        break;
                    }
                    CurrentIndex++;
                }
            }

            if (ReturnValue != String.Empty)
                return new JsValue(ReturnValue);
            return JsValue.Undefined;

        }

        public JsValue AccessValueByIndex(Int32 Index)
        {

            Int32 CurrentIndex = 0;
            String ReturnValue = String.Empty;

            if (_Record != null && _Record.Fields.Count > 0)
            {
                foreach (Field Item in _Record.Fields)
                {
                    if (CurrentIndex == Index)
                    {
                        ReturnValue = Item.Value;
                        break;
                    }
                    CurrentIndex++;
                }
            }

            if (ReturnValue != String.Empty)
                return new JsValue(ReturnValue);
            return JsValue.Undefined;

        }

        public JsValue Count()
        {


            if (_Record != null)
            {

                return new JsValue(_Record.Fields.Count);

            }

            return new JsValue(0);

        }

        public JsValue Has(String Name)
        {

            JsValue ReturnValue = JsValue.False;

            if (_Record != null && _Record.Fields.Count > 0)
            {
                foreach (Field Item in _Record.Fields)
                {
                    if (Item.Key == Name)
                    {
                        ReturnValue = JsValue.True;
                        break;
                    }
                }
            }

            return ReturnValue;

        }

    }

}

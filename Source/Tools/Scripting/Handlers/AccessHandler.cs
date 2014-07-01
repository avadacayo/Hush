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

            return new JsValue();

        }

    }

}

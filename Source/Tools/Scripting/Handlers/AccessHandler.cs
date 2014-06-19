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

        public AccessHandler()
        {

            _AccessKey = String.Empty;
            _Record = null;

        }

        public AccessHandler(String AccessKey, Record Record)
        {

            _AccessKey = AccessKey;
            _Record = Record;

        }

        public JsValue Access()
        {

            return new JsValue();

        }

        public void GrantAccess(String AccessKey)
        {
        }

        public void RequestAccess()
        {
        }

        public void RevokeAccess(String AccessKey)
        {
        }

    }

}

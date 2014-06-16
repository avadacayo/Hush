using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Hush.Tools.Scripting
{

    class WebHandler
    {

        public class PostValues
        {

            private NameValueCollection _Data;

            public PostValues()
            {

                _Data = new NameValueCollection();

            }

        }

        private ExtendedWebClient _Client;

        public WebHandler()
        {

            _Client = new ExtendedWebClient();

        }

        ~WebHandler()
        {

            _Client.Dispose();

        }

        public String SendGet(String URI)
        {

            StreamReader Reader = new StreamReader(_Client.OpenRead(URI));
            return Reader.ReadToEnd();

        }

        public String SendPost(String URI, String Parameters)
        {

            _Client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            return _Client.UploadString(URI, Parameters);

        }

    }

}

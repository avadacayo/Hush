using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Hush.Tools.Scripting
{

    class WebHandler
    {

        private WebClient _Client;

        public WebHandler()
        {
            _Client = new WebClient();
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
            _Client.Headers[HttpRequestHeader.ContentType] = "";
            return _Client.UploadString(URI, Parameters);
        }

    }

}

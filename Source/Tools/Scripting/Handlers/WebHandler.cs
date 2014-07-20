using System;
using System.IO;
using System.Net;

namespace Hush.Tools.Scripting.Handlers
{

    class WebHandler
    {

        private ExtendedWebClient _Client;

        public WebHandler()
        {

            _Client = new ExtendedWebClient();

        }

        ~WebHandler()
        {

            _Client.Dispose();

        }

        public void ClearCookies()
        {

            _Client.ClearCookies();

        }

        public String SendGet(String URI)
        {

            String ReturnValue;

            using (StreamReader Reader = new StreamReader(_Client.OpenRead(URI))) {
                ReturnValue = Reader.ReadToEnd();
            }

            return ReturnValue;

        }

        public String SendPost(String URI, String Parameters)
        {

            _Client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            return _Client.UploadString(URI, Parameters);

        }

    }

}

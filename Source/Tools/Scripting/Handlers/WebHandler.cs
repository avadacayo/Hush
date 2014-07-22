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

//            _Client.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _Client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            _Client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.125 Safari/537.36";
            return _Client.UploadString(URI, Parameters);

        }

    }

}

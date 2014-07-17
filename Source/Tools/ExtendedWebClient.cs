using System;
using System.Net;

namespace Hush.Tools
{

    class ExtendedWebClient : WebClient
    {

        private CookieContainer _Cookies = new CookieContainer();

        protected override WebRequest GetWebRequest(Uri Address)
        {

            WebRequest Request = base.GetWebRequest(Address);

            if (Request is HttpWebRequest)
            {

                (Request as HttpWebRequest).CookieContainer = _Cookies;

            }

            return Request;

        }

        public void ClearCookies()
        {

            _Cookies = new CookieContainer();

        }

    }

}

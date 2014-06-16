using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Hush.Tools
{

    class ExtendedWebClient : WebClient
    {
        private CookieContainer m_container = new CookieContainer();

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            if (request is HttpWebRequest)
            {
                (request as HttpWebRequest).CookieContainer = m_container;
            }
            return request;
        }

    }

}

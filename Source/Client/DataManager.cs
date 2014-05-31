using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Hush.Client
{

    static class DataHolder
    {

        static public List<String> UserList = default(List<String>);

    }

    class DataManager
    {

        private Boolean loaded = false;

        public Boolean LoadUsers()
        {
            return false;
        }

        public Boolean TryLogin(String Username, String Password)
        {

            if (!loaded)
            {
                //loadUserList();
            }

            if (false /* username is valid and password (encrypted) matches encrypted password*/)
            {
                return true;
            }
              
            return false;

        }

    }

}

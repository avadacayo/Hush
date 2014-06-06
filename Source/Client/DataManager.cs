using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Hush.Client.Model;

namespace Hush.Client
{

    static class DataHolder
    {

        static public User CurrentUser = default(User);
        static public List<User> UserList = default(List<User>);

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

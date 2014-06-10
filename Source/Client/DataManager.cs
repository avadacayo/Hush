using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Hush.Client.Model;
using System.Windows.Forms;

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

        public static void AddRecord()
        {
            Field f_k = new Field();
            f_k.Value = this.Key.ToString();
            f_k.Value = "adb";
            Field f_v = new Field();
            f_v.Value = this.Value.ToString();
            DataHolder.CurrentUser.Records[dataGridViewRecords.CurrentCell.RowIndex].Fields.Add(f_k);

            return;
        }

        public static void EditRecord(object sender, DataGridViewCellEventArgs e)
        {

            var collection = this.dataGridViewRecords.Rows;

            foreach (DataGridViewRow row in collection)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    Field f = new Field();
                    if (cell.Value != null)
                    {
                        f.Value = cell.Value.ToString();
                        DataHolder.CurrentUser.Records[e.RowIndex].Fields.Add(f);
                    }
                }
            }

        }

    }

}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Hush.Client.Model;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Text.RegularExpressions;


namespace Hush.Client
{

    static class DataHolder
    {
        static public User CurrentUser = default(User);
        static public List<User> UserList = default(List<User>);

        static public string updateCategory;
        public enum updateMode {None, Add, Edit, Delete};
        static public updateMode update;
    }

    class DataManager
    {

        private Boolean loaded = false;
        BinaryFormatter BFormatter;

        public Boolean CreateAccount(String Username, String Password, String SecretQuestion, String SecretAnswer)
        {
            BFormatter = new BinaryFormatter(); 
            User NewUser = new User();
            NewUser.Username = Username;
            NewUser.Password = Password;
            NewUser.SecretQuestion = SecretQuestion;
            NewUser.SecretAnswer = SecretAnswer;
            NewUser.Created = DateTime.Now;
            NewUser.Modified = DateTime.Now;
            
            Boolean created = false;
            try
            {
                FileStream writerFS;
                if (!Directory.Exists("./Data"))
                {
                    Directory.CreateDirectory("./Data");
                }
                //TODO change filename
                if (!File.Exists("./Data/" + Username + ".user"))
                {
                    writerFS =
                    new FileStream("./Data/" + Username + ".user", FileMode.Create, FileAccess.Write);
                }
                else
                {
                    writerFS =
                    new FileStream("./Data/" + Username + ".user", FileMode.Append, FileAccess.Write);
                }
                if (!loaded)
                {
                    LoadUsers();
                }
                BFormatter.Serialize(writerFS, NewUser);
                writerFS.Close();
                DataHolder.CurrentUser = NewUser;
                created = true;
            }
            catch (Exception) {
                
            } 
            return created;
        }

        public Boolean DeserializeUsers(String filename)
        {
            Boolean retrieved;
            User getUser;
            
            try
            {
                FileStream readerFileStream = new FileStream(filename,
                    FileMode.Open, FileAccess.Read);
                BFormatter = new BinaryFormatter();
                getUser = (User)BFormatter.Deserialize(readerFileStream);
                DataHolder.CurrentUser = getUser;
                DataHolder.UserList.Add(getUser);
                readerFileStream.Close();
                retrieved = true;
            }

            catch (Exception)
            {
                retrieved = false;
            }
            return retrieved;
        }
        public Boolean LoadUsers()
        {
            DataHolder.UserList = new List<User>();
            Boolean retrieved;
            try
            {
                String[] filenames = Directory.GetFiles("./Data/", "*.user");
                // TODO use file util class
                foreach (string f in filenames)
                {
                    DeserializeUsers(f);
                }
                retrieved = true;
                loaded = true;
                
            }

            catch (Exception)
            {
                retrieved = false;
            }
            
            return retrieved;
        }

        public Boolean UniqueAccount(String Username)
        {
            Boolean unique = false;
            if (!loaded)
            {
                LoadUsers();
            }

            if (loaded)
            {
                unique = DataHolder.UserList.Exists(x => x.Username == Username);
            }
            return !unique;
        }
        public Boolean TryLogin(String Username, String Password)
        {
            Boolean successfulLogin = false;
            User user = new User();
            if (!loaded)
            {
                LoadUsers();
            }

            //if ( /* username is valid and password (encrypted) matches encrypted password*/)

            if (loaded)
            {
                user = DataHolder.UserList.Find(x => x.Username.Equals(Username));
                if (user != null)
                {
                    if (Password == user.Password)
                    {
                        successfulLogin = true;
                        DataHolder.CurrentUser = user;
                    }
                }
            }
            return successfulLogin;

        }

        public Int32 PasswordStrength(String Password)
        {
            Int32 val = 0;
            Regex regex = new Regex("[A-Z]");

            if (regex.IsMatch(Password))
            {
                val++;
            }

            regex = new Regex("[0-9]");
            if (regex.IsMatch(Password))
            {
                val++;
            }

            regex = new Regex("[^A-Za-z0-9]");
            if (regex.IsMatch(Password))
            {
                val++;
            }

            if (Password.Length > 6)
            {
                val++;
            }

            regex = new Regex(@"(.)\1");
            if (regex.IsMatch(Password))
            {
                val--;
            }

            return val;
        }
       
        public static void AddRecord()
        {
            Record NewRecord = new Record();
            DataHolder.CurrentUser.Records.Add(NewRecord);
        }

        public static void ProcessCategory(string oldCategory, string newCategory, DataHolder.updateMode update)
        {
            if (update == DataHolder.updateMode.Edit)
            {
                EditCategory(oldCategory, newCategory);
            }
            else if (update == DataHolder.updateMode.Delete)
            {
                DeleteCategory(oldCategory);
            }
            else
            {
                AddCategory(newCategory);
            }

        }

        // adds a category
        public static void AddCategory(string category)
        {
            if (DataHolder.CurrentUser.Categories == null)
            {
                List<Category> newCategoryList = new List<Category>();
                DataHolder.CurrentUser.Categories = newCategoryList;
            }

            Category newCategory = new Category();
            newCategory.ID = category;
            newCategory.Name = category;
            newCategory.Created = DateTime.Now;

            DataHolder.CurrentUser.Categories.Add(newCategory);
          
        }


        // adds a field
        public static void AddField(Record Record, String Key, String Value)
        {
            Field NewField = new Field();
            NewField.Key = Key;
            NewField.Value = Value;
            Record.Fields.Add(NewField);
        }

        public static void AddRecord(Int32 RecordIndex, String Key, String Value) {
            Field NewField = new Field();
            NewField.Key = Key;
            NewField.Value = Value;
            DataHolder.CurrentUser.Records[RecordIndex].Fields.Add(NewField);

            return;
        }

        public static void ApplyRecordChanges(Record CurrentRecord, DataGridView Data)
        {
            DataTable DT;
            DataView DV = (DataView)Data.DataSource;
            DT = DV.Table.DataSet.Tables[0];
            CurrentRecord.Fields.Clear();
            
            foreach ( DataRow Row in  DT.Rows) {
                
                    Field f = new Field();
                    f.Key = Row[0].ToString();
                    f.Value = Row[1].ToString();
                    CurrentRecord.Fields.Add(f);
                              
            }
         }

        public static void DeleteRecord(Record record)
        {
            DataHolder.CurrentUser.Records.Remove(record);
        }

        public static void DeleteCategory(string category)
        {
            List<Category> list = DataHolder.CurrentUser.Categories;
            for (var x = 0; x < list.Count; x++)
            {
                if (list[x].Name == category)
                {
                    DataHolder.CurrentUser.Categories.RemoveAt(x);
                    x = list.Count;
                }
                
            }
        }

        public static void EditCategory(string oldCategory, string newCategory)
        {
            // TODO:  get category object with matching name
            // set category name to new name
            // send updated object to file
            List<Category> list = DataHolder.CurrentUser.Categories;
            for (var x = 0; x < list.Count; x++)
            {
                if (list[x].Name == oldCategory)
                {
                    DataHolder.CurrentUser.Categories[x].Name = newCategory;
                    x = list.Count;
                }
            }
        }

        //public static void EditRecord(object sender, DataGridViewCellEventArgs e)
        //{

            //var collection = this.dataGridViewRecords.Rows;

            //foreach (DataGridViewRow row in collection)
            //{

            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        Field f = new Field();
            //        if (cell.Value != null)
            //        {
            //            f.Value = cell.Value.ToString();
            //            DataHolder.CurrentUser.Records[e.RowIndex].Fields.Add(f);
            //        }
            //    }
            //}

        //}

        
    }

}

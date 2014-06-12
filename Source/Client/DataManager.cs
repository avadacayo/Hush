using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Hush.Client.Model;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;


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
        BinaryFormatter bFormatter;

        public Boolean LoadUsers()
        {
            DataHolder.UserList = new List<User>();
            Boolean retrieved;
            try
            {
                String[] filenames = Directory.GetFiles("./test/", "*.txt");
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
                unique = DataHolder.UserList.Exists(x => x.FirstName == Username);
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
                user = DataHolder.UserList.Find(x => x.FirstName.Equals(Username));
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

        public Boolean CreateAccount(String FirstName, String Password, String SecretQuestion, String SecretAnswer)
        {
            bFormatter = new BinaryFormatter(); 
            User newUser = new User();
            newUser.FirstName = FirstName;
            newUser.Password = Password;
            newUser.SecretQuestion = SecretQuestion;
            newUser.SecretAnswer = SecretAnswer;
      
            Boolean created = false;
            try
            {
                FileStream writerFS;
                if (!File.Exists("./test/" + FirstName + ".txt"))
                {
                    writerFS =
                    new FileStream("./test/" + FirstName + ".txt", FileMode.Create, FileAccess.Write);
                }
                else
                {
                    writerFS =
                    new FileStream("./test/" + FirstName + ".txt", FileMode.Append, FileAccess.Write);
                }
                List<User> getUserList = new List<User>();
                if (!loaded)
                {
                    LoadUsers();
                }
                //getUserList.Add(newUser);
                bFormatter.Serialize(writerFS, newUser);
                writerFS.Close();
                DataHolder.CurrentUser = newUser;
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
                bFormatter = new BinaryFormatter();
                getUser = (User)bFormatter.Deserialize(readerFileStream);
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


        // adds a record
        public static void AddRecord()
        {
            Record NewRecord = new Record();
            DataHolder.CurrentUser.Records.Add(NewRecord);
        }

        // adds a category
        public static void AddCategory(string category)
        {
            Category newCategory = new Category();
            newCategory.ID = category;
            newCategory.Name = category;
            newCategory.Created = DateTime.Now;

            DataHolder.CurrentUser.Categories.Add(newCategory);
          
            // TODO : add Category object to file
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
            // TODO:  find index of category object with matching name
            // prompt user for confirmation
            // remove category object from User.List<Category>
        }

        public static void EditCategory(string category)
        {
            // TODO:  get category object with matching name
            // set category name to new name
            // send updated object to file
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

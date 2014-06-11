﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Hush.Client.Model;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


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
                //FileStream writerFS = 
                //    new FileStream("test.txt", FileMode.Create, FileAccess.Write);
                //bFormatter.Serialize(writerFS, newUser);
                //writerFS.Close();
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

        // adds a field
        public static void AddField(Record Record, String Key, String Value)
        {
            Field NewField = new Field();
            NewField.Key = Key;
            NewField.Value = Value;
            Record.Fields.Add(NewField);
        }

        public static void AddRecord(Int32 RecordIndex, String Key, String Value) {
            Record r = new Record();
            Field f_k = new Field();
            f_k.Key = Key;
            f_k.Value = Value;
            DataHolder.CurrentUser.Records[RecordIndex].Fields.Add(f_k);

            return;
        }

        public static void EditRecord(object sender, DataGridViewCellEventArgs e)
        {

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

        }


    }

}

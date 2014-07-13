using Hush.Client.Model;
using Hush.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace Hush.Client
{

    static class DataHolder
    {

        static public List<Template> Templates = default(List<Template>);
        static public User CurrentUser = default(User);
        static public List<User> UserList = default(List<User>);
        static public IEnumerable<Record> RecordList = default(IEnumerable<Record>);

        static public string updateCategory;
        public enum updateMode {None, Add, Edit, Delete};
        static public updateMode update;
        static public Int32 RecordIndex;
    }

    class DataManager
    {

        private Boolean loaded = false , updated = false;
        BinaryFormatter BFormatter;

       
        public Boolean ChangePassword(String Username, String Password)
        {
            User user = DataHolder.UserList.Find(x => x.Username.Equals(Username));
            DataHolder.CurrentUser = user;

            if (!loaded)
            {
                LoadUsers();
            }

            if (new CheckString().ValidPasswordCheck(Username, Password))
            {
                user.Password = Password;

           // TODO: remove and /use file util
                try
                {
                    FileStream writerFS;
                    
                        writerFS =
                        new FileStream("./Data/" + Username + ".user", FileMode.Open, FileAccess.Write);
                    
                    if (!loaded)
                    {
                        LoadUsers();
                    }
                    BFormatter.Serialize(writerFS, user);
                    writerFS.Close();
                    DataHolder.CurrentUser = user;
                    updated = true;
                }
                catch (Exception)
                {

                }
            }
            return updated;
        }

        public Boolean CheckSecretAnswer(String Username, String Answer, Int32 QuestionNumber)
        {
            User user = DataHolder.UserList.Find(x => x.Username.Equals(Username));
            if (user.SecretAnswer.Equals(Answer))
                return true;

            else
                return false;
        }

        public static void ProcessTemplateChange(List<String> AddedFields, String TemplateName, DataGridView Control)
        {

            List<String> ToAdd = FileUtil.ReadTemplate(TemplateName);
            List<DataGridViewRow> ToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow Row in Control.Rows)
            {

                if (Row.Cells[0].Value != null)
                {

                    if (AddedFields.Contains(Row.Cells[0].Value.ToString().Trim())) {

                        AddedFields.Remove(Row.Cells[0].Value.ToString().Trim());

                        if (Row.Cells[1].Value == null || Row.Cells[1].Value.ToString().Length < 1)
                        {

                            ToRemove.Add(Row);
                            continue;

                        }

                    }

                    if (ToAdd.Contains(Row.Cells[0].Value.ToString().Trim()))
                    {

                        ToAdd.Remove(Row.Cells[0].Value.ToString().Trim());

                    }

                }

            }

            foreach (DataGridViewRow Row in ToRemove)
            {

                Control.Rows.Remove(Row);

            }

            foreach (String Item in ToAdd)
            {

                DataGridViewRow RowToAdd = new DataGridViewRow();
                RowToAdd.CreateCells(Control);
                RowToAdd.Cells[0].Value = Item;
                Control.Rows.Add(RowToAdd);
                AddedFields.Add(Item);

            }

        }

        public static List<String> GetTemplateList()
        {

            return FileUtil.GetTemplateList();

        }

        public static void PopulateTemplateBox(ComboBox ComboControl, Record Record)
        {

            List<String> Templates = GetTemplateList();

            if (Templates.Count == 0)
            {

                ComboControl.Enabled = false;
                ComboControl.Items.Clear();
                ComboControl.Text = "no tempaltes";
                return;

            }

            ComboControl.Enabled = true;
            ComboControl.Items.Clear();

            if (Templates.Count > 0)
            {

                ComboControl.Items.Add("");

            }

            foreach (String Item in Templates)
            {

                if (Item.Trim().Length != 0)
                {

                    ComboControl.Items.Add(Item);

                }

            }

            if (Record.Template != "")
            {

                ComboControl.SelectedText = Record.Template;

            }

        }

        public static void PopulateScriptBox(ComboBox ComboControl, Button ButtonControl, String TemplateName)
        {

            TemplateName = "CDOT Wiki";
            List<String> Files = FileUtil.GetScriptList(TemplateName);

            ComboControl.Items.Clear();

            if (Files.Count < 1)
            {

                ComboControl.Visible = false;
                ButtonControl.Visible = false;

            }

            else
            {

                ComboControl.Visible = true;
                ButtonControl.Visible = true;

                ComboControl.Items.Add("Select...");
                ComboControl.SelectedIndex = 0;

                foreach (String Item in Files)
                {

                    ComboControl.Items.Add(Item);

                }

            }

            return;

        }

        public static String GetUserSaveOption()
        {

            String SaveOption = "Automatic";

            foreach (Option Item in DataHolder.CurrentUser.Options)
            {

                if (Item.Key == "Save")
                {

                    SaveOption = Item.Value;
                    break;

                }

            }

            Console.WriteLine(SaveOption);
            return SaveOption;

        }

        public static void SetUserSaveOption(String SaveValue)
        {

            Boolean HasSaveValue = false;

            foreach (Option Item in DataHolder.CurrentUser.Options)
            {

                if (Item.Key == "Save")
                {

                    HasSaveValue = true;
                    Item.Value = SaveValue;
                    break;

                }

            }

            if (!HasSaveValue)
            {

                Option NewOption = new Option();
                NewOption.Key = "Save";
                NewOption.Value = SaveValue;
                DataHolder.CurrentUser.Options.Add(NewOption);

            }

        }

        public static String GetUserSyncOption()
        {

            String SyncOption = "Automatic";

            foreach (Option Item in DataHolder.CurrentUser.Options)
            {

                if (Item.Key == "Sync")
                {

                    SyncOption = Item.Value;
                    break;

                }

            }

            return SyncOption;

        }

        public static void SetUserSyncOption(String SyncValue)
        {

            Boolean HasSyncValue = false;

            foreach (Option Item in DataHolder.CurrentUser.Options)
            {

                if (Item.Key == "Sync")
                {

                    HasSyncValue = true;
                    Item.Value = SyncValue;
                    break;

                }

            }

            if (!HasSyncValue)
            {

                Option NewOption = new Option();
                NewOption.Key = "Sync";
                NewOption.Value = SyncValue;
                DataHolder.CurrentUser.Options.Add(NewOption);

            }

        }

        public Boolean CreateAccount(String Username, String Password, 
                                     String SecretQuestion, String SecretAnswer,
                                     String SecretQuestion2, String SecretAnswer2)
        {
            BFormatter = new BinaryFormatter(); 
            User NewUser = new User();
            NewUser.Username = Username;
            if (new CheckString().ValidPasswordCheck(Username, Password))
                NewUser.Password = Password;
            NewUser.SecretQuestion = SecretQuestion;
            NewUser.SecretAnswer = SecretAnswer;
            NewUser.SecretQuestion = SecretQuestion2;
            NewUser.SecretAnswer = SecretAnswer2;
            NewUser.Created = DateTime.Now;
            NewUser.Modified = DateTime.Now;
            
            Boolean created = false;
            // TODO: remove and /use file util
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

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
 
            return created;
        }

        public Boolean DeserializeUsers(String filename)
        {
            Boolean retrieved;
            User getUser;
            // TODO: remove and /use file util
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
                List<String> filenames = FileUtil.FindUserFiles();
                // TODO use file util class
                foreach (string f in filenames)
                {
                    DeserializeUsers(f);
                }
                retrieved = true;
                loaded = true;
                
            }

            catch (Exception ex)
            {
                retrieved = false;
                MessageBox.Show(ex.Message);
            }
            
            return retrieved;
        }

        public String GetSecretQuestion(String Username, Int32 QuestionNumber)
        {
            String Question = "No Secret Questions Available";
             if (!loaded)
            {
                LoadUsers();
            }

             if (loaded)
             {

                 User tempUser = DataHolder.UserList.Find(x => x.Username.Equals(Username));
                 if (tempUser != null)
                 {
                     if (QuestionNumber == 1)
                        Question = tempUser.SecretQuestion;

                     else if (QuestionNumber == 2)
                        Question = tempUser.SecretQuestion2;
                 }
                                  
             }
             return Question;
        }

        public Boolean AccountExists(String Username)
        {
            Boolean exists = false;
            if (!loaded)
            {
                LoadUsers();
            }

            if (loaded)
            {
                exists = DataHolder.UserList.Exists(x => x.Username == Username);
            }

            return !exists;
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

        public static void AddRecord()
        {
            Record NewRecord = new Record();
            DataHolder.CurrentUser.Records.Add(NewRecord);
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
            if (DataHolder.CurrentUser.Records == null)
            {
                List<Record> recordList = new List<Record>();
                DataHolder.CurrentUser.Records = recordList;
            }

            if (Record.Fields == null)
            {
                List<Field> fieldList = new List<Field>();
                Record.Fields = fieldList;
            }
            Field NewField = new Field();
            NewField.Key = Key;
            NewField.Value = Value;
            Record.Fields.Add(NewField);
        }

        public static void AddRecord(String RecordName, String Key, String Value)
        {

            if (DataHolder.CurrentUser.Records == null)
            {
                List<Record> recordList = new List<Record>();
                DataHolder.CurrentUser.Records = recordList;
            }
            Record rc = new Record();
            rc.Name = RecordName;
            DataHolder.CurrentUser.Records.Add(rc);
            AddField(rc, Key, Value);
            return;
        }

        public static void ApplyRecordChanges(Record CurrentRecord, DataGridView Data, ComboBox Template)
        {
            if (CurrentRecord == null)
            {
                CurrentRecord = new Record();
            }
            CurrentRecord.Fields.Clear();
            
            foreach ( DataGridViewRow Row in  Data.Rows) {
                
                    Field f = new Field();
                    if (Row.Index < Data.NewRowIndex)
                    {
                        if (Row.Cells[0].Value == null)
                            f.Key = "";
                        else
                            f.Key = Row.Cells[0].Value.ToString();
                        if (Row.Cells[1].Value == null)
                            f.Value = "";
                        else
                            f.Value = Row.Cells[1].Value.ToString();
                   
                        CurrentRecord.Fields.Add(f);
                    }       
            }

            if (Template.Enabled == true)
            {
                CurrentRecord.Template = Template.Text;
            }

         }

        public static void DeleteRecord(Record record)
        {
            if(record != null)
            DataHolder.CurrentUser.Records.Remove(record);
        }

        public static Record GetRecord(Int32 recordIndex)
        {
            Record rc = new Record();
            try 
	        {	        
		        rc = DataHolder.CurrentUser.Records[recordIndex];
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
            return rc;
        }

        public static Record GetRecordByName(String RecordName)
        {
            return DataHolder.CurrentUser.Records.Find(x => x.Name.Contains(RecordName));
        }

        public static List<Record> GetRecordsByName(String RecordName)
        {
            return DataHolder.CurrentUser.Records.FindAll(r => r.Name.Contains(RecordName));
        }

        public static List<Record> GetRecordListByName(List<Record> CurrentRecords, String RecordName)
        {
            return CurrentRecords.FindAll(r => r.Name.Contains(RecordName));
        }

        public static List<Record> GetRecordListByCategory(List<Record> CurrentRecords, String CategoryName)
        {
            return CurrentRecords.FindAll(r => r.Category.Name.Contains(CategoryName));
        }

        public static Boolean VerifyPassword(String Password)
        {
            Boolean Validpassword = false;
                 if (Password == DataHolder.CurrentUser.Password)
                     Validpassword = true;

                 return Validpassword;


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
        public static void SaveUserProfileChanges(string username, string firstName, string lastName) 
        {
            DataHolder.CurrentUser.Username = username;
            DataHolder.CurrentUser.FirstName = firstName;
            DataHolder.CurrentUser.LastName = lastName;
        }
         
        public static string SaveUserProfilePassword(string currentPassword, string newPassword, string confirmPassword) 
        {
            string result;
            if (currentPassword == DataHolder.CurrentUser.Password)
            {
                if (newPassword.Length < 6 || newPassword.Length > 25)
                {
                    result = "password length";
                }
                else if (newPassword == DataHolder.CurrentUser.Username) 
                {
                    result = "matches username";
                }
                else if (newPassword.Trim() != confirmPassword.Trim())
                {
                    // return error - new/confirm passwords don't match
                    result = "new passwords don't match";
                    
                }
                else
                {
                    // password strength
                    result = "password changed";
                }
            }
            else
            {
                // current password incorrect
                result = "password incorrect";
            }
            return result;
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

        public static void Logout()
        {
            bool result = false;
            
            DataHolder.CurrentUser = null;
              
        //    return result;
        }

        public static bool ValidateCategoryUnique(string category)
        {
            bool result = true;

            var item = DataHolder.CurrentUser.Categories.FirstOrDefault(o => o.Name == category);
            if (item != null)
                result = false;

            return result;
        }

        public static bool ValidateCategoryLength(string category)
        {
            bool result = true;

            if (category.Length < 3 || category.Length > 25)
            {
                result = false;
            }
            
            return result;

        }

        public static bool ValidateUsernameLength(string username)
        {
            bool result = true;

            if (username.Length < 3 || username.Length > 25)
            {
                result = false;
            }

            return result;
        }

        public static bool ValidateFirstName(string firstName)
        {
            bool result = true;

            if (firstName.Length < 2 || firstName.Length > 25)
            {
                result = false;
            }
            
            String pattern = "[a-zA-Z]{1,25}$";
            Regex regex = new Regex(pattern);
            
            if (!regex.IsMatch(firstName)) 
            {
                result = false;
            }

            return result;
        }

        public static bool ValidateLastName(string lastName)
        {
            bool result = true;

            if (lastName.Length < 3 || lastName.Length > 25)
            {
                result = false;
            }

            String pattern = "[a-zA-Z]{1,25}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(lastName))
            {
                result = false;
            }

            return result;
        }
    }

}

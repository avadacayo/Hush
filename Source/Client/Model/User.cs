using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    [Serializable]
    class User : ISerializable
    {
        private List<Category> _Categories;
        private DateTime _Created;
        private String _Username;
        private String _FirstName;
        private String _ID;
        private String _LastName;
        private DateTime _Modified;
        private List<Option> _Options;
        private String _Password;
        private Byte[] _Portrait;
        private List<Record> _Records;
        private String _SecretAnswer;
        private String _SecretQuestion;
        private String _SecretAnswer2;
        private String _SecretQuestion2;

        #region Properties
        
        public List<Category> Categories
        {

            get { return _Categories; }
            set { _Categories = value; }

        }

        public DateTime Created
        {
            get { return _Created; }
            set { _Created = value; }

        }

        public String FirstName
        {

            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public String ID
        {

            get { return _ID; }
            set { _ID = value; }

        }
        public String Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public String LastName
        {

            get { return _LastName; }
            set { _LastName = value; }
        }

        public DateTime Modified
        {
            get { return _Modified; }
            set { _Modified = value; }
        }

        public List<Option> Options
        {
            get { return _Options; }
            set { _Options = value; }
        }

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public Byte[] Portrait
        {
            get { return _Portrait; }
            set { _Portrait = value; }
        }

        public List<Record> Records
        {

            get { return _Records; }
            set { _Records = value; }

        }

        public String SecretAnswer
        {

            get { return _SecretAnswer; }
            set { _SecretAnswer = value; }

        }

        public String SecretQuestion
        {

            get { return _SecretQuestion; }
            set { _SecretQuestion = value; }

        }

        public String SecretAnswer2
        {

            get { return _SecretAnswer2; }
            set { _SecretAnswer2 = value; }

        }

        public String SecretQuestion2
        {

            get { return _SecretQuestion2; }
            set { _SecretQuestion2 = value; }

        }
        #endregion

        public User()
        {

            _Categories = new List<Category>();
            _Created = DateTime.Now;
            _FirstName = String.Empty;
            _ID = String.Empty;
            _LastName = String.Empty;
            _Modified = DateTime.Now;
            _Options = new List<Option>();
            _Password = String.Empty;
            _Portrait = new Byte[1];
            _Records = new List<Record>();
            _SecretAnswer = String.Empty;
            _SecretQuestion = String.Empty;
            _SecretAnswer2 = String.Empty;
            _SecretQuestion2 = String.Empty;
            _Username = String.Empty;

        }

        protected User(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new System.ArgumentNullException("Info");

            }

            _Categories = (List<Category>)Info.GetValue("Categories", typeof(List<Category>));
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _FirstName = (String)Info.GetValue("FirstName", typeof(String));
            _ID = (String)Info.GetValue("ID", typeof(String));
            _LastName = (String)Info.GetValue("LastName", typeof(String));
            _Modified = (DateTime)Info.GetValue("Modified", typeof(DateTime));
            _Options = (List<Option>)Info.GetValue("Options", typeof(List<Option>));
            _Password = (String)Info.GetValue("Password", typeof(String));
            _Portrait = (Byte[])Info.GetValue("Portrait", typeof(Byte[]));
            _SecretAnswer = (String)Info.GetValue("SecretAnswer", typeof(String));
            _SecretQuestion = (String)Info.GetValue("SecretQuestion", typeof(String));
            _SecretAnswer2 = (String)Info.GetValue("SecretAnswer2", typeof(String));
            _SecretQuestion2 = (String)Info.GetValue("SecretQuestion2", typeof(String));
            _Records = (List<Record>)Info.GetValue("Records", typeof(List<Record>));
            _Username = (String)Info.GetValue("Username", typeof(String));

        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new ArgumentNullException("Info");

            }


            Info.AddValue("Created", _Created);
            Info.AddValue("Categories", _Categories);
            Info.AddValue("FirstName", _FirstName);
            Info.AddValue("ID", _ID);
            Info.AddValue("LastName", _LastName);
            Info.AddValue("Modified", _Modified);
            Info.AddValue("Options", _Options);
            Info.AddValue("Password", _Password);
            Info.AddValue("Portrait", _Portrait);
            Info.AddValue("Records", _Records);
            Info.AddValue("SecretAnswer", _SecretAnswer);
            Info.AddValue("SecretQuestion", _SecretQuestion);
            Info.AddValue("SecretAnswer2", _SecretAnswer2);
            Info.AddValue("SecretQuestion2", _SecretQuestion2);
            Info.AddValue("Username", _Username);

        }

    }

}

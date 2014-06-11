using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Hush.Client.Model;

namespace Hush.Client.Model
{
    [Serializable]
    class User : ISerializable
    {
        private String _ID;
        private String _Handle;
        private String _FirstName;
        private String _LastName;
        private String _Password;
        private String _SecretQuestion;
        private String _SecretAnswer;
        private Byte[] _Portrait;
        private DateTime _Created;
        private DateTime _Modified;
        private List<Record> _Records;
        private List<Category> _Categories;
        private List<Option> _Options;

        public User()
        {
        }

        protected User(SerializationInfo Info, StreamingContext context)
        {
            if (Info == null)
                throw new System.ArgumentNullException("Info");

            _ID = (String)Info.GetValue("ID", typeof(String));
            _Handle = (String)Info.GetValue("Handle", typeof(String));
            _FirstName = (String)Info.GetValue("FirstName", typeof(String));
            _LastName = (String)Info.GetValue("LastName", typeof(String));
            _Password = (String)Info.GetValue("Password", typeof(String));
            _SecretQuestion = (String)Info.GetValue("SecretQuestion", typeof(String));
            _SecretAnswer = (String)Info.GetValue("SecretAnswer", typeof(String));
            _Portrait = (Byte[])Info.GetValue("Portrait", typeof(Byte[]));
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _Modified = (DateTime)Info.GetValue("Modified", typeof(DateTime));
            _Records = (List<Record>)Info.GetValue("Records", typeof(List<Record>));
            _Categories = (List<Category>)Info.GetValue("Categories", typeof(List<Category>));
            _Options = (List<Option>)Info.GetValue("Options", typeof(List<Option>));
        }

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public String Handle
        {
            get { return _Handle; }
            set { _Handle = value; }
        }
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public String SecretQuestion
        {
            get { return _SecretQuestion; }
            set { _SecretQuestion = value; }
        }
        public String SecretAnswer
        {
            get { return _SecretAnswer; }
            set { _SecretAnswer = value; }
        }
        public Byte[] Portrait
        {
            get { return _Portrait; }
            set { _Portrait = value; }
        }
        public DateTime Created
        {
            get { return _Created; }
            set { _Created = value; }
        }
        public DateTime Modified
        {
            get { return _Modified; }
            set { _Modified = value; }
        }
        public List<Record> Records
        {
            get { return _Records; }
            set { _Records = value; }
        }

        
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {
            if (Info == null)
            {
                throw new ArgumentNullException("Info");
            }

            Info.AddValue("ID", _ID);
            Info.AddValue("Handle", _Handle);
            Info.AddValue("FirstName", _FirstName);
            Info.AddValue("LastName", _LastName);
            Info.AddValue("Password", _Password);
            Info.AddValue("SecretQuestion", _SecretQuestion);
            Info.AddValue("SecretAnswer", SecretAnswer);
            Info.AddValue("Portrait", _Portrait);
            Info.AddValue("Created", _Created);
            Info.AddValue("Modified", _Modified);
            Info.AddValue("Records", _Records);
            Info.AddValue("Categories", _Categories);
            Info.AddValue("Options", _Options);
        }
    } 
}

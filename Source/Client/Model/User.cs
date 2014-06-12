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
        private Byte[] _Portrait;
        private DateTime _Created;
        private DateTime _Modified;
        private List<Record> _Records;
        private List<Category> _Categories;
        private List<Option> _Options;

        public User()
        {
            //_ID = String.Empty;
            //_Handle = String.Empty;
            //_FirstName = String.Empty;
            //_LastName = String.Empty;
            //_Password = String.Empty;
            //_Portrait = null;
            //_Created = DateTime.Now;
            //_Modified = DateTime.Now;
            //_Records = new List<Record>(); 
            //_Categories = new List<Category>();
            //_Options = new List<Option>();
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
            _Portrait = (Byte[])Info.GetValue("Portrait", typeof(Byte[]));
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _Modified = (DateTime)Info.GetValue("Modified", typeof(DateTime));
            _Records = (List<Record>)Info.GetValue("Records", typeof(List<Record>));
            _Categories = (List<Category>)Info.GetValue("Categories", typeof(List<Category>));
            _Options = (List<Option>)Info.GetValue("Options", typeof(List<Option>));
        }

        public String ID { get; set; }
        public String Handle { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public Byte[] Portrait { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public List<Record> Records { get; set; }
        public List<Category> Categories { get; set; }

        
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
            Info.AddValue("Portrait", _Portrait);
            Info.AddValue("Created", _Created);
            Info.AddValue("Modified", _Modified);
            Info.AddValue("Records", _Records);
            Info.AddValue("Categories", _Categories);
            Info.AddValue("Options", _Options);
        }
    } 
}

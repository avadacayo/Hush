using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{
    [Serializable]
    class Category : ISerializable
    {
        private String _ID;
        private String _Name;
        private List<Record> _Records;
        private DateTime _Created;


        public Category()
        {
            //_ID = string.Empty;
            //_Name = string.Empty;
            //_Records = new List<Record>();
            //_Created = DateTime.Now;
        }

        protected Category(SerializationInfo Info, StreamingContext context)
        {
            if (Info == null)
                throw new System.ArgumentNullException("Info");

            _ID = (String)Info.GetValue("ID", typeof(String));
            _Name = (String)Info.GetValue("Name", typeof(String));
            _Records = (List<Record>)Info.GetValue("Record", typeof(List<Record>));
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
        }

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public List<Record> Records
        {
            get { return _Records; }
            set { _Records = value; }
        }
        public DateTime Created
        {
            get { return _Created; }
            set { _Created = value; }
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {
            if (Info == null)
            {
                throw new ArgumentNullException("Info");
            }

            Info.AddValue("ID", _ID);
            Info.AddValue("Name", _Name);
            Info.AddValue("Records", _Records);
            Info.AddValue("Created", _Created);
        }
    }
}

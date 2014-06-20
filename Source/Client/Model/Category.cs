using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    [Serializable]
    class Category : ISerializable
    {

        private Category _Category;
        private DateTime _Created;
        private String _ID;
        private String _Name;
        private List<Record> _Records;

        #region Properties

        public Category ParentCategory
        {

            get { return _Category; }
            set { _Category = value; }

        }

        public DateTime Created
        {

            get { return _Created; }
            set { _Created = value; }

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

        #endregion

        public Category()
        {

            _Category = null;
            _Created = DateTime.Now;
            _ID = String.Empty;
            _Name = String.Empty;
            _Records = new List<Record>();

        }

        protected Category(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new System.ArgumentNullException("Info");

            }

            _Category = null;
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _ID = (String)Info.GetValue("ID", typeof(String));
            _Name = (String)Info.GetValue("Name", typeof(String));
            _Records = (List<Record>)Info.GetValue("Record", typeof(List<Record>));

        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new ArgumentNullException("Info");

            }

            Info.AddValue("Category", 0);
            Info.AddValue("Created", _Created);
            Info.AddValue("ID", _ID);
            Info.AddValue("Name", _Name);
            Info.AddValue("Records", _Records);

        }

    }

}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    [Serializable]
    class Category : ISerializable
    {

        private DateTime _Created;
        private String _ID;
        private String _Name;
        private Category _ParentCategory;
        private List<Record> _Records;

        #region Properties

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

        public Category ParentCategory
        {

            get { return _ParentCategory; }
            set { _ParentCategory = value; }

        }

        public List<Record> Records
        {

            get { return _Records; }
            set { _Records = value; }

        }

        #endregion

        public Category()
        {

            _Created = DateTime.Now;
            _ID = String.Empty;
            _Name = String.Empty;
            _ParentCategory = null;
            _Records = new List<Record>();

        }

        protected Category(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new System.ArgumentNullException("Info");

            }

            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _ID = (String)Info.GetValue("ID", typeof(String));
            _Name = (String)Info.GetValue("Name", typeof(String));
            _ParentCategory = null;
            _Records = (List<Record>)Info.GetValue("Record", typeof(List<Record>));

        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new ArgumentNullException("Info");

            }

            Info.AddValue("Created", _Created);
            Info.AddValue("ID", _ID);
            Info.AddValue("Name", _Name);
            Info.AddValue("ParentCategory", 0);
            Info.AddValue("Records", _Records);

        }

    }

}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    [Serializable]
    class Record : ISerializable
    {

        private Category _Category;
        private DateTime _Created;
        private List<Field> _Fields;
        private String _ID;
        private DateTime _Modified;
        private String _Name;
        private String _Template;

        #region Properties

        public Category Category
        {

            get { return _Category; }
            set { _Category = value; }

        }

        public DateTime Created
        {

            get { return _Created; }
            set { _Created = value; }

        }

        public List<Field> Fields
        {

            get { return _Fields; }
            set { _Fields = value; }

        }

        public String ID
        {

            get { return _ID; }
            set { _ID = value; }

        }

        public DateTime Modified
        {

            get { return _Modified; }
            set { _Modified = value; }

        }

        public String Name
        {

            get { return _Name; }
            set { _Name = value; }

        }

        public String Template
        {

            get { return _Template; }
            set { _Template = value; }

        }

        #endregion

        public Record()
        {

            _Category = new Category();
            _Created = DateTime.Now;
            _Fields = new List<Field>();
            _ID = String.Empty;
            _Modified = DateTime.Now;
            _Name = String.Empty;
            _Template = String.Empty;

        }

        protected Record(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new System.ArgumentNullException("Info");

            }

            _Category = (Category)Info.GetValue("Category", typeof(Category));
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _Fields = (List<Field>)Info.GetValue("Fields", typeof(List<Field>));
            _ID = (String)Info.GetValue("ID", typeof(String));
            _Modified = (DateTime)Info.GetValue("Modified", typeof(DateTime));
            _Name = (String)Info.GetValue("Name", typeof(String));
            _Template = (String)Info.GetValue("Template", typeof(String));

        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new ArgumentNullException("Info");

            }

            Info.AddValue("Category", _Category);
            Info.AddValue("Created", _Created);
            Info.AddValue("Fields", _Fields);
            Info.AddValue("ID", _ID);
            Info.AddValue("Modified", _Modified);
            Info.AddValue("Name", _Name);
            Info.AddValue("Template", _Template);

        }

    }

}

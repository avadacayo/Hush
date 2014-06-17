using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    class Record : ISerializable
    {
        private String _ID;
        private String _Name;
        private String _TemplateID;
        private Category _Category;
        private List<Field> _Fields;
        private DateTime _Created;
        private DateTime _Modified;

        public Record()
        {
            //_ID = string.Empty;
            //_TemplateID = string.Empty;
            //_Category = new Category();
            //_Fields = new List<Field>();
            //_Created = DateTime.Now;
            //_Modified = DateTime.Now;
        }

        protected Record(SerializationInfo Info, StreamingContext context)
        {
            if (Info == null)
                throw new System.ArgumentNullException("Info");

            _ID = (String)Info.GetValue("ID", typeof(String));
            _Name = (String)Info.GetValue("Name", typeof(String));
            _TemplateID = (String)Info.GetValue("TemplateID", typeof(String));
            _Category = (Category)Info.GetValue("Category", typeof(Category));
            _Fields = (List<Field>)Info.GetValue("Fields", typeof(List<Field>));
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _Modified = (DateTime)Info.GetValue("Modified", typeof(DateTime));
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

        public String TemplateID
        {
            get { return _TemplateID; }
            set { _TemplateID = value; }
        }
        public Category Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        public List<Field> Fields
        {
            get { return _Fields; }
            set { _Fields = value; }
        }
        public DateTime Created
        {
            get { return _Created; }
            set { _Created = value; }
        }
        public DateTime Modified { get; set; }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {
            if (Info == null)
            {
                throw new ArgumentNullException("Info");
            }

            Info.AddValue("ID", _ID);
            Info.AddValue("Name", _Name);
            Info.AddValue("TemplateID", _TemplateID);
            Info.AddValue("Category", _Category);
            Info.AddValue("Fields", _Fields);
            Info.AddValue("Created", _Created);
            Info.AddValue("Modified", _Modified);
        }
    }

}

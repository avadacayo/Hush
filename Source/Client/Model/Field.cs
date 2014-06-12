using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Hush.Client.Model
{
    class Field : ISerializable
    {
        private String _ID;
        private String _Key;
        private String _Value;
        private DateTime _Created;
        private DateTime _Modified;

        public Field()
        {
            //_ID = string.Empty;
            //_Key = string.Empty;
            //_Value = string.Empty;
            //_Created = DateTime.Now;
            //_Modified = DateTime.Now;
        }

        protected Field(SerializationInfo Info, StreamingContext context)
        {
            if (Info == null)
                throw new System.ArgumentNullException("Info");

            _ID = (String)Info.GetValue("ID", typeof(String));
            _Key = (String)Info.GetValue("Key", typeof(String));
            _Value = (String)Info.GetValue("Value", typeof(String));
            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _Modified = (DateTime)Info.GetValue("Modified", typeof(DateTime));
        }

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public String Key
        {
            get { return _Key; }
            set { _Key = value; }
        }
        public String Value
        {
            get { return _Value; }
            set { _Value = value; }
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

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {
            if (Info == null)
            {
                throw new ArgumentNullException("Info");
            }

            Info.AddValue("ID", _ID);
            Info.AddValue("Key", _Key);
            Info.AddValue("Value", _Value);
            Info.AddValue("Created", _Created);
            Info.AddValue("Modified", _Modified);
        }

    }
}

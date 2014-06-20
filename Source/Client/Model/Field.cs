using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    [Serializable]
    class Field : ISerializable
    {

        private DateTime _Created;
        private String _ID;
        private String _Key;
        private DateTime _Modified;
        private String _Value;

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

        public String Key
        {

            get { return _Key; }
            set { _Key = value; }

        }

        public DateTime Modified
        {

            get { return _Modified; }
            set { _Modified = value; }

        }

        public String Value
        {

            get { return _Value; }
            set { _Value = value; }

        }

        #endregion

        public Field()
        {

            _Created = DateTime.Now;
            _ID = String.Empty;
            _Key = String.Empty;
            _Modified = DateTime.Now;
            _Value = String.Empty;

        }

        protected Field(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new System.ArgumentNullException("Info");

            }

            _Created = (DateTime)Info.GetValue("Created", typeof(DateTime));
            _ID = (String)Info.GetValue("ID", typeof(String));
            _Key = (String)Info.GetValue("Key", typeof(String));
            _Modified = (DateTime)Info.GetValue("Modified", typeof(DateTime));
            _Value = (String)Info.GetValue("Value", typeof(String));

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
            Info.AddValue("Key", _Key);
            Info.AddValue("Modified", _Modified);
            Info.AddValue("Value", _Value);

        }

    }

}

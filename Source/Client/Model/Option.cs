using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    [Serializable]
    class Option : ISerializable
    {

        private String _ID;
        private String _Key;
        private String _Value;

        #region Properties

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

        #endregion

        public Option()
        {

            _ID = String.Empty;
            _Key = String.Empty;
            _Value = String.Empty;

        }

        protected Option(SerializationInfo Info, StreamingContext context)
        {

            if (Info == null)
            {

                throw new System.ArgumentNullException("Info");

            }

            _ID = (String)Info.GetValue("ID", typeof(String));
            _Key = (String)Info.GetValue("Key", typeof(String));
            _Value = (String)Info.GetValue("Value", typeof(String));

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

        }

    }

}

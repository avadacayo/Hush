using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Hush.Client.Model
{

    [Serializable]
    class Template: ISerializable
    {

        private String _Name;

        #region Properties

        public String Name
        {

            get { return _Name; }
            set { _Name = value; }

        }

        #endregion

        public Template()
        {

            _Name = String.Empty;

        }

        protected Template(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new System.ArgumentNullException("Info");

            }

            _Name = (String)Info.GetValue("Name", typeof(String));

        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData(SerializationInfo Info, StreamingContext Context)
        {

            if (Info == null)
            {

                throw new ArgumentNullException("Info");

            }

            Info.AddValue("Name", _Name);

        }

    }

}

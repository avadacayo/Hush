using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hush.Display.Interfaces
{

    class Interface : Form
    {

        protected Font GlobalFont = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));

        public Interface()
        {
            Initialize(String.Empty, String.Empty);
        }

        #region Designer

        protected virtual void Initialize(String Name, String Text)
        {

            this.Name = Name;

        }

        #endregion

    }

}

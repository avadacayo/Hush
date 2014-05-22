﻿using System;
using System.Drawing;
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
            this.Width = 616; // inner width = 600
            this.Height = 638; // inner height = 600

        }

        #endregion

    }

}

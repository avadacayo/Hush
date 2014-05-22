using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hush.Display.Interfaces
{

    class Interface : Panel
    {

        protected Font GlobalFont = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));

        public Interface()
        {
            Initialize(String.Empty);
        }

        public Interface(String Title)
        {
            Initialize(Title);
        }

        #region Designer

        protected virtual void Initialize(String Title)
        {

            if (String.Empty == Title)
                Title = "Hush";
            else
                Title = "Hush > " + Title;

            Height = 600;
            Location = new Point(0, 0);
            Text = Title;
            Width = 600;

        }

        #endregion

    }

}

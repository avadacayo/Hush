using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hush.Display.Interfaces
{

    class Interface : Panel
    {

        protected Font GlobalFont = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));

        public Interface()
        {
            Initialize(new List<String>());
        }

        public Interface(String Title)
        {
            Initialize(new List<String>(new string[] {Title}));
        }

        protected Font GetFontVariant(Boolean Bold)
        {
            FontStyle TempStyle =  Bold ? FontStyle.Bold : FontStyle.Regular;
            return new Font("Verdana", 8F, TempStyle, GraphicsUnit.Point, ((Byte)(0)));
        }

        #region Designer

        protected virtual void Initialize(List<String> Title)
        {

            String TitleString = String.Empty;

            Title.Add("Hush");
            Title.Reverse();

            foreach (String Item in Title)
            {

                if (String.Empty != TitleString)
                    TitleString += " > ";
                TitleString += Item;

            }

            Height = 700;
            Location = new Point(0, 0);
            Text = TitleString;
            Width = 900;

        }

        #endregion

    }

}

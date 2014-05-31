using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hush.Display.Interfaces
{

    class Interface : UserControl
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

        protected void PlaceBelow(Control Anchor, Control ToPlace)
        {
            ToPlace.Location = new Point(Anchor.Location.X, Anchor.Location.Y + Anchor.Size.Height);
        }

        protected Font GetFontVariant(Boolean Bold)
        {
            FontStyle TempStyle =  Bold ? FontStyle.Bold : FontStyle.Regular;
            return new Font("Verdana", 8F, TempStyle, GraphicsUnit.Point, ((Byte)(0)));
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Font = GlobalFont;
        }

        #region Designer

        protected virtual void Initialize(List<String> Title)
        {

            InitializeComponent();

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

        protected virtual void InitializeComponent()
        {
            return;
        }

        #endregion

    }

}

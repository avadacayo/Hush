using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hush.Display.Interfaces
{

    class Interface : UserControl
    {

        private ParentWindow _ParentWindow = null;

        #region Properties

        public ParentWindow ParentWindow
        {

            get { return _ParentWindow; }
            set { _ParentWindow = value; }

        }

        #endregion

        public Interface()
        {

            Initialize(new List<String>());

        }

        public Interface(String Title)
        {

            Initialize(new List<String>(new String[] {Title}));

        }

        public void Close()
        {

            _ParentWindow.Close();

        }

        protected void PlaceBelow(Control Anchor, Control ToPlace)
        {

            ToPlace.Location = new Point(Anchor.Location.X, Anchor.Location.Y + Anchor.Size.Height);

        }

        #region Overrides

        protected override void OnControlAdded(ControlEventArgs e)
        {

            base.OnControlAdded(e);

            Font OldFont = e.Control.Font;
            Font NewFont = new Font("Verdana", OldFont.Size, OldFont.Style, OldFont.Unit, OldFont.GdiCharSet);
            e.Control.Font = NewFont;

        }

        #endregion

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

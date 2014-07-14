using Hush.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hush.Display.Interfaces
{

    class Interface : UserControl
    {

        protected Boolean _HasClosingSave = false;
        protected Boolean _SizeOverride = false;
        private ParentWindow _ParentWindow = null;

        #region Properties

        public Boolean HasClosingSave
        {

            get { return _HasClosingSave; }

        }

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

            Initialize(new List<String>(new String[] { Title }));

        }

        public virtual void PostInit()
        {
        }

        public virtual void ClosingSave()
        {
        }

        public void Close()
        {

            try
            {

                _ParentWindow.Close();

            }

            catch (Exception E)
            {
            }

        }

        #region Overrides

        protected override void OnControlAdded(ControlEventArgs e)
        {

            base.OnControlAdded(e);
            

            Font OldFont = e.Control.Font;
            float size = OldFont.Size;
            if (size < 10)
            {
                size = 10;
            }
            Font NewFont = new Font("Verdana", size, OldFont.Style, OldFont.Unit, OldFont.GdiCharSet);
            e.Control.Font = NewFont;

        }

        #endregion

        #region Designer

        protected virtual void Initialize(List<String> Title)
        {

            InitializeComponent();

            Size FormSize = this.ClientSize;
            String TitleString = String.Empty;

            Title.Add("Hush");
            Title.Reverse();

            foreach (String Item in Title)
            {

                if (String.Empty != TitleString)
                    TitleString += " > ";
                TitleString += Item;

            }

            Height = 500;
            Location = new Point(0, 0);
            Text = TitleString;
            Width = 415;

            if (_SizeOverride)
            {

                ClientSize = FormSize;

            }

        }

        protected virtual void InitializeComponent()
        {

            return;

        }

        #endregion

    }

}

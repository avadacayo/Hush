﻿using System;
using System.Drawing;
using System.Windows.Forms;

using Hush.Display.Interfaces;
using System.ComponentModel;

namespace Hush.Display
{

    class ParentWindow : Form
    {

        private Interface CurrentInterface = null;

        public ParentWindow()
        {

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen; 

            ShowInterface(new TestScreen());

        }

        public void ShowInterface(Interface ToShow)
        {

            SuspendLayout();

            if (CurrentInterface != null)
                Controls.Remove(CurrentInterface);

            CurrentInterface = ToShow;
            Height = ToShow.Height + 38;
            Text = ToShow.Text;
            Width = ToShow.Width + 16;

            Controls.Add(ToShow);

            ResumeLayout(true);
            return;

        }

        #region Overrides

        protected override void OnClosing(CancelEventArgs Args)
        {

            base.OnClosing(Args);

            if (!(CurrentInterface is TestScreen))
            {

                ShowInterface(new TestScreen());
                Args.Cancel = true;

            }

        }

        #endregion

    }

}

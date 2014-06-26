using System.Drawing;
using System.Windows.Forms;

namespace Hush.Display.Controls
{

    class ScriptContentPanel : Panel
    {

        private void RefactorHeight()
        {

            Size NewSize = new Size();
            NewSize.Width = Size.Width;

            foreach (Control Item in Controls)
            {

                if (Item.Location.Y + Item.Size.Height > NewSize.Height)
                {

                    NewSize.Height = Item.Location.Y + Item.Size.Height;

                }

            }

            if (NewSize.Height >= 150)
            {

                NewSize.Height = 150;

            }

            this.Size = NewSize;

        }

        #region Overrides

        protected override void OnControlAdded(ControlEventArgs Args)
        {

            base.OnControlAdded(Args);
            RefactorHeight();

        }

        #endregion

    }

}

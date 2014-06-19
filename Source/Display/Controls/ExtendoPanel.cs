using System.Windows.Forms;
using System.Drawing;

namespace Hush.Display.Controls
{

    class ExtendoPanel : Panel
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

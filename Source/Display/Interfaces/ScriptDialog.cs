using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hush.Display.Interfaces
{
    class ScriptDialog : Interface
    {

        #region Designer

        protected override void Initialize(List<String> Title)
        {

            base.Initialize(Title);
            SuspendLayout();
            ResumeLayout(true);

        }

        #endregion

    }
}

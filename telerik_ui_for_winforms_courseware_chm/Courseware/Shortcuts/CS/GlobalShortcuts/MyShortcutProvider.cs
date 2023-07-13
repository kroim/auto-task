using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using System.Windows.Forms;

namespace GlobalShortcuts
{
    public class MyShortcutProvider : IShortcutProvider
    {
        private RadShortcutCollection shortcuts;
        private bool registered;

        public MyShortcutProvider()
        {
            this.shortcuts = new RadShortcutCollection(this);
        }

        #region IShortcutProvider Members

        public void OnPartialShortcut(PartialShortcutEventArgs e)
        {
            //This callback is called when a key that partially matches a registered shortcut is pressed
            //For example if we have CTRL + A, S pressing CTRL + A will execute this callback.
            //You will need to set the PartialShortcutEventArgs.Handled to true if you want to wait for the complete keyboard combination
            e.Handled = true;
        }

        public void OnShortcut(ShortcutEventArgs e)
        {
            //A keyboard combination for a specific shortcut is pressed.
            MessageBox.Show("Shortcut [" + e.Shortcut.GetDisplayText() + "] is executed.");
            //Mark the event arguments as "Handled" so that this shortcut is no further processed.
            e.Handled = true;
        }

        public void OnShortcutsChanged()
        {
            //Called by the Shortcuts collection when a shortcut is either added or removed from the collection
            //This is used for optimization purposes - e.g. is we do not have shortcuts registered,
            //we do not need to be registered with RadShortcutManager
            if (this.shortcuts.Count > 0)
            {
                if (!this.registered)
                {
                    RadShortcutManager.Instance.AddShortcutProvider(this);
                    this.registered = true;
                }
            }
            else
            {
                if (this.registered)
                {
                    RadShortcutManager.Instance.RemoveShortcutProvider(this);
                    this.registered = false;
                }
            }
        }

        public RadShortcutCollection Shortcuts
        {
            get
            {
                return this.shortcuts;
            }
        }

        #endregion
    }
}

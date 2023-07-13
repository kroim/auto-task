using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ButtonsShortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.radButton1.ButtonElement.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.B));
            this.radRadioButton1.ButtonElement.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.R));
            this.radSplitButton1.DropDownButtonElement.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.S));
            this.radToggleButton1.ButtonElement.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.T));

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("RadButton Clicked");
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            RadMessageBox.Show("RadRadioButton Clicked");
        }

        private void radSplitButton1_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("RadSplitButton Clicked");
        }

        private void radToggleButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            RadMessageBox.Show("RadToggleButton Clicked");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace MenuItemShortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.radMenuItem1.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.N));
            this.radMenuItem2.Shortcuts.Add(new RadShortcut(Keys.Shift, Keys.F, Keys.K));
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("New");
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("File");
        }
    }
}

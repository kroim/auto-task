using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace GlobalShortcuts
{
    public partial class Form1 : Form
    {

        MyShortcutProvider provider;

        public Form1()
        {
            InitializeComponent();

            provider = new MyShortcutProvider();
            provider.Shortcuts.Add(new RadShortcut(Keys.Control, Keys.A, Keys.S));
        }
    }
}

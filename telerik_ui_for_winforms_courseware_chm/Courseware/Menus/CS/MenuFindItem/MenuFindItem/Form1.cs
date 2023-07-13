using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MenuFindItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            RadMenuItem fileItem = (RadMenuItem)radMenu1.Items["miFile"];
            RadMenuItem openItem = (RadMenuItem)fileItem.Items["miOpen"];
            if (openItem != null)
            {
                fileItem.Items.Remove(openItem);
            }

            // finds the "Save" item from the "File" Items collection
            RadMenuItem saveItem =
              (RadMenuItem)fileItem.Items.FirstOrDefault(item => item.Name.Equals("miSave"));
            if (saveItem != null)
            {
                saveItem.ToolTipText = "Next automatic save at " + DateTime.Now.AddHours(0.5);
            }
        }
    }
}

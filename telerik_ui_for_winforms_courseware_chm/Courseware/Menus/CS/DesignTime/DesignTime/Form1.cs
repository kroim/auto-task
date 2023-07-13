using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DesignTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radMenu1.MenuElement.Children[1].Visibility = ElementVisibility.Hidden;
            radMenu1.Items[0].Children[0].Visibility = ElementVisibility.Hidden;
        }
    }
}

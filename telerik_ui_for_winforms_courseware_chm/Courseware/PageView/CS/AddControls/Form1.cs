using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace AddControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

      private void Form1_Load(object sender, EventArgs e)
        {
            // iterate the pages and add a button to each of them
            foreach (RadPageViewPage page in radPageView1.Pages)
            {
                RadButton button = new RadButton();
                button.Size = new Size(100, 30);
                button.Location = new Point(10, 10);
                button.Text = "Order " + item.Text;
                button.Click += new EventHandler(button_Click);
                page.Controls.Add(button);
            }

            // add a single button to the tab strip
           // tsTabsOnly.EnableTabControlMode = false;
            RadButton button2 = new RadButton();
            button2.Size = new Size(60, 30);
            button2.Location = new Point(10, 30);
            button2.Text = "Order";
            button2.Click += new EventHandler(button_Click);
        //    tsTabsOnly.Controls.Add(button2);
        }

      void button_Click(object sender, EventArgs e)
      {
          RadMessageBox.Show("You clicked " + (sender as RadButton).Text);
      }

        
    }
}

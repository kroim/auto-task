using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Data;

namespace _03_Grouping
{
    public partial class RadGridViewLab3 : Form
    {
        public RadGridViewLab3()
        {
            InitializeComponent();
        }


        private void RadGridViewLab3_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

            // uncomment the following code to enable programmatic grouping

            //// remove the "City" grouping added in the designer
            //radGridView1.MasterTemplate.GroupDescriptors.RemoveAt(1);
            //// add a new grouping by "Contact Title"
            //radGridView1.MasterTemplate.GroupDescriptors.Add(new GroupDescriptor("ContactTitle ASC"));
        }
    }
}

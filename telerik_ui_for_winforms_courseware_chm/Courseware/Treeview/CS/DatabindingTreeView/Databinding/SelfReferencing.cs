using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Databinding
{
    public partial class SelfReferencing : RadForm
    {
        public SelfReferencing()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
            radTreeView1.DataSource = this.nwindDataSet.Employees;
            radTreeView1.DisplayMember = "Title";
            radTreeView1.ChildMember = "EmployeeID";
            radTreeView1.ParentMember = "ReportsTo";
        }
    }
}

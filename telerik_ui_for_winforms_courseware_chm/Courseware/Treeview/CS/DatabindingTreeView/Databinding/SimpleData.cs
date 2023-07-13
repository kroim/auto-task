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
    public partial class SimpleData : RadForm
    {
        public SimpleData()
        {
            InitializeComponent();
        }

        private void SimpleData_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
            radTreeView1.DataSource = this.nwindDataSet.Employees;
            radTreeView1.DisplayMember = "LastName";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _05_HierarchyDesigner
{
    public partial class RadGridViewLab5 : Form
    {
        public RadGridViewLab5()
        {
            InitializeComponent();
        }

        private void RadGridViewLab5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet1.EmployeeDepartmentHistory' table. You can move, or remove it, as needed.
            this.employeeDepartmentHistoryTableAdapter.Fill(this.adventureWorksDataSet1.EmployeeDepartmentHistory);
            // TODO: This line of code loads data into the 'adventureWorksDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.adventureWorksDataSet1.Department);

        }
    }
}

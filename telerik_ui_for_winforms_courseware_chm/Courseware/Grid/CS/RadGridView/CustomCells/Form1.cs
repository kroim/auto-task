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
using Telerik.WinControls.Enumerations;

namespace _15_CustomCells
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.adventureWorksDataSet1.Product);

            radGridView1.MasterTemplate.BestFitColumns();
            radGridView1.Columns.Remove("Color");
            ColorSwatchColumn col = new ColorSwatchColumn("Color");
            radGridView1.Columns.Add(col);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.productTableAdapter.Update(this.adventureWorksDataSet1);
        }
    }
}

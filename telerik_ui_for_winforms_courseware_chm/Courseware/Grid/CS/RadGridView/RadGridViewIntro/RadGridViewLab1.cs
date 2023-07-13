using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_RadGridViewIntro
{
    public partial class RadGridViewLab1 : Form
    {
        public RadGridViewLab1()
        {
            InitializeComponent();
        }

        private void RadGridViewLab1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.adventureWorksDataSet.SalesPerson);

        }
    }
}

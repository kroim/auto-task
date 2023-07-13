using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _02_AddingColumns
{
    public partial class RadGridViewLab2 : Form
    {
        public RadGridViewLab2()
        {
            InitializeComponent();
        }

        private void RadGridViewLab2_Load(object sender, EventArgs e)
        {
            // load the dataset
            this.salesPersonTableAdapter.Fill(this.adventureWorksDataSet.SalesPerson);

            // assign the "PercentQuota" expression, and set format to be a percentage
            this.radGridView1.Columns["PercentQuota"].Expression = "SalesYTD/SalesQuota";
            this.radGridView1.Columns["PercentQuota"].FormatString = "{0:P}";

            // create a new "Over 15 Percent" checkbox
            GridViewCheckBoxColumn checkboxColumn = new GridViewCheckBoxColumn();
            checkboxColumn.Name = "CheckBoxColumn";
            checkboxColumn.HeaderText = "Over 15%";
            checkboxColumn.Width = 60;
            radGridView1.Columns.Add(checkboxColumn);
            checkboxColumn.Expression = "PercentQuota > 15";

            // set column formats
            this.radGridView1.Columns["SalesQuota"].FormatString = "{0:C}";
            this.radGridView1.Columns["Bonus"].FormatString = "{0:C}";
            this.radGridView1.Columns["SalesYTD"].FormatString = "{0:C}";
            this.radGridView1.Columns["SalesLastYear"].FormatString = "{0:C}";
            this.radGridView1.Columns["CommissionPct"].FormatString = "{0:P}";

            // get the best fit for each column based on header text and data
            radGridView1.MasterTemplate.BestFitColumns();
        }
    }
}

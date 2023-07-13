using System;
using System.Windows.Forms;

namespace _06_HierarcyAuto
{
    public partial class RadGridViewLab6 : Form
    {
        public RadGridViewLab6()
        {
            InitializeComponent();
        }

        private void RadGridViewLab6_Load(object sender, EventArgs e)
        {
            AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTA =
              new AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            AdventureWorksDataSetTableAdapters.ProductVendorTableAdapter productvendorTA =
              new AdventureWorksDataSetTableAdapters.ProductVendorTableAdapter();
            vendorTA.Fill(adventureWorksDataSet.Vendor);
            productvendorTA.Fill(adventureWorksDataSet.ProductVendor);

            radGridView1.AutoGenerateHierarchy = true;
            radGridView1.DataMember = "Vendor";
            radGridView1.MasterTemplate.BestFitColumns();
            radGridView1.MasterTemplate.Templates[0].BestFitColumns();
        }
    }
}

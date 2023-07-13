using System;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace _04_SortingandFiltering
{
    public partial class RadGridViewLab4 : Form
    {
        public RadGridViewLab4()
        {
            InitializeComponent();
        }

        private void RadGridViewLab4_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.productDataSet1.Product);
            // sort by "Color" in ascending order
            radGridView1.MasterTemplate.SortDescriptors.Add(new SortDescriptor("ReorderPoint", System.ComponentModel.ListSortDirection.Descending));
            radGridView1.MasterTemplate.SortDescriptors.Add(new SortDescriptor("Color", System.ComponentModel.ListSortDirection.Ascending));
             
            //filter for rows where "MakeFlag" is true
            radGridView1.MasterTemplate.FilterDescriptors.Add(new FilterDescriptor("MakeFlag", FilterOperator.IsEqualTo, true));

            // filter for rows where ProductNumber starts with either a "C" or "R" character
            CompositeFilterDescriptor compositeDescriptor = new CompositeFilterDescriptor();
            compositeDescriptor.LogicalOperator = FilterLogicalOperator.Or;
            compositeDescriptor.FilterDescriptors.Add(new FilterDescriptor("ProductNumber", FilterOperator.StartsWith, "C"));
            compositeDescriptor.FilterDescriptors.Add(new FilterDescriptor("ProductNumber", FilterOperator.StartsWith, "R"));
            radGridView1.MasterTemplate.FilterDescriptors.Add(compositeDescriptor);
        }
    }
}
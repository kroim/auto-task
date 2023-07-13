using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HierarchyLoadOnDemand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productModelTableAdapter.Fill(this.adventureWorksDataSet.ProductModel);
            this.productTableAdapter.Fill(this.adventureWorksDataSet.Product);

            this.radGridView1.DataSource = productModelBindingSource;

            GridViewTemplate childTemplate = CreateChildTemplate();
            this.radGridView1.Templates.Add(childTemplate);

            childTemplate.HierarchyDataProvider = new GridViewEventDataProvider(childTemplate);
            this.radGridView1.RowSourceNeeded += new GridViewRowSourceNeededEventHandler(radGridView1_RowSourceNeeded);
        }

        #region handlingRowSourceNeeded
        void radGridView1_RowSourceNeeded(object sender, GridViewRowSourceNeededEventArgs e)
        {
            DataRowView rowView = e.ParentRow.DataBoundItem as DataRowView;
            DataRow[] rows = rowView.Row.GetChildRows("ProductModel_Product");

            foreach (DataRow dataRow in rows)
            {
                GridViewRowInfo row = e.Template.Rows.NewRow();
                row.Cells["Name"].Value = dataRow["Name"];
                row.Cells["ProductNumber"].Value = dataRow["ProductNumber"];
                row.Cells["Color"].Value = dataRow["Color"];
                row.Cells["ListPrice"].Value = dataRow["ListPrice"];
                row.Cells["Size"].Value = dataRow["Size"];
                row.Cells["Weight"].Value = dataRow["Weight"];
                row.Cells["DiscontinuedDate"].Value = dataRow["DiscontinuedDate"];

                e.SourceCollection.Add(row);
            }
        }
        #endregion

        #region childTemplate
        private GridViewTemplate CreateChildTemplate()
        {
            GridViewTemplate template = new GridViewTemplate();
            template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            GridViewTextBoxColumn namecolumn = new GridViewTextBoxColumn("Name");
            GridViewTextBoxColumn productNumberColumn = new GridViewTextBoxColumn("ProductNumber");
            GridViewTextBoxColumn colorColumn = new GridViewTextBoxColumn("Color");
            GridViewDecimalColumn listPriceColumn = new GridViewDecimalColumn("ListPrice");
            GridViewTextBoxColumn sizeColumn = new GridViewTextBoxColumn("Size");
            GridViewDecimalColumn weightColumn = new GridViewDecimalColumn("Weight");
            GridViewDateTimeColumn discontinuedColumn = new GridViewDateTimeColumn("DiscontinuedDate");
            template.Columns.AddRange(namecolumn,
                productNumberColumn,
                colorColumn,
                listPriceColumn,
                sizeColumn,
                weightColumn,
                discontinuedColumn);

            return template;
        }
        #endregion
    }
}

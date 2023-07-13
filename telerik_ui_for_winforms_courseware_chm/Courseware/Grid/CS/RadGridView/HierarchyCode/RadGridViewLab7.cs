using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _07_HierarchyCode
{
    public partial class RadGridViewLab7 : Form
    {
        public RadGridViewLab7()
        {
            InitializeComponent();

        }

        private void RadGridViewLab7_Load(object sender, EventArgs e)
        {
            // Create the dataset and table adapters
            AdventureWorksDataSet adventureWorksDS = new AdventureWorksDataSet();
            AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter salesPersonTA =
              new AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter();
            AdventureWorksDataSetTableAdapters.SalesTerritoryTableAdapter salesTerritoryTA =
              new AdventureWorksDataSetTableAdapters.SalesTerritoryTableAdapter();
            // load the tables with data
            salesTerritoryTA.Fill(adventureWorksDS.SalesTerritory);
            salesPersonTA.Fill(adventureWorksDS.SalesPerson);

            // assign the parent table as the datasource for the grid and configure the master grid view
            radGridView1.DataSource = adventureWorksDS.SalesTerritory;
            radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView1.MasterTemplate.AllowAddNewRow = false;

            // create, configure and assign the child grid view template
            GridViewTemplate childTmpt = new GridViewTemplate();
            childTmpt.DataSource = adventureWorksDS.SalesPerson;
            childTmpt.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            childTmpt.AllowAddNewRow = false;
            radGridView1.MasterTemplate.Templates.Add(childTmpt);

            // create, configure and add the relation between master grid view and child template
            GridViewRelation relation = new GridViewRelation(radGridView1.MasterTemplate);
            relation.ChildTemplate = childTmpt;
            relation.RelationName = "SalesTerritoryPerson";
            relation.ParentColumnNames.Add("TerritoryID");
            relation.ChildColumnNames.Add("TerritoryID");
            radGridView1.Relations.Add(relation);

            // hide guid columns
            radGridView1.Columns["rowguid"].IsVisible = false;
            childTmpt.Columns["rowguid"].IsVisible = false;

        }
    }
}

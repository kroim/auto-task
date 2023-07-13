using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Data.OleDb;
using Telerik.WinControls;

namespace Introduction
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicCollectionDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicCollectionDataSet.Albums);
            radTreeView1.DataSource = this.musicCollectionDataSet.Albums;
            radTreeView1.DisplayMember = "AlbumName";
            radTreeView1.ValueMember = "AlbumID";
            radDropDownList1.DropDownMaxSize = new Size(0, 53);
            DataSourceAssignments();
        }

        private void DataSourceAssignments()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Jute Heather Cardigan"));
            products.Add(new Product(2, "Retro Cardigan"));
            products.Add(new Product(3, "Cashmere Cardigan"));
            radListControl1.DataSource = products;
            radListControl1.DisplayMember = "Description";
            radListControl1.ValueMember = "ID";

            string[] myArray = { "one", "two", "three" };
            radListControl1.DataSource = myArray;

            List<string> list = new List<string>() { "one", "two", "three" };
            radListControl1.DataSource = list;

            // bind to a DataTable or DataTable descendant. You may need to change your MusicConnection string
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.MusicCollectionConnectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter("select AlbumID, AlbumName from Albums", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            radListControl1.DataSource = table;
            radListControl1.DisplayMember = "AlbumName";
            radListControl1.ValueMember = "AlbumID";

            // bind to a DataView. You may need to change your MusicConnection string
            DataView dataView = new DataView(table, "AlbumName LIKE 'B%'", "", DataViewRowState.CurrentRows);
            radListControl1.DataSource = dataView;
            radListControl1.DisplayMember = "AlbumName";
            radListControl1.ValueMember = "AlbumID";

            // create an xml file with the albums 
            table.TableName = "Albums";
            table.WriteXml("c:\\Albums.xml", XmlWriteMode.WriteSchema);

            // read xml into a table and set as datasource
            DataTable table2 = new DataTable();
            table2.ReadXml("c:\\Albums.xml");
            radListControl1.DataSource = table2;
            radListControl1.DisplayMember = "AlbumName";
            radListControl1.ValueMember = "AlbumID";

            radTextBox1.DataBindings.Add("Text", table, "AlbumName");
            radTextBox1.DataBindings.Add("Tag", table, "AlbumID");

            radListControl1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radListControl1_SelectedIndexChanged);
        }

        void radListControl1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = (sender as RadListElement).SelectedItem as RadListDataItem;
            RadMessageBox.SetThemeName("Desert");
            RadMessageBox.Show(String.Format("Text: {0}  Value: {1}", item.Text, item.Value));
        }
    }

    public class Product
    {
        public Product(int id, string description)
        {
            ID = id;
            Description = description;
        }

        public int ID
        { get; set; }

        public string Description
        { get; set; }
    }
   
}

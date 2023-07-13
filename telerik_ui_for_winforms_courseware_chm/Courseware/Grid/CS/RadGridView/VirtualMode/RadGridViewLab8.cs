using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _08_VirtualMode
{
    public partial class RadGridViewLab8 : Form
    {
        private List<List<string>> ContactTable = new List<List<string>>();
        private int NumberOfRows = 20;
        private int NumberOfCols = 4;

        public RadGridViewLab8()
        {
            InitializeComponent();
        }

        private void RefreshContactData()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            // iterate the number of to retrieve, 
            // randomly index into the Contact table,
            // and assign data to the current row
            for (int i = 0; i < NumberOfRows; i++)
            {
                int index = random.Next(1000);
                AdventureWorksDataSet.ContactRow cr =
                  adventureWorksDataSet.Contact[index];
                ContactTable[i][0] = cr.FirstName;
                ContactTable[i][1] = cr.LastName;
                ContactTable[i][2] = cr.EmailAddress;
                ContactTable[i][3] = cr.Phone;
            }
        }

        private void RadGridViewLab8_Load(object sender, EventArgs e)
        {
            this.contactTableAdapter.Fill(this.adventureWorksDataSet.Contact);

            // set grid properties
            radGridView1.MasterTemplate.AllowAddNewRow = false;
            radGridView1.MasterTemplate.AllowCellContextMenu = false;
            radGridView1.MasterTemplate.AllowDeleteRow = false;
            radGridView1.MasterTemplate.AllowEditRow = false;
            radGridView1.EnableSorting = false;
            radGridView1.EnableFiltering = false;
            radGridView1.EnableGrouping = false;

            // initialize ContactTable
            for (int i = 0; i < NumberOfRows; i++)
            {
                List<string> list = new List<string> { string.Empty, string.Empty, string.Empty, string.Empty };
                ContactTable.Add(list);
            }

            // configure the grid to use virtual mode, set the number of columns and rows, set
            // the column heading text 
            radGridView1.VirtualMode = true;
            radGridView1.ColumnCount = NumberOfCols;
            radGridView1.Columns[0].HeaderText = "First Name";
            radGridView1.Columns[1].HeaderText = "Last Name";
            radGridView1.Columns[2].HeaderText = "Email";
            radGridView1.Columns[3].HeaderText = "Phone Number";
            radGridView1.RowCount = NumberOfRows;

            // auto size the columns
            radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            // trigger the timer
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // reload the contact table
            RefreshContactData();

            // signal that the grid should be updated
            radGridView1.TableElement.Update(Telerik.WinControls.UI.GridUINotifyAction.DataChanged);
        }

        private void radGridView1_CellValueNeeded_1(object sender, Telerik.WinControls.UI.GridViewCellValueEventArgs e)
        {
            // supply the cell value from the ContactTable using the row and column index passed in
            // the GridViewCellValueEventArgs parameter
            e.Value = ContactTable[e.RowIndex][e.ColumnIndex];
        }
    }
}

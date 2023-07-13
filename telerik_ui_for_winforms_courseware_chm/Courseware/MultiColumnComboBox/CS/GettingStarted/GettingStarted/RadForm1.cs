using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.furnitureDataSet.Products);

            // get a reference to the combo box element
            RadMultiColumnComboBoxElement combo = radMultiColumnComboBox1.MultiColumnComboBoxElement;

            // hide the ID column
            combo.Columns["ID"].IsVisible = false;

            // size all the columns except "Photo"
            foreach (GridViewDataColumn column in combo.Columns)
            {
                if (!column.Name.Equals("Photo"))
                    column.BestFit();
            }
            //set the image layout in the "Photo" column
            ((GridViewImageColumn)combo.EditorControl.Columns["Photo"]).ImageLayout = ImageLayout.Stretch;

            // set initial drop down width and height
            combo.DropDownWidth = 265;
            combo.DropDownHeight = 315;
        }
    }
}

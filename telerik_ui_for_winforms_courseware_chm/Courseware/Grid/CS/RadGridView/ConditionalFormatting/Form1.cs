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

namespace _13_ConditionalFormatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.CreditCard' table. You can move, or remove it, as needed.
            this.creditCardTableAdapter.Fill(this.adventureWorksDataSet.CreditCard);

            radGridView1.MasterTemplate.BestFitColumns();

            // create a rule to highlight "SuperiorCard" card types
            // -highlight the entire row
            ConditionalFormattingObject cfo = 
                new ConditionalFormattingObject("SuperiorCards", ConditionTypes.Equal, "SuperiorCard", "", true);
            cfo.RowBackColor = Color.LightGreen;
            cfo.RowForeColor = Color.DarkGreen;
            cfo.TextAlignment = ContentAlignment.MiddleRight;
            radGridView1.Columns["CardType"].ConditionalFormattingObjectList.Add(cfo);

            // highlight cards with expiry year less than 2008.
            // -highlight only the cell
            ConditionalFormattingObject cfo2 =
              new ConditionalFormattingObject("Expired Cards", ConditionTypes.Less, "2008", "", false);
            cfo2.CellBackColor = Color.Transparent;
            cfo2.CellForeColor = Color.Red;
            cfo2.TextAlignment = ContentAlignment.MiddleRight;
            radGridView1.Columns["ExpYear"].ConditionalFormattingObjectList.Add(cfo2);
        }

        // show the conditional formatting dialog
        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ConditionalFormattingForm cf =
              new ConditionalFormattingForm(radGridView1.MasterTemplate, null);
            cf.Show();
        }

        // replace a grid context menu item
        private void radGridView1_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            for (int i = 0; i < e.ContextMenu.Items.Count; i++)
            {
                RadMenuItemBase item = (RadMenuItemBase)e.ContextMenu.Items[i];
                if (item.Text == "Conditional Formatting")
                {
                    e.ContextMenu.Items.Remove(item);
                    RadMenuItem newItem = new RadMenuItem("My Conditional Formatting");
                    newItem.Click += new EventHandler(newItem_Click);
                    e.ContextMenu.Items.Insert(4, newItem);
                    break;
                }
            }
        }

        // handle the click for the custom grid menu item
        void newItem_Click(object sender, EventArgs e)
        {
            ConditionalFormattingForm cf =
              new ConditionalFormattingForm(radGridView1.MasterTemplate, null);
            cf.TopMost = true;
            cf.Show();
            cf.Focus();
        }
    }
}

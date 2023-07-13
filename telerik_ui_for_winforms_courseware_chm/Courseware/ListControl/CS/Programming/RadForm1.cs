using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Programming
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            FontFamily[] families = new InstalledFontCollection().Families;
            foreach (FontFamily family in families)
            {
                RadListDataItem itemToAdd = new RadListDataItem(family.Name);
                radListControl1.Items.Add(itemToAdd);
            }

            radListControl1.Items.Insert(0, new RadListDataItem("put me at the top of the list"));

            radListControl1.Items.AddRange(new RadListDataItem[]
                                           {
                                               new RadListDataItem("One"),
                                               new RadListDataItem("Two"),
                                               new RadListDataItem("Three")
                                           });

            RadListDataItem item = new RadListDataItem("Telerik");
            item.Image = Image.FromFile(@"C:\Program Files (x86)\Telerik\RadControls for WinForms Q1 2011\Examples\QuickStart\Resources\telerikLOGO.png");
            item.TextImageRelation = TextImageRelation.ImageAboveText;
            item.TextAlignment = ContentAlignment.BottomCenter;
            radListControl1.Items.Add(item);
            
            RadListDataItem item1 = new RadListDataItem("RadControls for WinForms");
            item1.TextAlignment = ContentAlignment.MiddleLeft;
            radListControl1.Items.Add(item1);
            
            RadListDataItem item2 = new RadListDataItem("Q1 2011");
            item2.TextAlignment = ContentAlignment.MiddleRight;
            radListControl1.Items.Add(item2);
            
            radListControl1.AutoSizeItems = true;

            radListControl1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnLocate_Click(object sender, EventArgs e)
        {
            int index = radListControl1.FindString("Courier New");
            RadListDataItem item = radListControl1.Items[index];
            if (item != null)
            {
                radListControl1.ListElement.ScrollToItem(item);
                radListControl1.SelectedItem = item;
            }
        }

        private void Sort_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (sender == rbNone)
                radListControl1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
            else if (sender == rbAscending)
                radListControl1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            else if (sender == rbDescending)
                radListControl1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Descending;
        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (RadListDataItem item in radListControl1.SelectedItems)
            {
                builder.Append(item.Text);
                builder.Append(Environment.NewLine);
            }
            RadMessageBox.SetThemeName(this.ThemeName);
            RadMessageBox.Show(builder.ToString(), "Your Selections");
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (radListControl1.Items[e.Position].Text)
            {
                case "None":
                    radListControl1.SelectionMode = SelectionMode.None;
                    break;
                case "One":
                    radListControl1.SelectionMode = SelectionMode.One;
                    break;
                case "MultiSimple":
                    radListControl1.SelectionMode = SelectionMode.MultiSimple;
                    break;
                case "MultiExtended":
                    radListControl1.SelectionMode = SelectionMode.MultiExtended;
                    break;
            }
        }
    }
}
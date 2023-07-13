using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace Programming
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            radPropertyGrid1.SelectedObject = new PropertyGridElement();

            radPropertyGrid1.ToolbarVisible = true;

            RadButtonElement clearFiltering = new RadButtonElement();
            clearFiltering.Text = "Clear";
            clearFiltering.MinSize = new System.Drawing.Size(25, 22);
            clearFiltering.StretchHorizontally = false;
            radPropertyGrid1.PropertyGridElement.ToolbarElement.Children.Add(clearFiltering);
            clearFiltering.Click += new EventHandler(clearFiltering_Click);

            radPropertyGrid1.BeginEditMode = RadPropertyGridBeginEditModes.BeginEditOnClick;

            radPropertyGrid1.SelectedGridItem = radPropertyGrid1.Items["Alignment"];
            radPropertyGrid1.PropertyGridElement.PropertyTableElement.ScrollToItem(radPropertyGrid1.Items["Alignment"]);

            radPropertyGrid1.ItemFormatting += new PropertyGridItemFormattingEventHandler(radPropertyGrid1_ItemFormatting);
            radPropertyGrid1.PropertyValidating += new PropertyValidatingEventHandler(radPropertyGrid1_PropertyValidating);
        }

        void radPropertyGrid1_PropertyValidating(object sender, PropertyValidatingEventArgs e)
        {
            PropertyGridItem item = e.Item as PropertyGridItem;

            if (item.PropertyType == typeof(string))
            {
                if (string.IsNullOrEmpty(e.NewValue.ToString()))
                {
                    item.ErrorMessage = "String value must not be an empty string!";
                    e.Cancel = true;
                }
            }
        }

        void clearFiltering_Click(object sender, EventArgs e)
        {
            radPropertyGrid1.PropertyGridElement.ToolbarElement.SearchTextBoxElement.Text = "";
        }

        void radPropertyGrid1_ItemFormatting(object sender, PropertyGridItemFormattingEventArgs e)
        {
            //set the back color of all child items to yellow
            if (e.Item.Level > 0)
            {
                e.VisualElement.BackColor = Color.Yellow;
            }
            else
            {
                e.VisualElement.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
            }

            //set the backcolor of items with value True to LightGreen and with value equal to False to Red
            PropertyGridItem item = e.Item as PropertyGridItem;
            if (item != null && item.Value != null)
            {
                if (item.Value.ToString() == "True")
                {
                    e.VisualElement.BackColor = Color.LightGreen;
                }
                else if (item.Value.ToString() == "False")
                {
                    e.VisualElement.BackColor = Color.Red;
                }
            }
            else
            {
                e.VisualElement.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            radPropertyGrid1.EnableSorting = true;
            SortDescriptor sort = new SortDescriptor("FormattedValue", ListSortDirection.Ascending);
            radPropertyGrid1.SortDescriptors.Add(sort);
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            radPropertyGrid1.EnableGrouping = true;
            GroupDescriptor group = new GroupDescriptor(new SortDescriptor[] { new SortDescriptor("Category", ListSortDirection.Ascending) });
            radPropertyGrid1.GroupDescriptors.Add(group);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterDescriptor filter = new FilterDescriptor("Name", FilterOperator.Contains, "size");
            radPropertyGrid1.FilterDescriptors.Add(filter);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            radPropertyGrid1.SortDescriptors.Clear();
            radPropertyGrid1.FilterDescriptors.Clear();
            radPropertyGrid1.GroupDescriptors.Clear();
        }
    }
}

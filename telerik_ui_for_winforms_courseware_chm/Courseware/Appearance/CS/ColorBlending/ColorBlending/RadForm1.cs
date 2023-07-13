using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;

namespace ColorBlending
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furnitureDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.furnitureDataSet.Products);

            radGridView1.Columns["Photo"].ImageLayout = ImageLayout.Stretch;
            radGridView1.Columns["ProductName"].BestFit();
            radGridView1.Columns["Manufacturer"].BestFit();
            radGridView1.TableElement.UpdateView();

            ThemeResolutionService.ApplicationThemeName = "Desert";

            radDock1.MainDocumentContainerVisible = false;

            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = Color.FromKnownColor(knownColor).Name;
                item.Value = Color.FromKnownColor(knownColor);
                commandBarDropDownList1.Items.Add(item);
            }

            radCommandBar1.Rows[0].Strips[0].StretchHorizontally = true;
            commandBarDropDownList1.DropDownListElement.MaxSize = commandBarDropDownList1.Size;
            commandBarDropDownList1.DropDownListElement.Alignment = ContentAlignment.MiddleCenter;
            commandBarDropDownList1.StretchHorizontally = true;
            commandBarDropDownList1.Text = "Choose a Color";
            commandBarDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(commandBarDropDownList1_SelectedIndexChanged);
        }

        void commandBarDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = (sender as RadDropDownListElement).SelectedItem as RadListDataItem;
            Color color = (Color)item.Value;

            Theme currentTheme = ThemeResolutionService.GetTheme(ThemeResolutionService.ApplicationThemeName);
            currentTheme.AddColorBlend("BaseColor", HslColor.FromColor(Color.Orange));
            currentTheme.ThemeProperties["BaseColor"] = HslColor.FromColor(color);

            currentTheme.AddColorBlend("CommandBarColor", HslColor.FromColor(Color.FromArgb(149, 201, 204)));
            currentTheme.ThemeProperties["CommandBarColor"] = HslColor.FromColor(color);
        }
    }
}

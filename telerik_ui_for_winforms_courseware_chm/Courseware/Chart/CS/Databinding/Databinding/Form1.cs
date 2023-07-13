using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Databinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furnitureDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.furnitureDataSet1.Products);
            radChart2.Series[0].Appearance.ShowLabelConnectors = true;
            radChart2.SeriesOrientation = Telerik.Charting.ChartSeriesOrientation.Vertical;
            radChart2.IntelligentLabelsEnabled = true;
            radChart2.Series[0].DataXColumn = "ExtendedPrice";
            radChart2.Series[0].DataYColumn = "TotalQuantity";
            radChart2.PlotArea.YAxis.AxisLabel.TextBlock.Text = "Quantity";
            radChart2.PlotArea.YAxis.AxisLabel.Visible = true;
            radChart2.PlotArea.XAxis.AxisLabel.TextBlock.Text = "Extended Price";
            radChart2.PlotArea.XAxis.AxisLabel.Visible = true;
        }

        private void radChart1_ItemDataBound(object sender, Telerik.Charting.ChartItemDataBoundEventArgs e)
        {
            int qty = Convert.ToInt32((e.DataItem as DataRowView)["TotalQuantity"]);
            string quantityLabel = String.Empty;
            switch (qty)
            {
                case 1:
                case 2:
                    quantityLabel = "Few";
                    break;
                case 3:
                    quantityLabel = "Some";
                    break;
                case 4:
                case 5:
                    quantityLabel = "Lots!";
                    break;
            }

            double price = Convert.ToDouble((e.DataItem as DataRowView)["ExtendedPrice"]);
            string priceLabel = String.Empty;
            if (price < 2000)
            {
                priceLabel = "cheap";
            }
            else if (price < 10000)
            {
                priceLabel = "reasonable";
            }
            else
            {
                priceLabel = "expensive";
            }

            e.SeriesItem.Label.TextBlock.Appearance.TextProperties.Font =
              new System.Drawing.Font("Ariel", 12, System.Drawing.FontStyle.Bold);
            e.SeriesItem.Label.TextBlock.Text = quantityLabel + ", " + priceLabel;
        }
    }
}

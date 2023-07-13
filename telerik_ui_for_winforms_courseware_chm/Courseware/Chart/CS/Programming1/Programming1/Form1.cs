using System;
using System.Windows.Forms;

using Telerik.Charting;

namespace Programming1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radChart1.AutoLayout = true;

            // Create the series and assign the ChartSeriesType
            radChart1.Series.Clear();
            ChartSeries chartSeries =
              new ChartSeries("Average Temperatures", ChartSeriesType.Bar);

            // Define the items in the series
            chartSeries.AddItem(5);
            chartSeries.AddItem(1);
            chartSeries.AddItem(-1);
            chartSeries.AddItem(-5);
            chartSeries.AddItem(-7);

            // add an empty item
            bool isEmpty = true;
            ChartSeriesItem item = new ChartSeriesItem(isEmpty);
            chartSeries.AddItem(item);

            chartSeries.AddItem(-3);

            // Add the series to the chart, chart to page.
            radChart1.Series.Add(chartSeries);
        }
    }
}

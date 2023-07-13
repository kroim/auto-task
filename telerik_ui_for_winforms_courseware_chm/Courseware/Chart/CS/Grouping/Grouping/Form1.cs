using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Charting;

namespace Grouping
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the generic list of Sales
            List<Sales> sales = new List<Sales>();
            sales.Add(new Sales(2011, 1, 5));
            sales.Add(new Sales(2011, 2, 2));
            sales.Add(new Sales(2011, 3, 3));
            sales.Add(new Sales(2011, 4, 1));
            sales.Add(new Sales(2012, 1, 4));
            sales.Add(new Sales(2012, 2, 3));
            sales.Add(new Sales(2012, 3, 8));
            sales.Add(new Sales(2012, 4, 2));

            // Setup the chart appearance and title
            radChart1.Skin = "DeepBlue";
            radChart1.ChartTitle.TextBlock.Text =
              "Sales Grouped by Quarter";

            // Remove the default series
            radChart1.Series.Clear();
            // Create and add a new Bar series type
            ChartSeries chartSeries =
              new ChartSeries("Sales", ChartSeriesType.Bar);
            radChart1.Series.Add(chartSeries);

            // Set the grouping properties
            radChart1.DataGroupColumn = "Year";
            radChart1.Legend.Appearance.GroupNameFormat = "#NAME: #VALUE";

            // bind the chart last to include the preceding property
            // settings.
            radChart1.DataSource = sales;
            //radChart1.DataBind();
        }

        public class Sales
        {
            public Sales(int year, int quarter, double value)
            {
                Year = year;
                Quarter = quarter;
                Value = value;
            }
            public int Year { get; set; }
            public int Quarter { get; set; }
            public double Value { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.Charting;
using Telerik.Charting.Styles;
using Telerik.WinControls.UI;

namespace DateTimeOnNumericAxis
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // Make a little room for the labels by removing the legend, 
            // setting AutoLayout true to automatically use the extra space.
            // Also make both axis labels visible and rotate the YAxis label 45 degrees
            radChart1.AutoLayout = true;
            radChart1.Legend.Visible = false;
            radChart1.PlotArea.YAxis.AxisLabel.Visible = true;
            radChart1.PlotArea.YAxis.Appearance.LabelAppearance.RotationAngle = 45;
            radChart1.PlotArea.XAxis.AxisLabel.Visible = true;

            DateTime today = DateTime.Today;

            // Setup chart orientation 
            radChart1.SeriesOrientation = ChartSeriesOrientation.Horizontal;

            // Setup XAxis 
            radChart1.PlotArea.XAxis.AutoScale = false;
            radChart1.PlotArea.XAxis.Appearance.ValueFormat = ChartValueFormat.ShortDate;
            radChart1.PlotArea.XAxis.AddRange(today.ToOADate(), today.AddDays(10).ToOADate(), 1);

            // Setup YAxis 
            radChart1.PlotArea.YAxis.AutoScale = false;
            radChart1.PlotArea.YAxis.Appearance.ValueFormat = ChartValueFormat.ShortTime;
            radChart1.PlotArea.YAxis.AddRange(today.AddHours(7).ToOADate(), today.AddHours(18).ToOADate(), 1d / 24d);

            // Setup Series 
            radChart1.Series[0].Type = ChartSeriesType.Gantt;
            radChart1.Series[0].DataXColumn = "X";
            radChart1.Series[0].DataXColumn2 = "X2";
            radChart1.Series[0].DataYColumn = "Y";
            radChart1.Series[0].DataYColumn2 = "Y2";

            // Data Bind 
            radChart1.Series[0].Appearance.LabelAppearance.Visible = false;
            radChart1.DataSource = GetDataTable();
            radChart1.DataBind();
        }

        // generate a four column table with sample
        // date and time data stored as doubles
        private DataTable GetDataTable()
        {
            double[,] input = new double[3, 2] { 
        { 8, 12 }, { 9, 14}, { 13, 18.5} 
      };

            DataTable table = new DataTable();
            table.Columns.Add("X", typeof(double));
            table.Columns.Add("X2", typeof(double));
            table.Columns.Add("Y", typeof(double));
            table.Columns.Add("Y2", typeof(double));

            DateTime start = DateTime.Today;

            for (int i = 0; i < 3; i++)
            {
                DataRow row = table.NewRow();

                // convert all dates and times to OLE Automation dates
                // which are stored as doubles
                row["X"] = start.AddDays(i).ToOADate();
                row["X2"] = start.AddDays(i + 1).ToOADate();
                row["Y"] = start.AddHours(input[i, 0]).ToOADate();
                row["Y2"] = start.AddHours(input[i, 1]).ToOADate();

                table.Rows.Add(row);
            }

            return table;
        }
    }
}

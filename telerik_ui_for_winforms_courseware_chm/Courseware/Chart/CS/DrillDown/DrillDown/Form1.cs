using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Telerik.Charting;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace DrillDown
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //stores the currently selected year        
        private int _year;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.revenueTableAdapter.FillByYear(this.chartDataSet.Revenue);

            // remove the second, unused series
            radChart1.Series.RemoveAt(1);

            radChart1.ChartTitle.TextBlock.Text = "Years";

            radChart1.PlotArea.XAxis.IsZeroBased = false;
            radChart1.PlotArea.XAxis.AutoScale = false;
            radChart1.PlotArea.XAxis.MinValue = 2003;
            radChart1.PlotArea.XAxis.MaxValue = 2005;
            //attach the datasource to the chart            
            radChart1.DataManager.DataSource = this.chartDataSet.Revenue;
            radChart1.Series[0].DataYColumn = "Revenue";
            radChart1.Series[0].DataXColumn = "Year";
            radChart1.Series[0].Name = "Years";
        }

        private void radChart1_Click(object sender, Telerik.Charting.ChartClickEventArgs args)
        {
            if (args.Element.ActiveRegion.Parent is ChartSeriesItem &&
              (args.Element.ActiveRegion.Parent as ChartSeriesItem).Parent.Name == "Years")
            {
                radChart1.ChartTitle.TextBlock.Text = "Quarters";
                //a bar representing the revenue for a year was clicked                
                _year = (args.Element as ChartSeriesItem).Index + 2003;
                //fill revenue values for the year whose bar was clicked                
                revenueTableAdapter.FillByQuarter(this.chartDataSet.Revenue, _year);
                //setup chart properties with appopriate axis labels                
                radChart1.PlotArea.XAxis.DataLabelsColumn = "Quarter";
                radChart1.Series[0].Clear();
                radChart1.Series[0].DataYColumn = "Revenue";
                radChart1.Series[0].Name = "Quarters";
                radChart1.DataBind();
            }
            else if (args.Element is ChartSeriesItem &&
               (args.Element as ChartSeriesItem).Parent.Name == "Quarters")
            {
                radChart1.ChartTitle.TextBlock.Text = "Months";
                //a bar representing the revenue for a year was clicked                
                int quarter = (args.Element as ChartSeriesItem).Index + 1;
                //fill revenue values for the year whose bar was clicked                
                revenueTableAdapter.FillByMonth(this.chartDataSet.Revenue, _year, quarter);
                //setup chart properties with appopriate axis labels                
                radChart1.PlotArea.XAxis.DataLabelsColumn = "Month";
                radChart1.Series[0].Clear();
                radChart1.Series[0].DataYColumn = "Revenue";
                radChart1.Series[0].Name = "Months";
                radChart1.DataBind();
                //Detach Click event handler for the innermost chart 
                //Telerik.WinControls.UI.RadChart.ChartClickEventHandler       
                radChart1.Click -= new RadChart.ChartClickEventHandler(radChart1_Click);
            }
        }
    }
}

using System;
using System.Diagnostics;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using System.Collections.Generic;


namespace Databinding
{
    public partial class LoadOnDemand : RadForm
    {
        public LoadOnDemand()
        {
            InitializeComponent();
        }

        void radTreeView1_NodesNeeded(object sender, NodesNeededEventArgs e)
        {
            // measure how long this takes
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int count = 0;

                // get the data for all child nodes
                string[] weatherStations =
                  Properties.Resources.WeatherStations.Split(
                  new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string station in weatherStations)
                {
                    e.Nodes.Add(new RadTreeNode(station));
                    count++;
                }
            
            // show performance results
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            lblStatus.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00} loading {4} nodes",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10, count);
        }
    }
}

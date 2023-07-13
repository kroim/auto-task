using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace ThreadingWalkthrough
{
    enum StatusTypes { Info, Error, Find };

    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        #region private members

        private List<DatabaseInfo> _dbInfoList;
        private RadLabelElement _waitingBarHostLabel;

        #endregion

        #region helper methods

        // retrieve an image for a given status
        private Image GetStatusImage(StatusTypes statusType)
        {
            switch (statusType)
            {
                case StatusTypes.Error:
                    return Properties.Resources.Error;

                case StatusTypes.Info:
                    return Properties.Resources.Information;

                case StatusTypes.Find:
                    return Properties.Resources.FindServersAnimated;

                default:
                    return Properties.Resources.Information;
            }
        }

        // display a text and image status message
        private void DisplayStatus(string message, StatusTypes statusType)
        {
            lblStatus.Text = message;
            lblStatus.Image = GetStatusImage(statusType);
        }

        // create a RadLabel\HostedItem\RadWaitingBar and insert into
        // the status strip.
        private RadLabelElement GetHostedWaitingBar(string name)
        {
            // make height and width the same so ellipse will be a circle
            Size size = new Size(btnServers.Size.Height, btnServers.Size.Height);
            // use hosted waiting bar control instead of element for access to 
            // start/stop waiting methods.
            RadWaitingBar waitingBar = new RadWaitingBar();
            // waiting bar animation sweeps top to bottom
            waitingBar.Orientation = Orientation.Vertical;
            waitingBar.WaitingBarElement.BackColor = Color.SteelBlue;
            waitingBar.WaitingBarElement.Shape = new EllipseShape();
            RadLabelElement waitingBarHostLabel = new RadLabelElement();
            // status label to the left will respect DefaultSize and 
            // leave room for waiting bar
            waitingBarHostLabel.DefaultSize = size;
            waitingBarHostLabel.Name = name;
            RadHostItem host = new RadHostItem(waitingBar);
            waitingBarHostLabel.Children.Insert(0, host);
            // set transparent after being inserted to host children
            waitingBar.BackColor = Color.Transparent;

            return waitingBarHostLabel;
        }

        // Loads a list control with generic List of DatabaseInfo; 
        // Name to the Text and number of objects to the description
        private void LoadDatabaseList(RadListControl listControl, int maxObjects)
        {
            listControl.Items.Clear();
            foreach (DatabaseInfo info in _dbInfoList)
            {
                // limit databases to those with number of objects within trackbar limits
                if (info.ObjectCount <= maxObjects)
                {
                    RadListDataItem item = new RadListDataItem(info.DatabaseName, info);
                    listControl.Items.Add(item);
                }
            }
        }

        // reset progress bar value and add to status strip
        private void ShowProgressBar()
        {
            pbStatus.Value1 = 0;
            ssMain.Items.Add(pbStatus);
        }

        // remove progress bar from status strip
        private void HideProgressBar()
        {
            ssMain.Items.Remove(pbStatus);
        }

        // add waiting bar element to status strip,
        // get host item, drill down to waitiing bar and StartWaiting()
        private void ShowWaitingBar()
        {
            ssMain.Items.Add(_waitingBarHostLabel);
            RadHostItem hostItem =
              _waitingBarHostLabel.Children[0] as RadHostItem;
            (hostItem.HostedControl as RadWaitingBar).StartWaiting();
        }

        // get host item, drill down to waitiing bar, StopWaiting() and 
        // remove element from status strip.   
        private void HideWaitingBar()
        {
            RadHostItem hostItem = _waitingBarHostLabel.Children[0] as RadHostItem;
            (hostItem.HostedControl as RadWaitingBar).StopWaiting();
            ssMain.Items.Remove(_waitingBarHostLabel);
        }

        // disable controls during processing
        private void SetUIEnabled(bool enabled)
        {
            btnServers.Enabled = enabled;
            lbServers.Enabled = enabled;
            lbDatabases.Enabled = enabled;
            // only enable when there are objects to filter
            if (!enabled)
                tbMaxObjects.Enabled = false;
        }

        #endregion

        #region server background worker

        // create and configure the BackgroundWorker object 
        private void RunServerWorker()
        {
            BackgroundWorker serverWorker = new BackgroundWorker();
            serverWorker.DoWork += new DoWorkEventHandler(serverWorker_DoWork);
            serverWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(serverWorker_RunWorkerCompleted);
            serverWorker.RunWorkerAsync();
        }

        // retrieve MS SQL servers, pass back DataTable result
        void serverWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = SmoApplication.EnumAvailableSqlServers();
        }

        // update the UI using the Result property of the args, or
        // the Error property if the operation fails.
        void serverWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                DisplayStatus(e.Error.Message, StatusTypes.Error);
            }
            else
            {
                // populate list control from data table of servers passed in as Result
                DataTable dt = e.Result as DataTable;
                foreach (DataRow row in dt.Rows)
                {
                    lbServers.Items.Add(new RadListDataItem(row["Name"].ToString()));
                }
                DisplayStatus("Found " + dt.Rows.Count.ToString() + " servers",
                  StatusTypes.Info);
            }
            HideWaitingBar();
            SetUIEnabled(true);
        }

        #endregion

        #region database background worker

        // create and configure BackgroundWorker. Populate and pass argument.
        // enable progress reporting
        private void RunDbWorker(string serverName, int maxObjects)
        {
            BackgroundWorker dbWorker = new BackgroundWorker();
            dbWorker.WorkerReportsProgress = true;
            dbWorker.DoWork += new DoWorkEventHandler(dbWorker_DoWork);
            dbWorker.ProgressChanged += new ProgressChangedEventHandler(dbWorker_ProgressChanged);
            dbWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(dbWorker_RunWorkerCompleted);
            dbWorker.RunWorkerAsync(serverName);
        }

        // retrieve the list of databases for the server: 
        // -get the number of objects for each database,
        // -keep track of the min and max number of objects.
        // -calculate progress,
        // -create and populate a DatabaseInfo object and pass to 
        // ProgressChanged event handler.
        // Create and populate a DBWorkerResult object and assign to the arguments
        // Result property.
        void dbWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Server server = new Server(e.Argument.ToString());
            int count = 0;
            int maxObjectCount = 0;
            int minObjectCount = 0;
            foreach (Database database in server.Databases)
            {
                count++;
                // ignore empty databases
                if (database.IsAccessible)
                {
                    // get all objects in the database
                    DataTable dtObjects = database.EnumObjects();
                    // calculate progress 
                    int progress = (int)(((double)count / (double)server.Databases.Count) * 100);
                    // assign the first non-zero value
                    if ((minObjectCount == 0) && (dtObjects.Rows.Count > 0))
                        minObjectCount = dtObjects.Rows.Count;
                    // get min and max number of objects for all databases in server
                    maxObjectCount = Math.Max(maxObjectCount, dtObjects.Rows.Count);
                    minObjectCount = Math.Min(maxObjectCount, dtObjects.Rows.Count);
                    // Call ReportProgress to trigger ProgressChanged event.
                    // DatabaseInfo passed as the UserState property
                    DatabaseInfo databaseInfo = new DatabaseInfo(server.Name, database.Name, dtObjects.Rows.Count);
                    (sender as BackgroundWorker).ReportProgress(progress, databaseInfo);
                }
            }
            e.Result = new DBWorkerResult(server.Name, maxObjectCount, minObjectCount);
        }

        // respond to ReportProgress() method calls, set progress bar value, 
        // extract the DatabaseInfo object from the argument's UserState property:
        // add to the generic list of DatabaseInfo objects for use on completion,
        // and display a status message with the current database name.
        void dbWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value1 = e.ProgressPercentage;
            DatabaseInfo info = e.UserState as DatabaseInfo;
            _dbInfoList.Add(info);
            DisplayStatus(info.DatabaseName, StatusTypes.Info);
        }

        // update the UI using the Result property of the args, or
        // the Error property if the operation fails.
        void dbWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // reset the "Databases" label to default value
                lblDatabases.Text = "Databases";
                // display the exception
                DisplayStatus(e.Error.Message, StatusTypes.Error);
            }
            else
            {
                DBWorkerResult workerResult = e.Result as DBWorkerResult;
                tbMaxObjects.Maximum = workerResult.MaxItems;
                // if there are no items, then minimum is zero, otherwise, 
                // set to the fewest number of items (will always display at least one)
                tbMaxObjects.Minimum = workerResult.MinItems == 0 ? 0 : workerResult.MinItems - 1;
                int range = workerResult.MaxItems - workerResult.MinItems;
                tbMaxObjects.TickFrequency = range / 10;
                tbMaxObjects.Value = tbMaxObjects.Maximum;
                // only enable when there are items
                tbMaxObjects.Enabled = workerResult.MaxItems > 0;
                lblCount.Text = tbMaxObjects.Value.ToString();
                LoadDatabaseList(lbDatabases, tbMaxObjects.Value);

                lblDatabases.Text = "Databases for " + workerResult.ServerName;
                string message = "Found " + lbDatabases.Items.Count + " databases for " + workerResult.ServerName;
                DisplayStatus(message, StatusTypes.Info);
            }

            HideProgressBar();
            SetUIEnabled(true);
        }

        #endregion

        #region events

        private void btnServers_Click(object sender, System.EventArgs e)
        {
            SetUIEnabled(false);
            lbServers.Items.Clear();
            lbDatabases.Items.Clear();
            lblDatabases.Text = "Databases";
            ShowWaitingBar();
            DisplayStatus("Searching for MS SQL Servers", StatusTypes.Find);
            RunServerWorker();
        }

        private void lbServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadListElement listControl = sender as RadListElement;
            if (listControl.SelectedItem != null)
            {
                SetUIEnabled(false);
                lbDatabases.Items.Clear();
                _dbInfoList = new List<DatabaseInfo>();
                string serverName = (listControl.SelectedItem as RadListDataItem).Text;
                ShowProgressBar();
                DisplayStatus("Finding databases for " + serverName, StatusTypes.Find);
                RunDbWorker(serverName, tbMaxObjects.Value);
            }
        }

        private void tbMaxObjects_ValueChanged(object sender, System.EventArgs e)
        {
            RadTrackBar trackBar = sender as RadTrackBar;
            LoadDatabaseList(lbDatabases, trackBar.Value);
            lblCount.Text = trackBar.Value.ToString();
        }

        private void RadForm1_Load(object sender, System.EventArgs e)
        {
            tbMaxObjects.Enabled = false;
            // panel should have same shape as the two list controls
            (pnlMaxObjects.RootElement.Children[0].Children[1] as BorderPrimitive).Shape = new
              RoundRectShape();

            _waitingBarHostLabel = GetHostedWaitingBar("WaitingBarHostLabel");

            HideProgressBar();
        }

        private void lbDatabases_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if ((sender as RadListElement).SelectedValue != null)
            {
                DatabaseInfo info = (sender as RadListElement).SelectedValue as DatabaseInfo;
                string message = String.Format("{0}\\{1}{2}{3} objects",
                  info.ServerName, info.DatabaseName, Environment.NewLine, info.ObjectCount);
                DisplayStatus(message, StatusTypes.Info);
            }
        }

        #endregion
    }
}

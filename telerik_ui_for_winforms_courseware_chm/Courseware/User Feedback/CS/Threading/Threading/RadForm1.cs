
using Telerik.WinControls.UI;
using System.ComponentModel;
using System.Threading;
using Telerik.WinControls;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void btnServers_Click(object sender, System.EventArgs e)
        {
            lblStatus.Text = "Finding...";
            BackgroundWorker worker = new BackgroundWorker();
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < tbMaxObjects.Value; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i, i);
                Thread.Sleep(5);
            }
            e.Result = tbMaxObjects.Value; 
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RadListDataItem item = new RadListDataItem("Server" + e.UserState.ToString());
            lcServers.Items.Add(item);
            pbStatus.Value1 = e.ProgressPercentage;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           lblStatus.Text = "Completed processing " + e.Result.ToString() + " items";
        }

        private void tbMaxObjects_ValueChanged(object sender, System.EventArgs e)
        {
            lblCount.Text = tbMaxObjects.Value.ToString();
        }

        private void RadForm1_Load(object sender, System.EventArgs e)
        {
            tbMaxObjects.Value = tbMaxObjects.Maximum;
            lblCount.Text = tbMaxObjects.Value.ToString();
        }
    }
}

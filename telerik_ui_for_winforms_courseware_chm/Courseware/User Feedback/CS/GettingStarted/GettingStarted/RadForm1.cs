
using Telerik.WinControls.UI;
using System.ComponentModel;
using Telerik.WinControls;

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
            lcServers.Items.Clear();
            pbStatus.Maximum = tbMaxObjects.Value;

            for (int i = 0; i < tbMaxObjects.Value; i++)
            {
                RadListDataItem item = new RadListDataItem("Server" + i.ToString());
                lcServers.Items.Add(item);
                pbStatus.Value1 = i;
                ssMain.Refresh();
            }
            lblStatus.Text = "Loaded " + tbMaxObjects.Value.ToString() + " servers";
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

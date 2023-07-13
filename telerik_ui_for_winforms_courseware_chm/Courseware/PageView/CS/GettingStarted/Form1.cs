using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            lblDriveName.Text = radPageView1.SelectedPage.Text;

            radPageViewPage1.Image = ilDriveTypes.Images["Hard_Drive.png"];
            radPageViewPage2.Image = ilDriveTypes.Images["CD_ROM.png"];
            radPageViewPage3.Image = ilDriveTypes.Images["Network.png"];
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // Get a list of directories for the C:\ drive.
            // Iterate the list and add RadListBoxItems to the list.
            // Finally, select the first tab so that the file list will 
            // be visible.
            string[] directories = Directory.GetDirectories("C:\\");
            foreach (string directory in directories)
            {
                lbFiles.Items.Add(new RadListDataItem(directory));
            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            lblDriveName.Text = radPageView1.SelectedPage.Text;
        }
    }
}

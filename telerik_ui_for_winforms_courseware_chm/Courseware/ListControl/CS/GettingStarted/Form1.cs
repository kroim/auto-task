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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the dropdown list with drive names and select the first one
            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                if (driveInfo.IsReady)
                {
                    DirectoryInfo info = new DirectoryInfo(driveInfo.RootDirectory.FullName);
                    AddDirectoryToDropDownList(info, ddlDrives);
                }
            }
            ddlDrives.SelectedIndex = 0;
        }

        private void AddDirectoryToDropDownList(DirectoryInfo info, RadDropDownList dropDownList)
        {
            // display the path and save the "info" as the Value property
            RadListDataItem item = new RadListDataItem(info.FullName, info);
            dropDownList.Items.Add(item);
        }

        private void ddlDrives_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            // get the dropdown list that triggered this event,
            // get the currently selected item in the dropdown lsit and
            // extract the DirectoryInfo
            RadDropDownListElement dropDownListElement = sender as RadDropDownListElement;
            RadListDataItem item = dropDownListElement.SelectedItem;
            DirectoryInfo directoryInfo = item.Value as DirectoryInfo;
            lcFiles.Items.Clear();

            // get a list of all directories and files
            foreach (FileSystemInfo info in directoryInfo.GetFileSystemInfos())
            {
                lcFiles.Items.Add(new RadListDataItem(info.Name, info));
            }
            lcFiles.SelectedIndex = 0;
        }

        private void lcFiles_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if ((sender as RadListElement).SelectedItem != null)
            {
                RadListDataItem item = (sender as RadListElement).SelectedItem;
                FileSystemInfo info = item.Value as FileSystemInfo;
                lblStatus.Text = info.Name;
            }

        }
    }
}

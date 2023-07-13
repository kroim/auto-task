using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;


namespace Walkthrough
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsRootDirectory(DirectoryInfo info)
        {
            return info.Root.FullName.Equals(info.FullName);
        }

        private bool IsDirectory(FileSystemInfo info)
        {
            return (info.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }

        private bool IsHidden(FileSystemInfo info)
        {
            return (info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
        }

        private DirectoryInfo GetParentDirectory(FileSystemInfo info)
        {
            return new DirectoryInfo(Path.GetDirectoryName(info.FullName));
        }

        // reference to element for image in dropdown list text area
        private ImagePrimitive _imagePrimitive;
        // stores a reference to item under last mouse down
        private RadListDataItem _currentItem;

        // display a status message and accompanying image 16px thumbnail
        private void ShowStatus(string message, Image image)
        {
            lblStatus.Text = message;
            lblStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            if (image != null)
            {
                lblStatus.Image = image.GetThumbnailImage(16, 16, null, new IntPtr());
            }
        }

        // display exception message in status label with error icon 16px thumbnail
        private void ShowStatus(Exception ex)
        {
            ShowStatus(ex.Message, imageList1.Images["symbol error.ico"]);
        }

        // show file/directory description as status message and 16px icon
        private void ShowStatus(RadListDataItem selectedItem)
        {
            if (selectedItem != null)
            {
                RadListDataItem item = selectedItem as RadListDataItem;
                FileSystemInfo info = item.Value as FileSystemInfo;
                string message = GetFileSystemDescription(info, DescriptionDetail.Partial);
                ShowStatus(message, item.Image);
            }
        }

        // scope of description
        private enum DescriptionDetail { Partial, Full };

        // build a string with number of objects/bytes in directory/file.
        // if DescriptionDetail is "Full", add "Created"/"Updated" statistics
        private string GetFileSystemDescription(FileSystemInfo info, DescriptionDetail detail)
        {
            StringBuilder builder = new StringBuilder();

            if (info is DirectoryInfo)
            {
                DirectoryInfo dirInfo = info as DirectoryInfo;
                long size = dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length;
                builder.Append(size.ToString());
                builder.Append(" objects");
                builder.Append(System.Environment.NewLine);
            }
            else
            {
                FileInfo fileInfo = info as FileInfo;
                builder.Append(fileInfo.Length.ToString());
                builder.Append(" bytes");
                builder.Append(System.Environment.NewLine);
            }

            if (detail == DescriptionDetail.Full)
            {
                builder.Append("Created on: ");
                builder.Append(info.CreationTime.ToString());
                builder.Append(System.Environment.NewLine);
                builder.Append("Updated on: ");
                builder.Append(info.LastWriteTime.ToString());
            }
            return builder.ToString();

        }

        // Add path and DirectoryInfo object to RadDropDownList   
        private void AddDirectoryToDropDownList(DirectoryInfo info, RadDropDownList dropDownList)
        {
            if (dropDownList.FindStringExact(info.FullName) == -1)
            {
                RadListDataItem item = new RadListDataItem(info.FullName, info);
                item.Text = info.FullName;
                item.TextImageRelation = TextImageRelation.ImageBeforeText;
                // use Shell32 api to get appication bitmap
                item.Image = Shell32.GetFileBitmap(info.FullName);
                dropDownList.Items.Add(item);

            }
            dropDownList.SelectedItem = dropDownList.Items[dropDownList.FindStringExact(info.FullName)];
        }

        // load a RadListControl with the files in a directory
        private void LoadFilesListControl(DirectoryInfo directoryInfo, RadListControl listControl)
        {
            listControl.Items.Clear();

            foreach (FileSystemInfo info in directoryInfo.GetFileSystemInfos())
            {
                if (!IsHidden(info))
                {
                    // add Text and Value in constructor
                    RadListDataItem item = new RadListDataItem(info.Name, info);
                    item.TextImageRelation = TextImageRelation.ImageBeforeText;
                    // use the Shell32 API to get bitmap for file
                    item.Image = Shell32.GetFileBitmap(info.FullName);

                    listControl.Items.Add(item);

                    try
                    {
                        GetFileSystemDescription((FileSystemInfo)item.Value, DescriptionDetail.Full);
                    }
                    // if directory cannot be accessed, disable item and include error message
                    catch (UnauthorizedAccessException ex)
                    {
                        item.Enabled = false;
                    }
                  
                }
            }
            if (listControl.Items.Count > 0)
            {
                listControl.SelectedIndex = 0;
            }
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

            // get references to the textbox element and the textbox item within the element
            RadTextBoxElement textBoxElement = ddlDrives.DropDownListElement.TextBox;
            RadTextBoxItem textBoxItem = textBoxElement.TextBoxItem;
            // Add extra padding on the left for the new image
            textBoxItem.Margin = new Padding(20, 1, 1, 1);
            // pad the element so textboxitem doesn't overwrite the
            // border on the right side
            textBoxElement.Padding = new Padding(2, 2, 20, 2);
            // save a reference
            _imagePrimitive = new ImagePrimitive();

            lcFiles.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(lcFiles_ToolTipTextNeeded);
            ddlDrives.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(ddlDrives_SelectedIndexChanged);
            //insert the ImagePrimitive to the text box element
            textBoxElement.Children.Insert(0, _imagePrimitive);
            //hide the FillPrimitive so the image to be displayed
            textBoxElement.Fill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            //select the first item in the dropdown
            ddlDrives.SelectedIndex = 0;
            //make the items size according to their content
            ddlDrives.AutoSizeItems = true;
            lcFiles.AutoSizeItems = true;
            ddlDrives.DropDownListElement.Popup.MinimumSize = new Size(0, 110);
        }

        void lcFiles_ToolTipTextNeeded(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e)
        {
            RadListVisualItem visualItem = sender as RadListVisualItem;
            if (visualItem != null)
            {
                try
                {
                    e.ToolTipText = GetFileSystemDescription((FileSystemInfo)visualItem.Data.Value, DescriptionDetail.Full);
                }
                // if directory cannot be accessed, display error message
                catch (UnauthorizedAccessException ex)
                {
                    e.ToolTipText = ex.Message;
                }
            }
        }

        void ddlDrives_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DirectoryInfo directoryInfo = ddlDrives.SelectedValue as DirectoryInfo;
                btnBack.Enabled = !IsRootDirectory(directoryInfo);
                LoadFilesListControl(directoryInfo, lcFiles);
                Image selectedImage = (ddlDrives.SelectedItem as RadListDataItem).Image;
                _imagePrimitive.Image = selectedImage.GetThumbnailImage(16, 16, null, new IntPtr());
            }
            catch (UnauthorizedAccessException ex)
            {
                ShowStatus(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void lcFiles_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (lcFiles.SelectedItem != null && lcFiles.SelectedItem.Enabled)
            {
                ShowStatus(lcFiles.SelectedItem);
            }
        }

        private void lcFiles_MouseDown(object sender, MouseEventArgs e)
        {
            RadListVisualItem item = lcFiles.ElementTree.GetElementAtPoint(e.Location) as RadListVisualItem;
            if (item != null)
            {
                _currentItem = item.Data;
            }
        }

        private void lcFiles_MouseUp(object sender, MouseEventArgs e)
        {
            _currentItem = null;
        }

        private void lcFiles_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_currentItem != null && _currentItem.Enabled)
            {
                FileSystemInfo info = _currentItem.Value as FileSystemInfo;
                if (info is DirectoryInfo)
                    AddDirectoryToDropDownList(info as DirectoryInfo, ddlDrives);
                else
                    System.Diagnostics.Process.Start(info.FullName);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DirectoryInfo directoryInfo = ddlDrives.SelectedValue as DirectoryInfo;
            AddDirectoryToDropDownList(GetParentDirectory(directoryInfo), ddlDrives);
            Cursor.Current = Cursors.Default;
        }
    }
}

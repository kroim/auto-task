using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;

namespace GettingStarted
{
    public partial class RadForm1 :RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            LoadPageView();
        }

        #region helper methods

        // Create and configure a single RadPageViewPage and populate the
        // tag with the DriveInfo passed
        private RadPageViewPage GetDrivePageItem(DriveInfo driveInfo)
        {
            RadPageViewPage page = new RadPageViewPage();
            page.TextImageRelation = TextImageRelation.ImageBeforeText;
            page.TextAlignment = ContentAlignment.TopCenter;
            page.ImageAlignment = ContentAlignment.TopLeft;
            page.Tag = driveInfo;
            return page;
        }

        // Create, configure and populate a RadListControl with files from the
        // drive root.
        private RadListControl GetListControl(string drive)
        {
            RadListControl listControl = new RadListControl();
            listControl.Dock = DockStyle.Fill;
            listControl.ThemeName = "Desert";

            string[] directories = Directory.GetDirectories(drive.ToString());
            foreach (string directory in directories)
            {
                listControl.Items.Add(new RadListDataItem(directory));
            }

            return listControl;
        }

        // Get the percent of used space on a drive
        private int GetUsedPercent(DriveInfo driveInfo)
        {
            return (int)((
                (double)driveInfo.TotalSize -
                (double)driveInfo.AvailableFreeSpace) / (double)driveInfo.TotalSize * 100);
        }

        #endregion helper methods

        #region private methods

        private void LoadPageView()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                DriveInfo driveInfo = new DriveInfo(drive);

                radPageView1.ItemCreating += new EventHandler<RadPageViewItemCreatingEventArgs>(radPageView1_ItemCreating);

                RadPageViewPage page = GetDrivePageItem(driveInfo);
                radPageView1.Pages.Add(page);

                RadProgressBarElement progressBar = ((RadPageViewProgressBarItem)page.Item).ProgressBar;

                if (driveInfo.IsReady)
                {
                    page.Text = driveInfo.Name + Environment.NewLine + driveInfo.VolumeLabel;
                    page.Image = ilDriveTypes.Images[(int)driveInfo.DriveType];

                    progressBar.Value1 = GetUsedPercent(driveInfo);
                    page.Controls.Add(GetListControl(drive));
                }
                else
                {
                    page.Text = drive + Environment.NewLine + " is not ready";
                    page.Image = ilDriveTypes.Images["DisconnectedDrive.png"];

                    progressBar.Visibility = ElementVisibility.Hidden;
                }
            }
        }

        #endregion private methods

        #region event handlers
        //Replace the default page item with the custom one that contains RadProgressBarElement
        void radPageView1_ItemCreating(object sender, RadPageViewItemCreatingEventArgs e)
        {
            e.Item = new RadPageViewProgressBarItem();
        }

        void radPageView1_SelectedPageChanging(object sender, RadPageViewCancelEventArgs e)
        {
            //Fill the labels with data
            if (e.Page.Tag != null)
            {
                DriveInfo driveInfo = (DriveInfo)e.Page.Tag;
                if (driveInfo.IsReady)
                {
                    lblDriveName.Text = driveInfo.Name;
                    lblVolumeLabel.Text = driveInfo.VolumeLabel.Equals(String.Empty) ? "No Volume Label" : driveInfo.VolumeLabel;
                    lblDriveFormat.Text = driveInfo.DriveFormat;
                    lblDriveType.Text = driveInfo.DriveType.ToString();
                    lblTotalSpace.Text = driveInfo.TotalSize.ToString("n0");
                }
            }

            //Show message box for the drives that are not ready
            if (e.Page == null)
                return;
            if (!(e.Page.Tag as DriveInfo).IsReady)
            {
                RadPageViewItem tabItem = e.Page.Item as RadPageViewItem;
                RadMessageBox.SetThemeName(this.ThemeName);
                String message = String.Format("{0}", tabItem.Text);
                RadMessageBox.Show(message, "Drive Unavailable", MessageBoxButtons.OK, RadMessageIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RadPageViewPage selectedPage = null;

            foreach (RadPageViewPage page in radPageView1.Pages)
            {
                // no drive info, skip
                if (page.Tag == null)
                    continue;

                // save first available tab with drive info
                if (selectedPage == null)
                    selectedPage = page;

                // drive isn't ready, skip
                if (!(page.Tag as DriveInfo).IsReady)
                    continue;

                // save tab with greatest free space
                selectedPage =
                  (selectedPage.Tag as DriveInfo).TotalFreeSpace >
                    (page.Tag as DriveInfo).TotalFreeSpace ?
                    selectedPage : page;
            }
            // select tab with greatest free space
            radPageView1.SelectedPage = selectedPage;
        }

        // Iterate the tabs DriveInfo and collapse any that aren't ready
        private void btnShow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RadPageViewPage selectedPage = radPageView1.SelectedPage;
            foreach (RadPageViewPage page in radPageView1.Pages)
            {
                if (!(page.Tag as DriveInfo).IsReady)
                {
                    page.Item.Visibility = args.ToggleState == ToggleState.On
                      ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                }
            }
        }
      
        #endregion event handlers
   }
    
    //Create custom page item
    class RadPageViewProgressBarItem : RadPageViewStripItem
    {
        RadProgressBarElement progressBar;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            // Create and configure a RadProgressBarElement.
            // Hook up a click event to pass through clicks made
            // to the progress to the page item underneath
            progressBar = new RadProgressBarElement();
            progressBar.Margin = new Padding(5, 40, 5, 5);
            progressBar.Padding = new Padding(5);
            progressBar.MinSize = new Size(80, 20);
            progressBar.MaxSize = new Size(80, 20);
            progressBar.TextElement.NotifyParentOnMouseInput = true;
            progressBar.TextElement.Click += new EventHandler(TextElement_Click);
            progressBar.ShowProgressIndicators = true;
            this.Children.Add(progressBar);
        }

        //expose the progressbar in order to access it directly from the page item
        public RadProgressBarElement ProgressBar 
        { 
            get
            {
                return this.progressBar;
            }
        }

        //select the corresponding page when the progress bar is clicked
        void TextElement_Click(object sender, EventArgs e)
        {
            ((RadPageView)this.Owner.ElementTree.Control).SelectedPage = this.Page;
        }

        //arrange the item children
        protected override void ArrangeChildren(SizeF available)
        {
            progressBar.Arrange(new RectangleF(PointF.Empty, available));
            base.ArrangeChildren(available);
        }

        //make the item themeable 
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadPageViewStripItem);
            }
        }
    }
}

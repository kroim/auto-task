using Programming.MusicCollectionDataSetTableAdapters;
namespace GettingStarted
{
    partial class GettingStarted
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarDropDownSort = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarLabel2 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarDropDownGroup = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarToggleButtonList = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleButtonTiles = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleButtonDetails = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarTextBoxFilter = new Telerik.WinControls.UI.CommandBarTextBox();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.songsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new MusicCollectionDataSet();
            this.songsDataTableTableAdapter = new MusicCollectionDataSetTableAdapters.SongsDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 20);
            this.radListView1.ItemSize = new System.Drawing.Size(200, 20);
            this.radListView1.Location = new System.Drawing.Point(0, 85);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(742, 338);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1,
            this.commandBarRowElement2});
            this.radCommandBar1.Size = new System.Drawing.Size(742, 85);
            this.radCommandBar1.TabIndex = 1;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel1,
            this.commandBarDropDownSort,
            this.commandBarSeparator1,
            this.commandBarLabel2,
            this.commandBarDropDownGroup,
            this.commandBarSeparator2,
            this.commandBarToggleButtonList,
            this.commandBarToggleButtonTiles,
            this.commandBarToggleButtonDetails,
            this.commandBarSeparator3,
            this.commandBarTextBoxFilter});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // commandBarLabel1
            // 
            this.commandBarLabel1.AccessibleDescription = "Sort By:";
            this.commandBarLabel1.AccessibleName = "Sort By:";
            this.commandBarLabel1.DisplayName = "commandBarLabel1";
            this.commandBarLabel1.Name = "commandBarLabel1";
            this.commandBarLabel1.Text = "Sort By:";
            this.commandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarLabel1.VisibleInOverflowMenu = true;
            // 
            // commandBarDropDownSort
            // 
            this.commandBarDropDownSort.DisplayName = "commandBarDropDownList1";
            this.commandBarDropDownSort.DropDownAnimationEnabled = true;
            this.commandBarDropDownSort.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "None";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Song Name";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Artist";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Album";
            radListDataItem4.TextWrap = true;
            this.commandBarDropDownSort.Items.Add(radListDataItem1);
            this.commandBarDropDownSort.Items.Add(radListDataItem2);
            this.commandBarDropDownSort.Items.Add(radListDataItem3);
            this.commandBarDropDownSort.Items.Add(radListDataItem4);
            this.commandBarDropDownSort.Name = "commandBarDropDownSort";
            this.commandBarDropDownSort.Text = "";
            this.commandBarDropDownSort.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarDropDownSort.VisibleInOverflowMenu = true;
            this.commandBarDropDownSort.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.commandBarDropDownSort_SelectedIndexChanged);
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarLabel2
            // 
            this.commandBarLabel2.AccessibleDescription = "Group By:";
            this.commandBarLabel2.AccessibleName = "Group By:";
            this.commandBarLabel2.DisplayName = "commandBarLabel2";
            this.commandBarLabel2.Name = "commandBarLabel2";
            this.commandBarLabel2.Text = "Group By:";
            this.commandBarLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarLabel2.VisibleInOverflowMenu = true;
            // 
            // commandBarDropDownGroup
            // 
            this.commandBarDropDownGroup.DisplayName = "commandBarDropDownList2";
            this.commandBarDropDownGroup.DropDownAnimationEnabled = true;
            this.commandBarDropDownGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem5.Text = "None";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "Album";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "Artist";
            radListDataItem7.TextWrap = true;
            this.commandBarDropDownGroup.Items.Add(radListDataItem5);
            this.commandBarDropDownGroup.Items.Add(radListDataItem6);
            this.commandBarDropDownGroup.Items.Add(radListDataItem7);
            this.commandBarDropDownGroup.Name = "commandBarDropDownGroup";
            this.commandBarDropDownGroup.Text = "";
            this.commandBarDropDownGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarDropDownGroup.VisibleInOverflowMenu = true;
            this.commandBarDropDownGroup.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.commandBarDropDownGroup_SelectedIndexChanged);
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2";
            this.commandBarSeparator2.AccessibleName = "commandBarSeparator2";
            this.commandBarSeparator2.DisplayName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // commandBarToggleButtonList
            // 
            this.commandBarToggleButtonList.AccessibleDescription = "commandBarToggleButtonList";
            this.commandBarToggleButtonList.AccessibleName = "commandBarToggleButton1";
            this.commandBarToggleButtonList.DisplayName = "commandBarToggleButton1";
            this.commandBarToggleButtonList.Image = global::GettingStarted.Properties.Resources.list_icon;
            this.commandBarToggleButtonList.Name = "commandBarToggleButtonList";
            this.commandBarToggleButtonList.Text = "commandBarToggleButton1";
            this.commandBarToggleButtonList.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleButtonList.VisibleInOverflowMenu = true;
            this.commandBarToggleButtonList.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // commandBarToggleButtonTiles
            // 
            this.commandBarToggleButtonTiles.AccessibleDescription = "commandBarToggleButton2";
            this.commandBarToggleButtonTiles.AccessibleName = "commandBarToggleButton2";
            this.commandBarToggleButtonTiles.DisplayName = "commandBarToggleButton2";
            this.commandBarToggleButtonTiles.Image = global::GettingStarted.Properties.Resources.tiles_icon;
            this.commandBarToggleButtonTiles.Name = "commandBarToggleButtonTiles";
            this.commandBarToggleButtonTiles.Text = "commandBarToggleButton2";
            this.commandBarToggleButtonTiles.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleButtonTiles.VisibleInOverflowMenu = true;
            this.commandBarToggleButtonTiles.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // commandBarToggleButtonDetails
            // 
            this.commandBarToggleButtonDetails.AccessibleDescription = "commandBarToggleButton3";
            this.commandBarToggleButtonDetails.AccessibleName = "commandBarToggleButton3";
            this.commandBarToggleButtonDetails.DisplayName = "commandBarToggleButton3";
            this.commandBarToggleButtonDetails.Image = global::GettingStarted.Properties.Resources.details_icon;
            this.commandBarToggleButtonDetails.Name = "commandBarToggleButtonDetails";
            this.commandBarToggleButtonDetails.Text = "commandBarToggleButton3";
            this.commandBarToggleButtonDetails.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleButtonDetails.VisibleInOverflowMenu = true;
            this.commandBarToggleButtonDetails.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3";
            this.commandBarSeparator3.AccessibleName = "commandBarSeparator3";
            this.commandBarSeparator3.DisplayName = "commandBarSeparator3";
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // commandBarTextBoxFilter
            // 
            this.commandBarTextBoxFilter.DisplayName = "commandBarTextBox1";
            this.commandBarTextBoxFilter.Name = "commandBarTextBoxFilter";
            this.commandBarTextBoxFilter.Text = "";
            this.commandBarTextBoxFilter.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarTextBoxFilter.VisibleInOverflowMenu = true;
            this.commandBarTextBoxFilter.TextChanged += new System.EventHandler(this.commandBarTextBoxFilter_TextChanged);
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.DisplayName = null;
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // songsDataTableBindingSource
            // 
            this.songsDataTableBindingSource.DataMember = "SongsDataTable";
            this.songsDataTableBindingSource.DataSource = this.musicCollectionDataSet;
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songsDataTableTableAdapter
            // 
            this.songsDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // GettingStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.radListView1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "GettingStarted";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownSort;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel2;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownGroup;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.CommandBarTextBox commandBarTextBoxFilter;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButtonList;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButtonTiles;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButtonDetails;
        private Programming.MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource songsDataTableBindingSource;
        private SongsDataTableTableAdapter songsDataTableTableAdapter;
      
    }
}


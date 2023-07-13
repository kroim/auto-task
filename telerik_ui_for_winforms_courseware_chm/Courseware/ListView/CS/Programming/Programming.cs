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
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;

namespace Programming
{
    public partial class Programming : RadForm
    {
        public Programming()
        {
            InitializeComponent();

            this.radListView1.ItemDataBound += new Telerik.WinControls.UI.ListViewItemEventHandler(radListView1_ItemDataBound);
            this.radListView1.VisualItemFormatting += new Telerik.WinControls.UI.ListViewVisualItemEventHandler(radListView1_VisualItemFormatting);
            this.radListView1.CellFormatting += new Telerik.WinControls.UI.ListViewCellFormattingEventHandler(radListView1_CellFormatting);
            this.radListView1.ColumnCreating += new ListViewColumnCreatingEventHandler(radListView1_ColumnCreating);
            this.radListView1.ViewTypeChanged += new EventHandler(radListView1_ViewTypeChanged);

            this.radListView1.AllowEdit = false;
            this.radListView1.AllowRemove = false;
            this.radListView1.DataSource = this.songsDataTableBindingSource;
            this.radListView1.DisplayMember = "SongName";
            this.radListView1.ValueMember = "SongID";

            this.radListView1.ViewType = ListViewType.IconsView;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicCollectionDataSet.SongsDataTable' table. You can move, or remove it, as needed.
            this.songsDataTableTableAdapter.Fill(this.musicCollectionDataSet.SongsDataTable);
        }

        private void SetupDetailsView()
        {
            this.radListView1.AllowArbitraryItemHeight = true;
        }

        private void SetupIconsView()
        {
            this.radListView1.ItemSize = new Size(200, 64);
            this.radListView1.ItemSpacing = 5;
            this.radListView1.AllowArbitraryItemHeight = true;
        }

        private void SetupSimpleListView()
        {
            this.radListView1.AllowArbitraryItemHeight = true;
        }

        void radListView1_ViewTypeChanged(object sender, EventArgs e)
        {
            switch (radListView1.ViewType)
            {
                case ListViewType.ListView:
                    SetupSimpleListView();
                    break;
                case ListViewType.IconsView:
                    SetupIconsView();
                    break;
                case ListViewType.DetailsView:
                    SetupDetailsView();
                    break;
            }
        }

        void radListView1_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "SongID" || e.Column.FieldName == "Image")
            {
                e.Column.Visible = false;
            }

            if (e.Column.FieldName == "SongName")
            {
                e.Column.HeaderText = "Song Title";
            }

            if (e.Column.FieldName == "ArtistName")
            {
                e.Column.HeaderText = "Artist";
            }

            if (e.Column.FieldName == "AlbumName")
            {
                e.Column.HeaderText = "Album";
            }
        }

        void radListView1_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            if (e.CellElement.Image != null)
            {
                e.CellElement.Image = e.CellElement.Image.GetThumbnailImage(32, 32, null, IntPtr.Zero);
            }
        }

        void radListView1_VisualItemFormatting(object sender, Telerik.WinControls.UI.ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem.Data.Image != null)
            {
                e.VisualItem.Image = e.VisualItem.Data.Image.GetThumbnailImage(32, 32, null, IntPtr.Zero);
                e.VisualItem.Layout.RightPart.Margin = new Padding(2, 0, 0, 0);
            }

            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.IconsView && e.VisualItem.Data.DataBoundItem != null)
            {
                string albumName = ((MusicCollectionDataSet.SongsDataTableRow)(((System.Data.DataRowView)(e.VisualItem.Data.DataBoundItem)).Row)).AlbumName;
                string artisName = ((MusicCollectionDataSet.SongsDataTableRow)(((System.Data.DataRowView)(e.VisualItem.Data.DataBoundItem)).Row)).ArtistName;
                string songName = ((MusicCollectionDataSet.SongsDataTableRow)(((System.Data.DataRowView)(e.VisualItem.Data.DataBoundItem)).Row)).SongName;
                e.VisualItem.Text = "<html> " + songName + "<br><span style=\"color:#999999\"> " + artisName + "<br> " + albumName + "</span>";
            }
        }

        void radListView1_ItemDataBound(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            DataRowView row = e.Item.DataBoundItem as DataRowView;
            MusicCollectionDataSet.SongsDataTableRow songRow = row.Row as MusicCollectionDataSet.SongsDataTableRow;
            e.Item.Image = Image.FromStream(new MemoryStream(songRow.Image), false, false);
        }

        private bool updatingToggleState = false;

        private void ViewToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (updatingToggleState)
            {
                return;
            }

            this.updatingToggleState = true;

            if (this.commandBarToggleButtonDetails != sender)
            {
                this.commandBarToggleButtonDetails.ToggleState = ToggleState.Off;
            }

            if (this.commandBarToggleButtonList != sender)
            {
                this.commandBarToggleButtonList.ToggleState = ToggleState.Off;
            }

            if (this.commandBarToggleButtonTiles != sender)
            {
                this.commandBarToggleButtonTiles.ToggleState = ToggleState.Off;
            }

            this.updatingToggleState = false;

            if (this.commandBarToggleButtonDetails.ToggleState == ToggleState.On)
            {
                this.radListView1.ViewType = ListViewType.DetailsView;
            }

            if (this.commandBarToggleButtonList.ToggleState == ToggleState.On)
            {
                this.radListView1.ViewType = ListViewType.ListView;
            }

            if (this.commandBarToggleButtonTiles.ToggleState == ToggleState.On)
            {
                this.radListView1.ViewType = ListViewType.IconsView;
            }
         }

        private void ViewToggleButton_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            if (!updatingToggleState && args.OldValue == ToggleState.On)
            {
                args.Cancel = true;
            }
        }

        private void commandBarDropDownSort_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radListView1.SortDescriptors.Clear();
            switch (this.commandBarDropDownSort.Text)
            {
                case "Song Name":
                    this.radListView1.SortDescriptors.Add(new SortDescriptor("SongName", ListSortDirection.Ascending));
                    this.radListView1.EnableSorting = true;
                    break;
                case "Album":
                    this.radListView1.SortDescriptors.Add(new SortDescriptor("AlbumName", ListSortDirection.Ascending));
                    this.radListView1.EnableSorting = true;
                    break;
                case "Artist":
                    this.radListView1.SortDescriptors.Add(new SortDescriptor("ArtistName", ListSortDirection.Ascending));
                    this.radListView1.EnableSorting = true;
                    break;
            }
        }

        private void commandBarDropDownGroup_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radListView1.GroupDescriptors.Clear();
            switch (this.commandBarDropDownGroup.Text)
            {
                case "None":
                    this.radListView1.EnableGrouping = false;
                    this.radListView1.ShowGroups = false;
                    break;
                case "Album":
                    this.radListView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("AlbumName", ListSortDirection.Ascending) }));
                    this.radListView1.EnableGrouping = true;
                    this.radListView1.ShowGroups = true;
                    break;
                case "Artist":
                    this.radListView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("ArtistName", ListSortDirection.Ascending) }));
                    this.radListView1.EnableGrouping = true;
                    this.radListView1.ShowGroups = true;
                    break;
            }
        }

        private void commandBarTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            this.radListView1.FilterDescriptors.Clear();

            if (String.IsNullOrEmpty(this.commandBarTextBoxFilter.Text))
            {
                this.radListView1.EnableFiltering = false;
            }
            else
            {
                this.radListView1.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or;
                this.radListView1.FilterDescriptors.Add("SongName", FilterOperator.Contains, this.commandBarTextBoxFilter.Text);
                this.radListView1.FilterDescriptors.Add("AlbumName", FilterOperator.Contains, this.commandBarTextBoxFilter.Text);
                this.radListView1.FilterDescriptors.Add("ArtistName", FilterOperator.Contains, this.commandBarTextBoxFilter.Text);
                this.radListView1.EnableFiltering = true;
            }
        }
    }
}

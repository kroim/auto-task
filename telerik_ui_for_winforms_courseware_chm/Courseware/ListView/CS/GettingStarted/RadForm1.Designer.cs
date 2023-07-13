namespace GettingStarted
{
    partial class RadForm1
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Description");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem5 = new Telerik.WinControls.UI.ListViewDataItem("New", new string[] {
            "New",
            "Create new file"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem6 = new Telerik.WinControls.UI.ListViewDataItem("Open", new string[] {
            "Open",
            "Open a file"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem7 = new Telerik.WinControls.UI.ListViewDataItem("Save", new string[] {
            "Save",
            "Save file"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem8 = new Telerik.WinControls.UI.ListViewDataItem("Help", new string[] {
            "Help",
            "Show help"});
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.listViewButton = new Telerik.WinControls.UI.RadButton();
            this.detailsViewButton = new Telerik.WinControls.UI.RadButton();
            this.iconsViewButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsViewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconsViewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            this.radListView1.AllowArbitraryItemHeight = true;
            listViewDetailColumn3.HeaderText = "Name";
            listViewDetailColumn4.HeaderText = "Description";
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 20);
            listViewDataItem5.Image = global::GettingStarted.Properties.Resources.New;
            listViewDataItem5.Text = "New";
            listViewDataItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem6.Image = global::GettingStarted.Properties.Resources.Open;
            listViewDataItem6.Text = "Open";
            listViewDataItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem7.Image = global::GettingStarted.Properties.Resources.Save;
            listViewDataItem7.Text = "Save";
            listViewDataItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem8.Image = global::GettingStarted.Properties.Resources.Help;
            listViewDataItem8.Text = "Help";
            listViewDataItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem5,
            listViewDataItem6,
            listViewDataItem7,
            listViewDataItem8});
            this.radListView1.ItemSize = new System.Drawing.Size(200, 20);
            this.radListView1.Location = new System.Drawing.Point(19, 12);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(476, 283);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            // 
            // listViewButton
            // 
            this.listViewButton.Location = new System.Drawing.Point(34, 312);
            this.listViewButton.Name = "listViewButton";
            this.listViewButton.Size = new System.Drawing.Size(130, 24);
            this.listViewButton.TabIndex = 1;
            this.listViewButton.Text = "ListView";
            this.listViewButton.Click += new System.EventHandler(this.listViewButton_Click);
            // 
            // detailsViewButton
            // 
            this.detailsViewButton.Location = new System.Drawing.Point(188, 312);
            this.detailsViewButton.Name = "detailsViewButton";
            this.detailsViewButton.Size = new System.Drawing.Size(130, 24);
            this.detailsViewButton.TabIndex = 2;
            this.detailsViewButton.Text = "DetailsView";
            this.detailsViewButton.Click += new System.EventHandler(this.detailsViewButton_Click);
            // 
            // iconsViewButton
            // 
            this.iconsViewButton.Location = new System.Drawing.Point(344, 312);
            this.iconsViewButton.Name = "iconsViewButton";
            this.iconsViewButton.Size = new System.Drawing.Size(130, 24);
            this.iconsViewButton.TabIndex = 2;
            this.iconsViewButton.Text = "IconsView";
            this.iconsViewButton.Click += new System.EventHandler(this.iconsViewButton_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 348);
            this.Controls.Add(this.iconsViewButton);
            this.Controls.Add(this.detailsViewButton);
            this.Controls.Add(this.listViewButton);
            this.Controls.Add(this.radListView1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsViewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconsViewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadButton listViewButton;
        private Telerik.WinControls.UI.RadButton detailsViewButton;
        private Telerik.WinControls.UI.RadButton iconsViewButton;
    }
}
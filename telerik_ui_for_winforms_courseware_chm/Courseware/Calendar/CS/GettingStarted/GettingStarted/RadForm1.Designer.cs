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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.btnGetFlights = new Telerik.WinControls.UI.RadButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowColumnHeaderSelectors = true;
            this.radCalendar1.AllowMultipleSelect = true;
            this.radCalendar1.AllowRowHeaderSelectors = true;
            this.radCalendar1.AllowViewSelector = true;
            this.radCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.CellToolTipFormat = "dddd, MMMM dd, yyyy blah";
            this.radCalendar1.FastNavigationNextImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.FastNavigationNextImage")));
            this.radCalendar1.FastNavigationPrevImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.FastNavigationPrevImage")));
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(9, 9);
            this.radCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.NavigationNextImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.NavigationNextImage")));
            this.radCalendar1.NavigationPrevImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.NavigationPrevImage")));
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            this.radCalendar1.ShowRowHeaders = true;
            this.radCalendar1.ShowViewSelector = true;
            this.radCalendar1.Size = new System.Drawing.Size(380, 222);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ThemeName = "Aqua";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.TitleFormat = "MMM yy";
            this.radCalendar1.ZoomFactor = 1.2F;
            ((Telerik.WinControls.UI.RadCalendarElement)(this.radCalendar1.GetChildAt(0))).AllowFishEye = false;
            ((Telerik.WinControls.UI.RadCalendarElement)(this.radCalendar1.GetChildAt(0))).ZoomFactor = 1.2F;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2))).Text = "test\r\n";
            // 
            // btnGetFlights
            // 
            this.btnGetFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFlights.BackColor = System.Drawing.Color.Transparent;
            this.btnGetFlights.Location = new System.Drawing.Point(282, 240);
            this.btnGetFlights.Name = "btnGetFlights";
            this.btnGetFlights.Size = new System.Drawing.Size(107, 23);
            this.btnGetFlights.TabIndex = 1;
            this.btnGetFlights.Text = "Get Flights";
            this.btnGetFlights.ThemeName = "Aqua";
            this.btnGetFlights.Click += new System.EventHandler(this.btnGetFlights_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(398, 271);
            this.Controls.Add(this.btnGetFlights);
            this.Controls.Add(this.radCalendar1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Request Flights";
            this.ThemeName = "Aqua";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadButton btnGetFlights;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
    }
}


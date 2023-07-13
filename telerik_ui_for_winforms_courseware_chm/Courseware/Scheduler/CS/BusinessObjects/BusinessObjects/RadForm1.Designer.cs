namespace BusinessObjects
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
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval2 = new Telerik.WinControls.UI.DateTimeInterval();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radScheduler1
            // 
            dateTimeInterval2.End = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval2;
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.MultiDay;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.BackColor = System.Drawing.Color.White;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(15, 15);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radScheduler1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radScheduler1.Size = new System.Drawing.Size(514, 363);
            this.radScheduler1.TabIndex = 2;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ThemeName = "Desert";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 393);
            this.Controls.Add(this.radScheduler1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "RadForm1";
            this.Padding = new System.Windows.Forms.Padding(15);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadScheduler";
            this.ThemeName = "Desert";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
    }
}


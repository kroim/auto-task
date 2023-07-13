namespace DragAndDrop
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
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lcClasses = new Telerik.WinControls.UI.RadListControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Transparent;
            this.radPanel1.Controls.Add(this.lcClasses);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Location = new System.Drawing.Point(384, 10);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // 
            // 
            this.radPanel1.RootElement.Padding = new System.Windows.Forms.Padding(3);
            this.radPanel1.Size = new System.Drawing.Size(214, 342);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radPanel1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(3);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(2))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            // 
            // lcClasses
            // 
            this.lcClasses.CaseSensitiveSort = true;
            this.lcClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcClasses.ItemHeight = 18;
            this.lcClasses.Location = new System.Drawing.Point(3, 19);
            this.lcClasses.Name = "lcClasses";
            this.lcClasses.Size = new System.Drawing.Size(208, 320);
            this.lcClasses.TabIndex = 1;
            this.lcClasses.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lcClasses_MouseUp);
            this.lcClasses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lcClasses_MouseDown);
            this.lcClasses.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lcClasses_MouseMove);
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radLabel1.Size = new System.Drawing.Size(102, 16);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Aavailable Classes";
            // 
            // radScheduler1
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            this.radScheduler1.AllowDrop = true;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.BackColor = System.Drawing.Color.White;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(10, 10);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radScheduler1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radScheduler1.Size = new System.Drawing.Size(374, 342);
            this.radScheduler1.TabIndex = 2;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ThemeName = "ControlDefault";
            this.radScheduler1.DragEnter += new System.Windows.Forms.DragEventHandler(this.radScheduler1_DragEnter);
            this.radScheduler1.DragDrop += new System.Windows.Forms.DragEventHandler(this.radScheduler1_DragDrop);
            ((Telerik.WinControls.UI.RadSchedulerElement)(this.radScheduler1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 362);
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radPanel1);
            this.Name = "RadForm1";
            this.Padding = new System.Windows.Forms.Padding(10);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadScheduler";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadListControl lcClasses;
    }
}


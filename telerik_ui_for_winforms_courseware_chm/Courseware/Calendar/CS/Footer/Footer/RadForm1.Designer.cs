namespace WindowsFormsApplication1
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
            Telerik.WinControls.UI.RadCalendarDay radCalendarDay1 = new Telerik.WinControls.UI.RadCalendarDay();
            Telerik.WinControls.UI.RadCalendarDay radCalendarDay2 = new Telerik.WinControls.UI.RadCalendarDay();
            Telerik.WinControls.UI.RadCalendarDay radCalendarDay3 = new Telerik.WinControls.UI.RadCalendarDay();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCalendar1
            // 
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(0, 0);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            this.radCalendar1.Size = new System.Drawing.Size(269, 241);
            radCalendarDay1.Date = new System.DateTime(2009, 2, 14, 0, 0, 0, 0);
            radCalendarDay1.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth;
            radCalendarDay1.Selectable = false;
            radCalendarDay1.ToolTip = "Don\'t forget Valentines Day!";
            radCalendarDay2.Date = new System.DateTime(2009, 2, 12, 0, 0, 0, 0);
            radCalendarDay2.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth;
            radCalendarDay2.Selectable = false;
            radCalendarDay2.ToolTip = "Abraham Lincoln\'s Birthday";
            radCalendarDay3.Date = new System.DateTime(2009, 2, 2, 0, 0, 0, 0);
            radCalendarDay3.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth;
            radCalendarDay3.Selectable = false;
            radCalendarDay3.ToolTip = "Groundhog Day";
            this.radCalendar1.SpecialDays.Add(radCalendarDay1);
            this.radCalendar1.SpecialDays.Add(radCalendarDay2);
            this.radCalendar1.SpecialDays.Add(radCalendarDay3);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ThemeName = "Desert";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 241);
            this.Controls.Add(this.radCalendar1);
            this.Name = "Form1";
            this.Text = "Calendar";
            this.ThemeName = "Desert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;

    }
}


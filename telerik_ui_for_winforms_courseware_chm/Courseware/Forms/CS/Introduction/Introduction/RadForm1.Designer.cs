using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
namespace Introduction
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.radProgressBarElement1 = new Telerik.WinControls.UI.RadProgressBarElement();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList11 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCalendar1
            // 
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.FastNavigationNextImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.FastNavigationNextImage")));
            this.radCalendar1.FastNavigationPrevImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.FastNavigationPrevImage")));
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(13, 10);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.NavigationNextImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.NavigationNextImage")));
            this.radCalendar1.NavigationPrevImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.NavigationPrevImage")));
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            this.radCalendar1.Size = new System.Drawing.Size(275, 238);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.radCheckBoxElement1,
            this.radProgressBarElement1});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 249);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(442, 30);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.AccessibleDescription = "Current Document: Financials";
            this.radLabelElement1.AccessibleName = "Current Document: Financials";
            this.radLabelElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "Current Document: Financials";
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radCheckBoxElement1
            // 
            this.radCheckBoxElement1.AccessibleDescription = "Check Validity";
            this.radCheckBoxElement1.AccessibleName = "Check Validity";
            this.radCheckBoxElement1.CanFocus = true;
            this.radCheckBoxElement1.Checked = true;
            this.radCheckBoxElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radCheckBoxElement1.Name = "radCheckBoxElement1";
            this.radCheckBoxElement1.ShowBorder = false;
            this.radStatusStrip1.SetSpring(this.radCheckBoxElement1, false);
            this.radCheckBoxElement1.Text = "Check Validity";
            this.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radProgressBarElement1
            // 
            this.radProgressBarElement1.AccessibleDescription = "Verifying";
            this.radProgressBarElement1.AccessibleName = "Verifying";
            this.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radProgressBarElement1.ClipDrawing = true;
            this.radProgressBarElement1.DefaultSize = new System.Drawing.Size(130, 16);
            this.radProgressBarElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radProgressBarElement1.Name = "radProgressBarElement1";
            this.radProgressBarElement1.SeparatorColor1 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorGradientAngle = 0;
            this.radProgressBarElement1.SeparatorGradientPercentage1 = 0.4F;
            this.radProgressBarElement1.SeparatorGradientPercentage2 = 0.6F;
            this.radProgressBarElement1.SeparatorNumberOfColors = 2;
            this.radStatusStrip1.SetSpring(this.radProgressBarElement1, false);
            this.radProgressBarElement1.StepWidth = 14;
            this.radProgressBarElement1.SweepAngle = 90;
            this.radProgressBarElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radProgressBarElement1.Value1 = 30;
            this.radProgressBarElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(355, 225);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(75, 23);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "Confirm";
            // 
            // radDropDownList11
            // 
            radListDataItem1.Text = "First Quarter";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Second Quarter";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Third Quarter";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Fourth Quarter";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "Yearly";
            radListDataItem5.TextWrap = true;
            this.radDropDownList11.Items.Add(radListDataItem1);
            this.radDropDownList11.Items.Add(radListDataItem2);
            this.radDropDownList11.Items.Add(radListDataItem3);
            this.radDropDownList11.Items.Add(radListDataItem4);
            this.radDropDownList11.Items.Add(radListDataItem5);
            this.radDropDownList11.Location = new System.Drawing.Point(304, 10);
            this.radDropDownList11.Name = "radDropDownList11";
            // 
            // 
            // 
            this.radDropDownList11.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radDropDownList11.ShowImageInEditorArea = true;
            this.radDropDownList11.Size = new System.Drawing.Size(126, 20);
            this.radDropDownList11.TabIndex = 3;
            this.radDropDownList11.Text = "radDropDownList11";
            this.radDropDownList11.ThemeName = "Aqua";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 279);
            this.Controls.Add(this.radDropDownList11);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radCalendar1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Aqua Theme Form";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        private Telerik.WinControls.UI.RadProgressBarElement radProgressBarElement1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList11;
        private Telerik.WinControls.UI.RadListDataItem radListDataItem1;
        private Telerik.WinControls.UI.RadListDataItem radListDataItem2;
        private Telerik.WinControls.UI.RadListDataItem radListDataItem3;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem4;
        private Telerik.WinControls.UI.RadListDataItem radListDataItem5;
    }
}


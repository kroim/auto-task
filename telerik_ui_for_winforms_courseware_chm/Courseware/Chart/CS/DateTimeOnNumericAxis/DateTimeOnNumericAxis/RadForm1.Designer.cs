namespace DateTimeOnNumericAxis
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
            Telerik.Charting.Styles.Corners corners1 = new Telerik.Charting.Styles.Corners();
            Telerik.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Charting.Styles.ChartMargins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement1 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement2 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement3 = new Telerik.Charting.GradientElement();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement4 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement5 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement6 = new Telerik.Charting.GradientElement();
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(249)))));
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.radChart1.AutoLayout = true;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(166)))));
            this.radChart1.ChartTitle.TextBlock.Text = "Time Line";
            this.radChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners1.RoundSize = 6;
            corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.Legend.Appearance.Corners = corners1;
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(154)))));
            this.radChart1.Legend.Appearance.Visible = false;
            this.radChart1.Legend.Visible = false;
            this.radChart1.Location = new System.Drawing.Point(3, 3);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent;
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0F;
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(124)))), ((int)(((byte)(160)))));
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(124)))), ((int)(((byte)(160)))));
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(124)))), ((int)(((byte)(160)))));
            this.radChart1.PlotArea.YAxis.AxisLabel.Appearance.Visible = true;
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(124)))), ((int)(((byte)(160)))));
            this.radChart1.PlotArea.YAxis.AxisLabel.Visible = true;
            this.radChart1.PlotArea.YAxis.MaxValue = 100;
            this.radChart1.PlotArea.YAxis.Step = 10;
            chartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(170)))), ((int)(((byte)(40)))));
            gradientElement1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(206)))), ((int)(((byte)(119)))));
            gradientElement2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(190)))), ((int)(((byte)(82)))));
            gradientElement2.Position = 0.5F;
            gradientElement3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            gradientElement3.Position = 1F;
            chartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement1,
            gradientElement2,
            gradientElement3});
            chartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(206)))), ((int)(((byte)(119)))));
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartSeries1.Name = "Series 1";
            chartSeries2.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(192)))));
            gradientElement4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            gradientElement5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(207)))), ((int)(((byte)(220)))));
            gradientElement5.Position = 0.5F;
            gradientElement6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(185)))), ((int)(((byte)(204)))));
            gradientElement6.Position = 1F;
            chartSeries2.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement4,
            gradientElement5,
            gradientElement6});
            chartSeries2.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartSeries2.Name = "Series 2";
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2});
            this.radChart1.Size = new System.Drawing.Size(292, 279);
            this.radChart1.Skin = "LightBlue";
            this.radChart1.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 285);
            this.Controls.Add(this.radChart1);
            this.Name = "RadForm1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Chart";
            this.ThemeName = "Office2007Silver";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
    }
}


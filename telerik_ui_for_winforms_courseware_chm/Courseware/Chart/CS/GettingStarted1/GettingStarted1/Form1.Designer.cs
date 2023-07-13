namespace GettingStarted1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.Charting.Styles.Corners corners2 = new Telerik.Charting.Styles.Corners();
            Telerik.Charting.Styles.ChartMargins chartMargins2 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement1 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement2 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement3 = new Telerik.Charting.GradientElement();
            Telerik.Charting.ChartSeriesItem chartSeriesItem1 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem2 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem3 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem4 = new Telerik.Charting.ChartSeriesItem();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(195)))), ((int)(((byte)(174)))));
            corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners1.RoundSize = 8;
            corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.Appearance.Corners = corners1;
            this.radChart1.Appearance.FillStyle.FillSettings.BackgroundImage = "{chart}";
            this.radChart1.Appearance.FillStyle.FillSettings.ImageDrawMode = Telerik.Charting.Styles.ImageDrawMode.Flip;
            this.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Image;
            this.radChart1.AutoLayout = true;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(91)))), ((int)(((byte)(72)))));
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Georgia", 24F);
            this.radChart1.ChartTitle.TextBlock.Text = "Category Sales";
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.Transparent;
            chartMargins1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Right")));
            chartMargins1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Top")));
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(91)))), ((int)(((byte)(72)))));
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = new System.Drawing.Font("Georgia", 9F);
            this.radChart1.Legend.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.TopRight;
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(189)))), ((int)(((byte)(167)))));
            corners2.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners2.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners2.RoundSize = 7;
            corners2.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners2.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.PlotArea.Appearance.Corners = corners2;
            chartMargins2.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Bottom")));
            chartMargins2.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Left")));
            chartMargins2.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Right")));
            chartMargins2.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Top")));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins2;
            this.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(206)))), ((int)(((byte)(196)))), ((int)(((byte)(142)))));
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.Transparent;
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(171)))), ((int)(((byte)(151)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(73)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Georgia", 8F);
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(73)))));
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Georgia", 8F);
            this.radChart1.PlotArea.XAxis.MaxValue = 4;
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.Transparent;
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(171)))), ((int)(((byte)(151)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(171)))), ((int)(((byte)(151)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(73)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Georgia", 8F);
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(73)))));
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Georgia", 8F);
            this.radChart1.PlotArea.YAxis.MaxValue = 12000;
            this.radChart1.PlotArea.YAxis.Step = 1000;
            chartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(149)))), ((int)(((byte)(58)))));
            gradientElement1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(202)))), ((int)(((byte)(152)))));
            gradientElement2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(123)))));
            gradientElement2.Position = 0.5F;
            gradientElement3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(154)))), ((int)(((byte)(84)))));
            gradientElement3.Position = 1F;
            chartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement1,
            gradientElement2,
            gradientElement3});
            chartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(202)))), ((int)(((byte)(155)))));
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartSeries1.DefaultLabelValue = "#ITEM";
            chartSeriesItem1.Name = "Beverages";
            chartSeriesItem1.YValue = 10000;
            chartSeriesItem2.Name = "Produce";
            chartSeriesItem2.YValue = 7500;
            chartSeriesItem3.Name = "Poultry";
            chartSeriesItem3.YValue = 9000;
            chartSeriesItem4.Name = "Grains";
            chartSeriesItem4.YValue = 11200;
            chartSeries1.Items.AddRange(new Telerik.Charting.ChartSeriesItem[] {
            chartSeriesItem1,
            chartSeriesItem2,
            chartSeriesItem3,
            chartSeriesItem4});
            chartSeries1.Name = "Sales";
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1});
            this.radChart1.Size = new System.Drawing.Size(500, 400);
            this.radChart1.Skin = "Wood";
            this.radChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 431);
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
            this.Text = "RadChart";
            this.ThemeName = "Desert";
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
    }
}


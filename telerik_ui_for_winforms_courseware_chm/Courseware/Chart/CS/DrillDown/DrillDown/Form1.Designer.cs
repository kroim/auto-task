namespace DrillDown
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
            this.components = new System.ComponentModel.Container();
            Telerik.Charting.GradientElement gradientElement10 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement11 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement12 = new Telerik.Charting.GradientElement();
            Telerik.Charting.Styles.ChartMargins chartMargins4 = new Telerik.Charting.Styles.ChartMargins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.Charting.Styles.ChartMargins chartMargins5 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.ChartMargins chartMargins6 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.ChartPaddings chartPaddings2 = new Telerik.Charting.Styles.ChartPaddings();
            Telerik.Charting.ChartSeries chartSeries3 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement13 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement14 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement15 = new Telerik.Charting.GradientElement();
            Telerik.Charting.ChartSeries chartSeries4 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement16 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement17 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement18 = new Telerik.Charting.GradientElement();
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartDataSet = new DrillDown.ChartDataSet();
            this.revenueTableAdapter = new DrillDown.ChartDataSetTableAdapters.RevenueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.radChart1.Appearance.Border.Width = 5F;
            gradientElement10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(120)))), ((int)(((byte)(179)))));
            gradientElement11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(189)))), ((int)(((byte)(254)))));
            gradientElement11.Position = 0.5F;
            gradientElement12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(120)))), ((int)(((byte)(179)))));
            gradientElement12.Position = 1F;
            this.radChart1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement10,
            gradientElement11,
            gradientElement12});
            this.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            this.radChart1.AutoLayout = true;
            this.radChart1.ChartTitle.Appearance.Dimensions.Margins = chartMargins4;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 14F);
            this.radChart1.ChartTitle.TextBlock.Text = "Drill Down";
            this.radChart1.DataSource = this.revenueBindingSource;
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins5;
            this.radChart1.Legend.Appearance.FillStyle.GammaCorrection = false;
            this.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.Legend.Appearance.Visible = false;
            this.radChart1.Legend.TextBlock.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top;
            this.radChart1.Legend.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.LightSkyBlue;
            this.radChart1.Legend.Visible = false;
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(180)))), ((int)(((byte)(223)))));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins6;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent;
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0F;
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Dimensions.Paddings = chartPaddings2;
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.LightSkyBlue;
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Width = 0F;
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.LightSkyBlue;
            this.radChart1.PlotArea.YAxis.MaxValue = 100;
            this.radChart1.PlotArea.YAxis.Step = 10;
            gradientElement13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            gradientElement14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            gradientElement14.Position = 0.5F;
            gradientElement15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            gradientElement15.Position = 1F;
            chartSeries3.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement13,
            gradientElement14,
            gradientElement15});
            chartSeries3.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries3.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            chartSeries3.Name = "Series 1";
            chartSeries4.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            gradientElement16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(78)))));
            gradientElement17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(207)))), ((int)(((byte)(27)))));
            gradientElement17.Position = 0.5F;
            gradientElement18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(3)))));
            gradientElement18.Position = 1F;
            chartSeries4.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement16,
            gradientElement17,
            gradientElement18});
            chartSeries4.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries4.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            chartSeries4.Name = "Series 2";
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries3,
            chartSeries4});
            this.radChart1.Size = new System.Drawing.Size(400, 300);
            this.radChart1.Skin = "DeepBlue";
            this.radChart1.TabIndex = 0;
            this.radChart1.Click += new Telerik.WinControls.UI.RadChart.ChartClickEventHandler(this.radChart1_Click);
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataMember = "Revenue";
            this.revenueBindingSource.DataSource = this.chartDataSet;
            // 
            // chartDataSet
            // 
            this.chartDataSet.DataSetName = "ChartDataSet";
            this.chartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revenueTableAdapter
            // 
            this.revenueTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 321);
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
            this.Text = "RadChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
        private ChartDataSet chartDataSet;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private DrillDown.ChartDataSetTableAdapters.RevenueTableAdapter revenueTableAdapter;
    }
}


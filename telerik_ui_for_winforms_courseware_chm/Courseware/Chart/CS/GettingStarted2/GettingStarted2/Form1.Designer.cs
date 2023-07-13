namespace GettingStarted2
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
            Telerik.Charting.GradientElement gradientElement1 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement2 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement3 = new Telerik.Charting.GradientElement();
            Telerik.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Charting.Styles.ChartMargins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.Charting.Styles.ChartMargins chartMargins2 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.ChartMargins chartMargins3 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.ChartPaddings chartPaddings1 = new Telerik.Charting.Styles.ChartPaddings();
            Telerik.Charting.ChartAxisItem chartAxisItem1 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem2 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem3 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem4 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem5 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem6 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem7 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement4 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement5 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement6 = new Telerik.Charting.GradientElement();
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            this.salesByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet1 = new GettingStarted2.NwindDataSet1();
            this.sales_by_CategoryTableAdapter = new GettingStarted2.NwindDataSet1TableAdapters.Sales_by_CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(87)))), ((int)(((byte)(53)))));
            this.radChart1.Appearance.Border.Width = 5F;
            gradientElement1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            gradientElement2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(208)))), ((int)(((byte)(36)))));
            gradientElement2.Position = 0.5F;
            gradientElement3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            gradientElement3.Position = 1F;
            this.radChart1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement1,
            gradientElement2,
            gradientElement3});
            this.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            this.radChart1.AutoLayout = true;
            this.radChart1.ChartTitle.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 14F);
            this.radChart1.ChartTitle.TextBlock.Text = "Sales By Category";
            this.radChart1.DataSource = this.salesByCategoryBindingSource;
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins2;
            this.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.Legend.Appearance.Visible = false;
            this.radChart1.Legend.TextBlock.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top;
            this.radChart1.Legend.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(208)))), ((int)(((byte)(114)))));
            this.radChart1.Legend.Visible = false;
            this.radChart1.Location = new System.Drawing.Point(13, 13);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins3;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent;
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0F;
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.XAxis.AutoScale = false;
            this.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Dimensions.Paddings = chartPaddings1;
            this.radChart1.PlotArea.XAxis.AxisLabel.Appearance.RotationAngle = 270F;
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(208)))), ((int)(((byte)(114)))));
            this.radChart1.PlotArea.XAxis.DataLabelsColumn = "CategoryName";
            chartAxisItem1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            chartAxisItem2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            chartAxisItem3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            chartAxisItem4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            chartAxisItem5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            chartAxisItem6.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            chartAxisItem7.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.radChart1.PlotArea.XAxis.Items.AddRange(new Telerik.Charting.ChartAxisItem[] {
            chartAxisItem1,
            chartAxisItem2,
            chartAxisItem3,
            chartAxisItem4,
            chartAxisItem5,
            chartAxisItem6,
            chartAxisItem7});
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.LabelAppearance.RotationAngle = 40F;
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Width = 0F;
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.YAxis.AxisLabel.Appearance.RotationAngle = 0F;
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(208)))), ((int)(((byte)(114)))));
            this.radChart1.PlotArea.YAxis.MaxValue = 100;
            this.radChart1.PlotArea.YAxis.Step = 10;
            this.radChart1.PlotArea.YAxis2.AxisLabel.Appearance.RotationAngle = 0F;
            gradientElement4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            gradientElement5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            gradientElement5.Position = 0.5F;
            gradientElement6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            gradientElement6.Position = 1F;
            chartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement4,
            gradientElement5,
            gradientElement6});
            chartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            chartSeries1.DataYColumn = "ProductSales";
            chartSeries1.Name = "ProductSales";
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1});
            this.radChart1.SeriesOrientation = Telerik.Charting.ChartSeriesOrientation.Horizontal;
            this.radChart1.Size = new System.Drawing.Size(400, 300);
            this.radChart1.Skin = "DeepGreen";
            this.radChart1.TabIndex = 0;
            // 
            // salesByCategoryBindingSource
            // 
            this.salesByCategoryBindingSource.DataMember = "Sales by Category";
            this.salesByCategoryBindingSource.DataSource = this.nwindDataSet1;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "NwindDataSet1";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_by_CategoryTableAdapter
            // 
            this.sales_by_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 329);
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
            this.Text = "RadChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
        private NwindDataSet1 nwindDataSet1;
        private System.Windows.Forms.BindingSource salesByCategoryBindingSource;
        private GettingStarted2.NwindDataSet1TableAdapters.Sales_by_CategoryTableAdapter sales_by_CategoryTableAdapter;
    }
}


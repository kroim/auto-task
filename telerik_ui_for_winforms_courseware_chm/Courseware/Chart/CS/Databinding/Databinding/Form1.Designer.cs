namespace Databinding
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
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement4 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement5 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement6 = new Telerik.Charting.GradientElement();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement7 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement8 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement9 = new Telerik.Charting.GradientElement();
            this.radChart2 = new Telerik.WinControls.UI.RadChart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureDataSet1 = new Databinding.FurnitureDataSet();
            this.productsTableAdapter1 = new Databinding.FurnitureDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart2
            // 
            this.radChart2.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.radChart2.Appearance.Border.Width = 5F;
            gradientElement1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            gradientElement2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            gradientElement2.Position = 0.5F;
            gradientElement3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            gradientElement3.Position = 1F;
            this.radChart2.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement1,
            gradientElement2,
            gradientElement3});
            this.radChart2.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            this.radChart2.AutoLayout = true;
            chartMargins1.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Bottom")));
            chartMargins1.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Left")));
            chartMargins1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Right")));
            chartMargins1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Top")));
            this.radChart2.ChartTitle.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart2.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty;
            this.radChart2.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart2.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 14F);
            this.radChart2.DataSource = this.bindingSource1;
            this.radChart2.DefaultType = Telerik.Charting.ChartSeriesType.Point;
            this.radChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChart2.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartMargins2.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Bottom")));
            chartMargins2.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Right")));
            this.radChart2.Legend.Appearance.Dimensions.Margins = chartMargins2;
            this.radChart2.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart2.Legend.Appearance.Visible = false;
            this.radChart2.Legend.TextBlock.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top;
            this.radChart2.Legend.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.radChart2.Legend.Visible = false;
            this.radChart2.Location = new System.Drawing.Point(0, 0);
            this.radChart2.Name = "radChart2";
            this.radChart2.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartMargins3.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Bottom")));
            chartMargins3.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Left")));
            chartMargins3.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Right")));
            chartMargins3.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Top")));
            this.radChart2.PlotArea.Appearance.Dimensions.Margins = chartMargins3;
            this.radChart2.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent;
            this.radChart2.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0F;
            this.radChart2.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            chartPaddings1.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartPaddings1.Bottom")));
            this.radChart2.PlotArea.XAxis.AxisLabel.Appearance.Dimensions.Paddings = chartPaddings1;
            this.radChart2.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.radChart2.PlotArea.XAxis.MinValue = 1;
            this.radChart2.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.YAxis.Appearance.MinorGridLines.Width = 0F;
            this.radChart2.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart2.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart2.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.radChart2.PlotArea.YAxis.MaxValue = 100;
            this.radChart2.PlotArea.YAxis.Step = 10;
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
            chartSeries1.Name = "Series 1";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.Point;
            chartSeries2.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            gradientElement7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(222)))), ((int)(((byte)(78)))));
            gradientElement8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(207)))), ((int)(((byte)(27)))));
            gradientElement8.Position = 0.5F;
            gradientElement9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(3)))));
            gradientElement9.Position = 1F;
            chartSeries2.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement7,
            gradientElement8,
            gradientElement9});
            chartSeries2.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            chartSeries2.Name = "Series 2";
            chartSeries2.Type = Telerik.Charting.ChartSeriesType.Point;
            this.radChart2.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2});
            this.radChart2.Size = new System.Drawing.Size(524, 426);
            this.radChart2.Skin = "DeepGray";
            this.radChart2.TabIndex = 0;
            this.radChart2.ItemDataBound += new System.EventHandler<Telerik.Charting.ChartItemDataBoundEventArgs>(this.radChart1_ItemDataBound);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Products";
            this.bindingSource1.DataSource = this.furnitureDataSet1;
            // 
            // furnitureDataSet1
            // 
            this.furnitureDataSet1.DataSetName = "FurnitureDataSet";
            this.furnitureDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(524, 426);
            this.Controls.Add(this.radChart2);
            this.Name = "Form1";
            this.LocationChanged += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
        private FurnitureDataSet furnitureDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Databinding.FurnitureDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Telerik.WinControls.UI.RadChart radChart2;
        private FurnitureDataSet furnitureDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Databinding.FurnitureDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
    }
}


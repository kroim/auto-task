namespace Programming2
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
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.MaxValue = 90;
            this.radChart1.PlotArea.YAxis.Step = 10;
            chartSeries1.Name = "Series 1";
            chartSeries2.Name = "Series 2";
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2});
            this.radChart1.Size = new System.Drawing.Size(400, 300);
            this.radChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 322);
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
            this.Text = "RadChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
    }
}


namespace RadCarouselProgramming
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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(50, 50, 0);
            carouselEllipsePath1.FinalAngle = -100;
            carouselEllipsePath1.InitialAngle = -90;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-20, -17, -50);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(30, -25, -60);
            carouselEllipsePath1.ZScale = 500;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarousel1.Location = new System.Drawing.Point(0, 0);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.SelectedIndex = 0;
            this.radCarousel1.Size = new System.Drawing.Size(284, 262);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            this.radCarousel1.NewCarouselItemCreating += new Telerik.WinControls.UI.NewCarouselItemCreatingEventHandler(this.radCarousel1_NewCarouselItemCreating);
            this.radCarousel1.ItemDataBound += new Telerik.WinControls.UI.ItemDataBoundEventHandler(this.radCarousel1_ItemDataBound);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radCarousel1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarousel1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            this.radButtonElement1.Image = new Bitmap(Properties.Resources.Lighthouse, new Size(200, 200));
            this.radButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            this.radButtonElement2.Image = new Bitmap(Properties.Resources.Penguins, new Size(200, 200));
            this.radButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            this.radButtonElement3.Image = new Bitmap(Properties.Resources.Tulips, new Size(200, 200));
            this.radButtonElement3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            this.radButtonElement4.Image = new Bitmap(Properties.Resources.Desert, new Size(50, 50));
            this.radButtonElement4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement4.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            this.radButtonElement5.Image = new Bitmap(Properties.Resources.Hydrangeas, new Size(50, 50));
            this.radButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            this.radButtonElement6.Image = new Bitmap(Properties.Resources.Koala, new Size(50, 50));
            this.radButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            radCarousel1.EnableAutoLoop = true;
            radRotator1.Running = true;
        }
    }
}

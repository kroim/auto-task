using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

namespace ShapedFormWalkthrough
{
    public partial class ShapedForm1 : Telerik.WinControls.UI.ShapedForm
    {
        public ShapedForm1()
        {
            InitializeComponent();
        }

        private void ShapedForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicCollectionDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicCollectionDataSet.Albums);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            albumsBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            albumsBindingSource.MoveNext();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName("Office2007Silver");
            string message = "Go on line to get information about \"" + pnlTitle.Text + "\"?";

            Bitmap bitmap = new Bitmap(this.BackgroundImage);
            RadMessageBox.Show(this, message, "Information Options", MessageBoxButtons.YesNo, bitmap);
        }

        private Color GetContrastingColor(Color color)
        {
            // "exclusive OR" the color passed in to leave only the opposite color
            return Color.FromArgb(color.ToArgb() ^ 0xffffff);
        }

        // configure the FillPrimitive to display in a "Gel" gradient style and set color
        private void SetFillPrimitiveColor(RadElement element, Color color1)
        {
            FillPrimitive fillPrimitive = element as FillPrimitive;
            fillPrimitive.NumberOfColors = 1;
            fillPrimitive.GradientStyle = Telerik.WinControls.GradientStyles.Gel;
            fillPrimitive.BackColor = color1;
        }

        private void albumsBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // background image will be null when the form first loads
            if (this.BackgroundImage != null)
            {
                // convert Image to Bitmap for further manipulation
                Bitmap bitmap = new Bitmap(this.BackgroundImage);

                // get a color from the very center of the background image
                Color color1 = bitmap.GetPixel(bitmap.Width / 2, bitmap.Height / 2);
                // get a color that contrasts with the center of the image
                Color contrastingColor = GetContrastingColor(color1);
                // make a transluscent version of this color
                Color semiTransparentColor = Color.FromArgb(150, color1);

                // set the buttons and panel with a gradient from the translucent color to the corner color
                SetFillPrimitiveColor(pnlTitle.PanelElement.Children[0], semiTransparentColor);
                SetFillPrimitiveColor(btnBack.ButtonElement.Children[0], semiTransparentColor);
                SetFillPrimitiveColor(btnNext.ButtonElement.Children[0], semiTransparentColor);
                SetFillPrimitiveColor(btnInfo.ButtonElement.Children[0], semiTransparentColor);

                // set the color for the text to the contrasting color
                (btnBack.ButtonElement.Children[1].Children[1] as TextPrimitive).ForeColor = contrastingColor;
                (btnNext.ButtonElement.Children[1].Children[1] as TextPrimitive).ForeColor = contrastingColor;
                (btnInfo.ButtonElement.Children[1].Children[1] as TextPrimitive).ForeColor = contrastingColor;
                pnlTitle.ForeColor = contrastingColor;
            }
        }
    }
}
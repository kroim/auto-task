using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace TestMyTPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get the "ButtonElement", just under the root element,
            // set the padding and text
            RadButtonElement buttonElement = radButton2.RootElement.Children[0] as RadButtonElement;
            buttonElement.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonElement.Padding = new Padding(10);
            buttonElement.Text = "World" + Environment.NewLine + "Clock";

            // access the fill primitive, use "OfficeGlass" style and set coloring
            FillPrimitive fillPrimitive =
              (FillPrimitive)buttonElement.GetChildrenByType(typeof(FillPrimitive))[0];
            fillPrimitive.GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlass;
            fillPrimitive.BackColor = Color.Blue;
            fillPrimitive.BackColor2 = Color.LightBlue;
            fillPrimitive.BackColor3 = Color.Lavender;
            fillPrimitive.BackColor4 = Color.Purple;

            // get the image primitive and set image. Set the opacity to be 50% transparent.
            ImagePrimitive imagePrimitive =
              (ImagePrimitive)buttonElement.Children[1].Children[0] as ImagePrimitive;
            imagePrimitive.Image = Properties.Resources.Globe;
            imagePrimitive.Opacity = 0.5;

            // get the text primitive and set the font to use a bold, script
            TextPrimitive textPrimitive =
              (TextPrimitive)buttonElement.Children[1].Children[1] as TextPrimitive;
            textPrimitive.Font = new Font("Segoe Script", 8.25F, FontStyle.Bold);

            // get the border primitive and hide it.
            BorderPrimitive borderPrimitive =
              (BorderPrimitive)buttonElement.GetChildrenByType(typeof(BorderPrimitive))[0];
            borderPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden;

            // match the button sizes 
            radButton2.Size = radButton1.Size;
        }
    }
}

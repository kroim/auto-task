using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

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
            // apply style to entire form, also color the form background.
           ThemeResolutionService.ApplicationThemeName = "Desert";

            // set the item to execute when the button portion of the split
            // button is clicked.
            sbSizeMode.DefaultItem = sbSizeMode.Items["btnSizeModeZoom"];
            // set the initial text for the split button
            sbSizeMode.Text = sbSizeMode.Items["btnSizeModeZoom"].Text;
            sbSizeMode.DefaultItem.PerformClick(); 
        }

        private void SizeModeClick(object sender, EventArgs e)
        {
            // retrieve the clicked item
            RadMenuButtonItem item = sender as RadMenuButtonItem;
            // Get the SizeMode enumeration element from the tag and assign to the PictureBox SizeMode
            pictureBox1.SizeMode = (PictureBoxSizeMode)Convert.ToInt32(item.Tag);
            // set the SplitButton text to the clicked on item text
            sbSizeMode.Text = item.Text;
        }

        private void BorderStyleClick(object sender, EventArgs e)
        {
            // Get the BorderStyle enumeration element from the tag and assign to the PictureBox BorderStyle
            pictureBox1.BorderStyle = (BorderStyle)Convert.ToInt32((sender as RadRadioButton).Tag);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // open a user selected image file and assign to the picture box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap;
            }
        }
    }
}

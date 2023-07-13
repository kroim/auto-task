using System;
// Supports IDictionaryEnumerator
using System.Collections;
using System.Drawing;
// Supports CultureInfo
using System.Globalization;
// Supports GetFileNameWithoutExtension
using System.IO;
// Supports ResourceSet, Resources
using System.Resources;
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

            // list the resources in Properties.Resources
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(
              CultureInfo.CurrentCulture, true, true);
            IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

            // for each image resources, retrieve the image name and object,
            // create and populate the menu item, then add to the drop down
            // button items collection
            while (enumerator.MoveNext())
            {
                // the key will be the name of the image, minus extension,
                // also remove underline
                string key = ((string)enumerator.Key).Replace('_', ' ');
                // the value will be the image object
                Image image = (Image)enumerator.Value;

                RadMenuItem item = GetImageMenuItem(key, image);
                ddbImages.Items.Add(item);
            }
            ddbImages.Items[0].PerformClick();

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

        // create and populate a single menu item
        private RadMenuItem GetImageMenuItem(string name, Image image)
        {
            RadMenuItem item = new RadMenuItem();
            item.Text = name;
            // store the full image in the tag property and display a thumbnail version
            item.Tag = image;
            item.Image = image.GetThumbnailImage(32, 32, null, new IntPtr());
            item.Click += new EventHandler(ChooseImagesClick);

            return item;
        }

        private void ChooseImagesClick(object sender, EventArgs e)
        {
            // when a drop down button item is clicked, get the item and
            // retrieve the image, thumbnail and text, then assign to 
            // the picture box image and the drop down button image and text.
            RadMenuItem item = (sender as RadMenuItem);
            ddbImages.Image = ((Image)item.Tag).GetThumbnailImage(16, 16, null, new IntPtr());
            ddbImages.Text = item.Text;
            ddbImages.TextImageRelation = TextImageRelation.ImageBeforeText;

            pictureBox1.Image = (Image)item.Tag;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // if the user selects an image, create a Bitmap object
            // and create a key name by stripping the file path for only
            // the file name without extension. 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                string key = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                RadMenuItem item = GetImageMenuItem(key, bitmap);
                ddbImages.Items.Insert(0, item);
                item.PerformClick();

                pictureBox1.Image = bitmap;
            }
        }
    }
}

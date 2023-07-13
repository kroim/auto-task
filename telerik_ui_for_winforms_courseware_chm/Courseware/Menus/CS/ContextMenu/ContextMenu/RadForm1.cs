using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace ContextMenu
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();


            ThemeResolutionService.RegisterThemeFromStorage(ThemeStorageType.Resource, "ContextMenu.Resources.RadMenuButtonItem.xml");
            cmDeliveryMethod.ThemeName = "Office2007Silver";
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // prevent the standard MS context menu
            tbGiftType.TextBoxElement.TextBoxItem.HostedControl.ContextMenuStrip =
              new ContextMenuStrip();

            // hook up a RadContextMenu by using the TextBoxElement mouse down event      
            tbGiftType.TextBoxElement.MouseDown += new MouseEventHandler(TextBoxElement_MouseDown);

            LoadWrappingContextMenu();
        }

        // respond to right mouse clicks in the text box
        void TextBoxElement_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmGiftType.Show(sender as RadTextBoxElement, 10,10);
            }
        }

        // enumerate the image resources, creating menu items
        private void LoadWrappingContextMenu()
        {
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(
              CultureInfo.CurrentCulture, true, true);
            IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

            while (enumerator.MoveNext())
            {
                string key = ((string)enumerator.Key).Replace('_', ' ');
                Image image = (Image)enumerator.Value;

                RadMenuItem item = new RadMenuItem();
                item.Text = Path.GetFileNameWithoutExtension(key);
                item.Image = image.GetThumbnailImage(64, 64, null, new IntPtr());
                item.Click += new EventHandler(item_Click);
                cmWrapping.Items.Add(item);
            }
        }

        // respond to clicks of the "wrapping" items by assigning
        // the panel background image.
        void item_Click(object sender, EventArgs e)
        {
            pnlWrappingPaper.BackgroundImage = (sender as RadMenuItem).Image;
        }

        private void miGiftTypeClick(object sender, EventArgs e)
        {
            tbGiftType.Text = (sender as RadMenuItem).Text;
        }

        private void mbiDeliveryMethodClick(object sender, EventArgs e)
        {
            lblDeliveryMethod.Text = (sender as RadMenuButtonItem).Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Resources;
using System.Globalization;
using System.Collections;
using Telerik.WinControls;

namespace Programming
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RadCommandBar radCommandBar1 = new RadCommandBar();

        private void Form1_Load(object sender, EventArgs e)
        {
            radCommandBar1.Dock = DockStyle.Top;
            radCommandBar1.Name = "radCommandBar1";
            this.Controls.Add(radCommandBar1);

            CommandBarRowElement commandBarRowElement1 = new CommandBarRowElement();
            commandBarRowElement1.Name = "commandBarRowElement1";
            radCommandBar1.Rows.Add(commandBarRowElement1);

            CommandBarStripElement commandBarStripElement1 = new CommandBarStripElement();
            commandBarStripElement1.Name = "commandBarStripElement1";
            commandBarRowElement1.Strips.Add(commandBarStripElement1);

            LoadItems(commandBarStripElement1);
        }

        private void LoadItems(CommandBarStripElement stripElement)
        {
            // list the resources in Properties.Resources
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(
              CultureInfo.CurrentCulture, true, true);
            IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

            // for each image resources, retrieve the image name and object,
            // create and populate the list items
            while (enumerator.MoveNext())
            {
                CommandBarButton item = new CommandBarButton();
                item.Image = (Bitmap)enumerator.Value;
                //the name have to be set since the save and load layout mechanism is using it
                item.Name = enumerator.Key.ToString().Replace('_', ' ');
                item.ToolTipText = item.Name;
                //sets the text that will be displayed in the overflow button
                item.DisplayName = item.Name;
                item.TextImageRelation = TextImageRelation.ImageAboveText;
                item.Click+=new EventHandler(item_Click);
                stripElement.Items.Add(item);
            }
        }

        void  item_Click(object sender, EventArgs e)
        {
            CommandBarButton buttonElement = sender as CommandBarButton;
            RadCommandBar commandBar = buttonElement.ElementTree.Control as RadCommandBar;
            Bitmap bitmap = new Bitmap(buttonElement.Image);
            RadMessageBox.Show(this, buttonElement.Text, "You clicked...", MessageBoxButtons.OK, bitmap);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s = "default.xml";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter =
               "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Select a xml file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                s = dialog.FileName;
            }

            this.radCommandBar1.CommandBarElement.SaveLayout(s);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string s = "default.xml";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Select a xml file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                s = dialog.FileName;
            }

            this.radCommandBar1.CommandBarElement.LoadLayout(s);
        }

    }
}

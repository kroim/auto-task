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

        private void listViewButton_Click(object sender, EventArgs e)
        {
            radListView1.ViewType = ListViewType.ListView;
            radListView1.AllowArbitraryItemHeight = true;
        }

        private void detailsViewButton_Click(object sender, EventArgs e)
        {
            radListView1.ViewType = ListViewType.DetailsView;
            radListView1.AllowArbitraryItemHeight = true;
        }

        private void iconsViewButton_Click(object sender, EventArgs e)
        {
            radListView1.ViewType = ListViewType.IconsView;
            radListView1.AllowArbitraryItemWidth = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
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
            ThemeResolutionService.ApplicationThemeName = "Office2007Silver";

            RadTreeNode node = radTreeView1.Nodes["Email Contacts"].Nodes.Add("Bob Tony");
            node.Selected = true;
            radTreeView1.Nodes["Email Contacts"].Nodes.Add("Sue Winchell");
            radTreeView1.Nodes["Email Contacts"].Nodes.Add("Lui Sang");
            radTreeView1.Nodes["Lists"].Nodes.Add("Priorities");
            radTreeView1.Nodes["Lists"].Nodes.Add("Opportunities");
            radTreeView1.Nodes["Lists"].Nodes.Add("Issues");
            node = radTreeView1.Nodes["Reports"].Nodes.Add("June Sales");
            node.ContextMenu = radContextMenu1;
            node = radTreeView1.Nodes["Reports"].Nodes.Add("July Sales");
            node.ContextMenu = radContextMenu1;
            node = radTreeView1.Nodes["Reports"].Nodes.Add("First Quarter Summary");
            node.ContextMenu = radContextMenu1;
            node = radTreeView1.Nodes["Reports"].Nodes.Add("Second Quarter Summary");
            node.ContextMenu = radContextMenu1;
        }
    }
}

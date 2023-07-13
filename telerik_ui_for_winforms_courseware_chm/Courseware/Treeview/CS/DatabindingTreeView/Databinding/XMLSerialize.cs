using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using System.IO;

namespace Databinding
{
    public partial class XMLSerialize : RadForm
    {
        public XMLSerialize()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML Files|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radTreeView1.SaveXML(dialog.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML Files|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radTreeView1.LoadXML(dialog.FileName);
            }
        }

        private void btnAddSibling_Click(object sender, EventArgs e)
        {
            // get the sibling level nodes collection and add to it
            RadTreeNodeCollection nodes = null;
            if ((radTreeView1.SelectedNode == null) ||
                (radTreeView1.SelectedNode.Parent == null))
                nodes = radTreeView1.Nodes;
            else
            {
                nodes = radTreeView1.SelectedNode.Parent.Nodes;
            }
            RadTreeNode node = new RadTreeNode(tbNodeText.Text);
            nodes.Add(node);
            radTreeView1.BringIntoView(node);

        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            // add a node directly to the selected node
            if (radTreeView1.SelectedNode != null)
            {
                RadTreeNode node = new RadTreeNode(tbNodeText.Text);
                radTreeView1.SelectedNode.Nodes.Add(node);
                radTreeView1.BringIntoView(node);
            }
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            // delete the selected node
            if (radTreeView1.SelectedNode != null)
                radTreeView1.SelectedNode.Remove();
        }
    }
}

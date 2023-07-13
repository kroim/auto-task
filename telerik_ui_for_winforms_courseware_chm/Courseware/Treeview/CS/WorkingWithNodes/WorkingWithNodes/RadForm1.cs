using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;

namespace WorkingWithNodes
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // add nodes using RadTreeNode constructor
            RadTreeNode rootNode = new RadTreeNode("Root");
            radTreeView1.Nodes.Add(rootNode);

            // add nodes using Nodes Add() method only
            rootNode.Nodes.Add("Child Node 1");
            rootNode.Nodes.Add("Child Node 2");
            rootNode.Nodes.Add("Child Node 3");
            RadTreeNode childNode4 = rootNode.Nodes.Add("Child Node 4");
            rootNode.Nodes.Add("Child Node 5");

            childNode4.Nodes.Add("Child Node 4 A");
            childNode4.Nodes.Add("Child Node 4 B");
            childNode4.Nodes.Add("Child Node 4 C");

            radTreeView1.ExpandAll();
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            // move selected node to the end of the list
            // Note: Parent and Index properties are deprecated only for "getters"
            if ((radTreeView1.SelectedNode != null) &&
                (radTreeView1.SelectedNode.Parent != null))
            {
                RadTreeNodeCollection nodes = radTreeView1.SelectedNode.Parent.Nodes;
                nodes.Move(radTreeView1.SelectedNode.Index, nodes.Count - 1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            radTreeView1.Filter = commandBarTextBox1.Text;
        }


        private void MultiSelect_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radTreeView1.MultiSelect = args.ToggleState == ToggleState.On;
        }

        private void btnSelectedNodes_Click(object sender, EventArgs e)
        {
            // color the background of all selected nodes
            foreach (RadTreeNode node in radTreeView1.SelectedNodes)
            {
                node.BackColor = Color.AliceBlue;
                node.BackColor2 = Color.LightBlue;
            }
        }

    }
}

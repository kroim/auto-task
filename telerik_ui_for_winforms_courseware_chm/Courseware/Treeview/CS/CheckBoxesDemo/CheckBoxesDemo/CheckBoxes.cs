using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace CheckBoxesDemo
{
    public partial class CheckBoxes : RadForm
    {
        public CheckBoxes()
        {
            InitializeComponent();
        }

        private void CheckBoxes_Load(object sender, EventArgs e)
        {
            // display checkboxes next to nodes
            radTreeView1.CheckBoxes = true;

            // create a root node and set its CheckType to None 
            RadTreeNode root = new RadTreeNode("Options");
            root.Expanded = true;
            root.CheckType = CheckType.None;

            // create three nodes with radio buttons and select the second node
            RadTreeNode node1 = new RadTreeNode("Minimal");
            node1.CheckType = CheckType.RadioButton;

            RadTreeNode node2 = new RadTreeNode("Install All");
            node2.CheckType = CheckType.RadioButton;
            node2.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;

            RadTreeNode node3 = new RadTreeNode("Custom");
            node3.CheckType = CheckType.RadioButton;

            // add a checkbox node and select it
            RadTreeNode node4 = new RadTreeNode("Include Extras");
            node4.CheckType = CheckType.CheckBox;
            node4.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;

            // add nodes to the root node
            root.Nodes.Add(node1);
            root.Nodes.Add(node2);
            root.Nodes.Add(node3);
            root.Nodes.Add(node4);

            // add root to the treeview nodes
            radTreeView1.Nodes.Add(root);
        }
    }
}

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Editing
{
    public partial class EditNodes : RadForm
    {
        public EditNodes()
        {
            InitializeComponent();
        }

        private void EditNodes_Load(object sender, EventArgs e)
        {
            radTreeView1.AllowEdit = true;
        }

        private string _oldNodeText;

        private void radTreeView1_Editing(object sender, TreeNodeEditingEventArgs e)
        {
            _oldNodeText = e.Node.Text;

            // disallow editing root nodes.
            if (e.Node.Level == 0)
            {
                e.Cancel = true;
                lblStatus.Text = "You cannot edit a root node";
            }
        }

        private void radTreeView1_ValueValidating(object sender, TreeNodeValidatingEventArgs e)
        
        {
            string newNodeText = radTreeView1.ActiveEditor.Value as string;

            // disallow blank entries
            if (newNodeText.Equals(String.Empty))
            {
                e.Cancel = true;
                lblStatus.Text = "Cannot be blank - Enter a new value";
            }
        }

        private void radTreeView1_Edited(object sender, TreeNodeEditedEventArgs e)
        {
            // display text before and after editing
            string newNodeText = e.Node.Text;
            if (!_oldNodeText.Equals(newNodeText))
            {
                lblStatus.Text = String.Format("Node text has changed from {0} to {1}",
                  _oldNodeText, newNodeText);
            }
        }

        private void radTreeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // edit double-clicked node
            RadTreeNode node = radTreeView1.GetNodeAt(e.X, e.Y);
            if (node != null)
            {
                node.BeginEdit();
            }
        }
    }
}

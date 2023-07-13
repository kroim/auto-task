using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using System.Diagnostics;

namespace DragAndDrop
{
    public partial class DragAndDropForm : RadForm
    {
        public DragAndDropForm()
        {
            InitializeComponent();
        }

        private void DragAndDropForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                tvLeft.Nodes.Add("Node " + i);
            }
            
            // configure treeview and hook up events
            tvLeft.ExpandAll();
            tvLeft.TreeViewElement.DragDropService.PreviewDragDrop += new EventHandler<RadDropEventArgs>(DragDropService_PreviewDragDrop);
            tvLeft.TreeViewElement.DragDropService.PreviewDragOver += new EventHandler<RadDragOverEventArgs>(DragDropService_PreviewDragOver);

            // create columns and configure grid
            GridViewTextBoxColumn nameColumn = new GridViewTextBoxColumn("Name");
            grdLowerRight.Columns.Add(nameColumn);
            grdLowerRight.AllowRowReorder = true;
            grdLowerRight.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            RadDragDropService gridDragDropService = grdLowerRight.GridViewElement.GetService<RadDragDropService>();
            gridDragDropService.PreviewDragDrop += new EventHandler<RadDropEventArgs>(gridDragDropService_PreviewDragDrop);
            gridDragDropService.PreviewDragOver += new EventHandler<RadDragOverEventArgs>(gridDragDropService_PreviewDragOver);

            tvTopRight.AllowDrop = true;
        }

        #region treeview to gridview and vice versa

        void gridDragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            //if the drop target is TreeNodeElement enable dropping
            TreeNodeElement nodeElement = e.HitTarget as TreeNodeElement;
            if (nodeElement != null)
            {
                e.CanDrop = true;
            }
        }

        void gridDragDropService_PreviewDragDrop(object sender, RadDropEventArgs e)
        {
            GridDataRowElement rowElement = e.DragInstance as GridDataRowElement;
            TreeNodeElement nodeElement = e.HitTarget as TreeNodeElement;

            if (nodeElement != null)
            {
                //insert the node at the place under the currently hovered node
                tvLeft.Nodes.Insert(nodeElement.Data.Index, new RadTreeNode(grdLowerRight.CurrentCell.Text));
                
                //remove the dragged row from RadGridView
                grdLowerRight.Rows.Remove(rowElement.Data);
                e.Handled = true;
            }
        }

        private void DragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            GridTableElement tableElement = e.HitTarget as GridTableElement;
            GridDataRowElement dataRow = e.HitTarget as GridDataRowElement;

            Trace.WriteLine(e.HitTarget);
            //if dragged in RadGridView or over a data row in RadGridView, enable dropping
            if (tableElement != null || dataRow != null)
            {
                e.CanDrop = true;
            }
        }

        private void DragDropService_PreviewDragDrop(object sender, RadDropEventArgs e)
        {
            GridTableElement tableElement = e.HitTarget as GridTableElement;
            GridDataRowElement dataRow = e.HitTarget as GridDataRowElement;
            TreeNodeElement nodeElement = e.DragInstance as TreeNodeElement;

            ///if dragged over RadGridView add new row to the Rows collection with the node data
            if (tableElement != null)
            {
                tableElement.ViewTemplate.Rows.Add(nodeElement.Data.Text);
                tvLeft.Nodes.Remove(nodeElement.Data);
                e.Handled = true;
            }
            //if dragged over a row, insert new row with the node data at the hovered row place 
            else if (dataRow != null)
            {
                GridViewRowInfo rowInfo = dataRow.ViewTemplate.Rows.NewRow();
                rowInfo.Cells[0].Value = nodeElement.Data.Text;
                dataRow.ViewTemplate.Rows.Insert(dataRow.RowInfo.Index, rowInfo);
                tvLeft.Nodes.Remove(nodeElement.Data);
                e.Handled = true;
            }
        }

        #endregion 

        #region toggleButtons event handlers

        private void btnAllowDragDrop_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            tvLeft.AllowDragDrop = Convert.ToBoolean(args.ToggleState);
            tvTopRight.AllowDragDrop = Convert.ToBoolean(args.ToggleState);
        }

        private void btnFeedback_ToggleStateChanged(object sender, StateChangedEventArgs args)
       
        {
            tvLeft.ShowDragHint = Convert.ToBoolean(args.ToggleState);
            tvLeft.ShowDropHint = Convert.ToBoolean(args.ToggleState);
        }

        #endregion

        #region standard text box to treeview

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void tvTopRight_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tvTopRight_DragDrop(object sender, DragEventArgs e)
        {
            Point p = tvTopRight.PointToClient(new Point(e.X, e.Y));
            RadTreeNode hoverNode = tvTopRight.GetNodeAt(p.X, p.Y);

            if (hoverNode == null)
            {
                tvTopRight.Nodes.Add(e.Data.GetData(DataFormats.Text).ToString());
                return;
            }
            hoverNode.Nodes.Add(e.Data.GetData(DataFormats.Text).ToString());

        }

        #endregion

    }
}

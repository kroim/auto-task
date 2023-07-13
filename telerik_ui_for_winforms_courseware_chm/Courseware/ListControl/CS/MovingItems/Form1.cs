using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace MovingItems
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Rectangle _dragRectangle = Rectangle.Empty;
        private RadListDataItem _currentItem;

        private void Form1_Load(object sender, EventArgs e)
        {
            lcLeft.SelectionMode = SelectionMode.MultiExtended;
            lcLeft.AllowDrop = true;

            lcRight.SelectionMode = SelectionMode.MultiExtended;
            lcRight.AllowDrop = true;
        }

        private void lcLeft_MouseDown(object sender, MouseEventArgs e)
        {
            // get the listcontrol that items are being dragged from
            RadListControl sourceListControl = sender as RadListControl;

            // get the list box item directly under the mouse 
            RadElement element = sourceListControl.ElementTree.GetElementAtPoint(e.Location);
            RadListVisualItem visualItem = element as RadListVisualItem;
            if (visualItem != null)
            {
                _currentItem = visualItem.Data;
                // create a "drag rectangle" with mouse in center
                Point dragPoint = new Point(
                  e.X - (SystemInformation.DragSize.Width / 2),
                  e.Y - (SystemInformation.DragSize.Height / 2));
                _dragRectangle = new Rectangle(dragPoint, SystemInformation.DragSize);
            }
        }

        private void lcLeft_MouseMove(object sender, MouseEventArgs e)
        {
            RadListControl sourceListControl = sender as RadListControl;
            // we have at least one item to drop
            if (_currentItem != null)
            {
                // we have moved outside the rectangle, so start the drag drop
                if (!_dragRectangle.Contains(e.X, e.Y))
                {
                    sourceListControl.DoDragDrop(sourceListControl, DragDropEffects.Move);
                }
            }
        }

        private void lcLeft_MouseUp(object sender, MouseEventArgs e)
        {
            // we're no longer dragging, so clear these temporary variables
            _dragRectangle = Rectangle.Empty;
            _currentItem = null;
        }

        private void lcRight_DragEnter(object sender, DragEventArgs e)
        {
            // verify that the drag contains the RadListControl and that 
            // we're not dragging onto the same list control.
            if (e.Data.GetDataPresent(typeof(RadListControl)))
            {
                RadListControl sourceListControl = 
                 (RadListControl)e.Data.GetData(typeof(RadListControl));
                if (sourceListControl != (sender as RadListControl))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void lcRight_DragDrop(object sender, DragEventArgs e)
        {
            // get a reference to the source list control, 
            // and move the items. 
            RadListControl sourceListControl =
                     (RadListControl)e.Data.GetData(typeof(RadListControl));
            if (!_currentItem.Selected)
            {
                _currentItem.Selected = true;
            }

            MoveItems(sourceListControl, (sender as RadListControl));
            _dragRectangle = Rectangle.Empty;
            _currentItem = null;
        }

        private void MoveItems(RadListControl source, RadListControl target)
        {

            List<RadListDataItem> itemsToMove = new List<RadListDataItem>();
            foreach (RadListDataItem item in source.SelectedItems)
            {
                itemsToMove.Add(item);
            }

            foreach (RadListDataItem item in itemsToMove)
            {
                target.Items.Add(item);
            }
        }
    }
}

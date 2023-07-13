using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DragAndDrop
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private Rectangle _dragRectangle = Rectangle.Empty;
        private RadListVisualItem _currentItem;

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // list the resources in Properties.Resources
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(
              CultureInfo.CurrentCulture, true, true);
            IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

            // for each image resources, retrieve the image name and object,
            // create and populate the menu item, then add to the drop down
            // button items collection
            while (enumerator.MoveNext())
            {
                // the key will be the name of the image, minus extension,
                // also remove underline
                string key = ((string)enumerator.Key).Replace('_', ' ');
                // the value will be the image object
                Image image = (Image)enumerator.Value;
                RadListDataItem item = new RadListDataItem(key);
                item.Image = image;
                item.TextImageRelation = TextImageRelation.ImageBeforeText;
                lcClasses.Items.Add(item);
            }
        }

        private void lcClasses_MouseDown(object sender, MouseEventArgs e)
        {
            // get the list control that items are being dragged from
            RadListControl sourceListControl = sender as RadListControl;

            // get the list control item directly under the mouse 
            RadElement element = sourceListControl.ElementTree.GetElementAtPoint(e.Location);
            if (element != null)
            {
                _currentItem = element as RadListVisualItem;
                // create a "drag rectangle" with mouse in center
                Point dragPoint = new Point(
                  e.X - (SystemInformation.DragSize.Width / 2),
                  e.Y - (SystemInformation.DragSize.Height / 2));
                _dragRectangle = new Rectangle(dragPoint, SystemInformation.DragSize);
            }
        }

        private void lcClasses_MouseMove(object sender, MouseEventArgs e)
        {
            RadListControl sourceListControl = sender as RadListControl;
            // we have at least one item to drop
            if (_currentItem != null)
            {
                // we have moved outside the rectangle, so start the drag drop
                if (!_dragRectangle.Contains(e.X, e.Y))
                {
                    sourceListControl.DoDragDrop(sourceListControl, DragDropEffects.Copy);
                }
            }
        }

        private void radScheduler1_DragEnter(object sender, DragEventArgs e)
        {
            // verify that the drag contains the RadListControl and that 
            // we're not dragging onto the same list control.
            if (e.Data.GetDataPresent(typeof(RadListControl)))
            {
                RadListControl sourceListControl =
                 (RadListControl)e.Data.GetData(typeof(RadListControl));
                if (sourceListControl != (sender as RadListControl))
                    e.Effect = DragDropEffects.Copy;
            }

            if (e.Data.GetDataPresent(typeof(RadListControl)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void radScheduler1_DragDrop(object sender, DragEventArgs e)
        {
            RadScheduler scheduler = sender as RadScheduler;
            // get mouse location on the screen
            Point mouseLocation = new Point(e.X, e.Y);
            // convert to location on the sceduler
            Point schedulerLocation = scheduler.SchedulerElement.PointFromScreen(mouseLocation);
            // get the cell element for the location
            RadElement element = scheduler.ElementTree.GetElementAtPoint(schedulerLocation);
            // cast cell element to MonthCellElement and create an appointment for cell date
            if ((element != null) && (element is MonthCellElement))
            {
                MonthCellElement monthCellElement = element as MonthCellElement;
                Appointment appointment = GetCellAppointment(monthCellElement);
                scheduler.Appointments.Add(appointment);
            }

            // finished drop, clear temporary variables
            _dragRectangle = Rectangle.Empty;
            _currentItem = null;
        }

        private Appointment GetCellAppointment(MonthCellElement monthCellElement)
        {
            Appointment appointment = new Appointment();
            // start at 9:00AM on the drop target cell date
            appointment.Start = monthCellElement.Date.AddHours(9);
            // class is 8 hours long
            appointment.Duration = TimeSpan.FromHours(8);
            // copy the list control item itext as the summary
            appointment.Summary = _currentItem.Text;
            // fill other misc properties
            appointment.Location = "Telerik Training Center";
            appointment.BackgroundId = (int)AppointmentBackground.Important;
            appointment.StatusId = (int)AppointmentStatus.Busy;

            // the class will run for three, eight hour days
            appointment.RecurrenceRule = new DailyRecurrenceRule(appointment.Start, 1, 3);

            return appointment;
        }

        private void lcClasses_MouseUp(object sender, MouseEventArgs e)
        {
            // we're no longer dragging, so clear these temporary variables
            _dragRectangle = Rectangle.Empty;
            _currentItem = null;
        }
    }
}

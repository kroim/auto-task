using System;

using Telerik.WinControls.RadDock;

namespace MyDockLib
{
    public partial class CalendarPanel : UserDockControl
    {
        public CalendarPanel()
        {
            InitializeComponent();
        }

        public delegate void DateChangedHandler(DateTime date);
        public event DateChangedHandler DateChanged;
        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            if (DateChanged != null)
            {
                DateChanged((sender as Telerik.WinControls.UI.RadCalendar).SelectedDate);
            }
        }
    }
}

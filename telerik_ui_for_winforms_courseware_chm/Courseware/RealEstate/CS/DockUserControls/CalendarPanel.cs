using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DockUserControls
{
    public partial class CalendarPanel : UserControl
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

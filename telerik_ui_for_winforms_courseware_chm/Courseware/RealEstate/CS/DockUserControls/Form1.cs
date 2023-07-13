using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls;

namespace DockUserControls
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            CalendarPanel calendarPanel = new CalendarPanel();
            HostWindow host = this.radDock1.DockControl(calendarPanel, Telerik.WinControls.UI.Docking.DockPosition.Left);
            host.Text = "Calendar";
            calendarPanel.DateChanged += calendarPanel_DateChanged;
        }

        void calendarPanel_DateChanged(DateTime date)
        {
            RadMessageBox.Show("Selected date is: " + date.ToShortDateString());
        }
    }
}

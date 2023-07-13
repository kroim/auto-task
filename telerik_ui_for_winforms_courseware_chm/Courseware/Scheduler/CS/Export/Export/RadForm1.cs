using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;
using Telerik.WinControls.UI.Scheduler.ICalendar;

namespace Export
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.Create("c:\\schedule.ics"))
            {
                this.radScheduler1.Export(stream, new SchedulerICalendarExporter());
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.OpenRead("c:\\schedule.ics"))
            {
                this.radScheduler1.Import(stream, new SchedulerICalendarImporter());
            }

        }
    }
}

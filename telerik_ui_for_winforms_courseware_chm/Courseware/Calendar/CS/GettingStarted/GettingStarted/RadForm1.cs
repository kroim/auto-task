using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            radCalendar1.ShowFooter = true;
        }

        private void btnGetFlights_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (DateTime dateTime in radCalendar1.SelectedDates)
            {
                builder.Append(dateTime.ToLongDateString());
                builder.Append(Environment.NewLine);
            }
            RadMessageBox.SetThemeName("Aqua");
            RadMessageBox.Show(builder.ToString(), "Look for flights on these days?",
              MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }
    }
}

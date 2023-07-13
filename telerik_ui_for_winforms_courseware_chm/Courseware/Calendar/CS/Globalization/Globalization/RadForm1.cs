using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Globalization;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;

namespace Globalization
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // list some cultures that we can assign to the calendar
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.WindowsOnlyCultures);

            foreach (CultureInfo cultureInfo in cultures)
            {
                string description = "Culture code: " + cultureInfo.Name;
                RadListDataItem item = new RadListDataItem(cultureInfo.DisplayName, cultureInfo.Name);
                commandBarDropDownList1.Items.Add(item);
            }

            commandBarDropDownList1.SelectedIndex = 0;
            // make the combo textbox wider
            commandBarDropDownList1.MinSize = new Size(200, 0);

            // list the DayNameFormats
            foreach (DayNameFormat dayNameFormat in Enum.GetValues(typeof(DayNameFormat)))
            {
                commandBarDropDownList2.Items.Add(new RadListDataItem(dayNameFormat.ToString(), dayNameFormat));
            }
            commandBarDropDownList2.SelectedIndex = 0;

            // list FirstdayOfWeek members
            foreach (FirstDayOfWeek firstDayOfWeek in Enum.GetValues(typeof(FirstDayOfWeek)))
            {
                commandBarDropDownList3.Items.Add(new RadListDataItem(firstDayOfWeek.ToString(), firstDayOfWeek));
            }
            commandBarDropDownList3.SelectedIndex = 0;
        }

        private void commandBarDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            // show the selected culture and code in the status strip
            RadDropDownListElement element = sender as RadDropDownListElement;
            if (element.SelectedValue != null)
            {
                radCalendar1.Culture = CultureInfo.GetCultureInfo((element.SelectedValue.ToString()));
                radLabelElement1.Text = "Culture: " + element.SelectedText + "   Code: " + element.SelectedValue.ToString();
            }
        }

        // toggle RightToLeft
        private void commandBarToggleButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radCalendar1.RightToLeft = args.ToggleState == ToggleState.On ? RightToLeft.Yes : RightToLeft.No;
        }

        // Select DayNameFormat
        private void commandBarDropDownList2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownListElement element = sender as RadDropDownListElement;
            radCalendar1.DayNameFormat = (DayNameFormat)element.SelectedValue;
        }

        // Select FirstDayOfWeek
        private void commandBarDropDownList3_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownListElement element = sender as RadDropDownListElement;
            if (element.SelectedValue != null)
            {
                radCalendar1.FirstDayOfWeek = (FirstDayOfWeek)element.SelectedValue;
            }
        }

        // Show the selected date in the status strip
        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo((commandBarDropDownList1.SelectedValue.ToString()));
            radLabelElement1.Text = radCalendar1.SelectedDate.ToString(cultureInfo);
        }
    }
}

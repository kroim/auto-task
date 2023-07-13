using System;
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
            // assign New Years as a special day
            RadCalendarDay newYearsDay = new RadCalendarDay(new DateTime(2010, 1, 1));
            radCalendar1.SpecialDays.Add(newYearsDay);
            radCalendar1.SpecialDays[0].Image = imageList1.Images["blackout.ico"];

            // assign template to New Years Eve 
            CheckBox checkbox = new CheckBox();
            checkbox.Text = "Blackout?";
            checkbox.Padding = new Padding(5);
            RadHostItem hostItem = new RadHostItem(checkbox);
            RadCalendarDay newYearsEveDay = new RadCalendarDay(new DateTime(2009, 12, 31));
            radCalendar1.SpecialDays.Add(newYearsEveDay);
            newYearsEveDay.TemplateItem = hostItem;
            

            // recurring dates
            //RadCalendarDay fridays = new RadCalendarDay(new DateTime(2010, 1, 8));
            //fridays.Recurring = RecurringEvents.Week;
            //radCalendar1.SpecialDays.Add(fridays);

            radCalendar1.FocusedDate = newYearsDay.Date;
        }

        private void btnGetFlights_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Selected Date: ");
            builder.Append(radCalendar1.SelectedDate.ToLongDateString());
            builder.Append(Environment.NewLine);
            builder.Append(Environment.NewLine);
            foreach (DateTime dateTime in radCalendar1.SelectedDates)
            {
                builder.Append(dateTime.ToLongDateString());
                builder.Append(Environment.NewLine);
            }
            RadMessageBox.SetThemeName("Aqua");
            RadMessageBox.Show(builder.ToString(), "SelectedDate vs SelectedDates",
              MessageBoxButtons.OK, RadMessageIcon.Info);
        }
        
        private void radCalendar1_ElementRender(object sender, RenderElementEventArgs e)
        {
            // is the Day one of the SpecialDays collection?
            bool isSpecialDay = radCalendar1.SpecialDays.Find(e.Day.Date).Length > 0;
            if (isSpecialDay)
            {
                e.Element.BackColor = Color.FromArgb(105, 181, 218);
                e.Element.BackColor2 = Color.FromArgb(112, 145, 181);
                e.Element.BackColor3 = Color.Blue;
                e.Element.NumberOfColors = 3;
                e.Element.GradientStyle = GradientStyles.OfficeGlassRect;
                e.Element.GradientPercentage = 80;
                e.Element.ForeColor = Color.Transparent;
                e.Element.ToolTipText = "Blackout date";
            }
        }

        private void radCalendar1_SelectionChanging(object sender, SelectionEventArgs e)
        {
            if (e.Dates.Count == 3)
            {
                e.Cancel = true;
                RadMessageBox.SetThemeName("Aqua");
                RadMessageBox.Show("Select no more than three travel dates");
            }
        }

        private void radCalendar1_ViewChanging(object sender, ViewChangingEventArgs e)
        {
            if (e.View.ViewStartDate > radCalendar1.FocusedDate.AddDays(90))
            {
                e.Cancel = true;
                RadMessageBox.SetThemeName("Aqua");
                RadMessageBox.Show("You may not reserve flights more than 90 days in advance");
            }
        }
    }
}

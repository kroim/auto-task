using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Views
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            foreach (SchedulerViewType viewType in Enum.GetValues(typeof(SchedulerViewType)))
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = viewType.ToString();
                item.Value = viewType;
                ddActiveViewType.Items.Add(item);
            }

            foreach (ScaleRange range in Enum.GetValues(typeof(ScaleRange)))
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = range.ToString();
                item.Value = range;
                ddRange.Items.Add(item);
            }

            for (int i = 1; i < 10; i++)
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = i.ToString();
                item.Value = i;
                ddCount.Items.Add(item);
            }
        }

        private void ddActiveViewType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownListElement dropDownList = sender as RadDropDownListElement;
            radScheduler1.ActiveViewType = (SchedulerViewType)(dropDownList.SelectedValue);
        }

        private void ddRange_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownListElement dropDownList = sender as RadDropDownListElement;
            ScaleRange range = (ScaleRange)(dropDownList.SelectedValue);

            // set the appropriate range factor based on the type of view
            switch (radScheduler1.ActiveViewType)
            {
                case SchedulerViewType.Day:
                    (radScheduler1.ActiveView as SchedulerDayView).RangeFactor = range;
                    break;
                case SchedulerViewType.MultiDay:
                    (radScheduler1.ActiveView as SchedulerMultiDayView).RangeFactor = range;
                    break;
                case SchedulerViewType.Week:
                case SchedulerViewType.WorkWeek:
                    (radScheduler1.ActiveView as SchedulerWeekView).RangeFactor = range;
                    break;
            }
        }

        private void ddCount_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownListElement dropDownList = sender as RadDropDownListElement;
            int count = (int)dropDownList.SelectedValue;

            // set the Day or WeekCount based on the current view
            switch (radScheduler1.ActiveViewType)
            {
                case SchedulerViewType.Day:
                    (radScheduler1.ActiveView as SchedulerDayView).DayCount = count;
                    break;
                case SchedulerViewType.MultiDay:
                    (radScheduler1.ActiveView as SchedulerMultiDayView).DayCount = count;
                    break;
                case SchedulerViewType.Month:
                    (radScheduler1.ActiveView as SchedulerMonthView).WeekCount = count;
                    break;
            }
        }

        private void radScheduler1_ActiveViewChanging(object sender, SchedulerViewChangingEventArgs e)
        {
            lblStatus.Text = String.Format("Old: {0}   New: {1}",
              e.OldView.ViewType.ToString(), e.NewView.ViewType.ToString());
        }

    }
}

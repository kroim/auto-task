using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace WindowsFormsApplication1
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            radCalendar1.FocusedDate = new System.DateTime(2011, 02, 01);
            radCalendar1.ShowFooter = true;
            radCalendar1.ClearButton.Visibility = ElementVisibility.Collapsed;
            radCalendar1.TodayButton.Visibility = ElementVisibility.Collapsed;

            // get the footer layout panel 
            DockLayoutPanel layoutPanel =
              radCalendar1.CalendarElement.Children[0].Children[0].Children[0] as DockLayoutPanel;
            // get the updating date and time label and hide that too
            layoutPanel.Children[2].Visibility = ElementVisibility.Collapsed;

            RadRotatorElement rotator = new RadRotatorElement();
            foreach (RadCalendarDay day in radCalendar1.SpecialDays)
            {
                RadButtonElement button = new RadButtonElement();
                button.Text = day.ToolTip;
                button.DisplayStyle = DisplayStyle.Text;
                rotator.Items.Add(button);
            }
            rotator.Interval = 4000;
            rotator.Running = true;

            layoutPanel.Children.Add(rotator);
        }
    }
}

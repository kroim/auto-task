using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls;

namespace FindItem
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
            
            radPageViewPage1.Tag = "simple";
            radPageViewPage2.Tag = "simple";
            radPageViewPage3.Tag = "simple";
            radPageViewPage4.Tag = "advanced";
            radPageViewPage5.Tag = "advanced";
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            //iterating pages
            foreach (RadPageViewPage page in radPageView1.Pages)
            {
                bool isAdvanced = page.Tag.ToString().Equals("advanced");

                page.Item.Visibility = isAdvanced & args.ToggleState == ToggleState.On
                  ? ElementVisibility.Collapsed : ElementVisibility.Visible;
            }

            //finding items
            IEnumerable<RadPageViewPage> advanced = radPageView1.Pages.Where(item => item.Tag.ToString().Equals("advanced"));
            foreach (RadPageViewPage page in advanced)
            {
                page.Item.Visibility = args.ToggleState == ToggleState.On ? ElementVisibility.Collapsed : ElementVisibility.Visible;
            }
        }
    }
}

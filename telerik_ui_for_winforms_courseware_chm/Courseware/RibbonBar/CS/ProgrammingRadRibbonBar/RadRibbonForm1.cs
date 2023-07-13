using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace ProgrammingRadRibbonBar
{
    public partial class RadRibbonForm1 : RadRibbonForm
    {
        public RadRibbonForm1()
        {
            InitializeComponent();
        }

        private void RadRibbonForm1_Load(object sender, EventArgs e)
        {
            //add tab
            RibbonTab tabItem1 = new RibbonTab();
            tabItem1.Text = "Manage";
            radRibbonBar1.CommandTabs.Add(tabItem1);

            //add multiple tabs
            RibbonTab tabItem2 = new RibbonTab();
            RibbonTab tabItem3 = new RibbonTab();
            RibbonTab tabItem4 = new RibbonTab();
            tabItem1.Text = "Write";
            tabItem2.Text = "Layout";
            tabItem3.Text = "Image";
            radRibbonBar1.CommandTabs.AddRange(new RibbonTab[] { tabItem2, tabItem3, tabItem4 });

            //remove specified tab
            radRibbonBar1.CommandTabs.Remove(tabItem1);
            //remove tab at specified index
            radRibbonBar1.CommandTabs.RemoveAt(2);

            //add ribbon bar group
            RadRibbonBarGroup radRibbonBarGroup1 = new RadRibbonBarGroup();
            radRibbonBarGroup1.Text = "Options";
            ((RibbonTab)radRibbonBar1.CommandTabs[0]).Items.Add(radRibbonBarGroup1);

            //add multiple ribbon bar groups
            RadRibbonBarGroup radRibbonBarGroup2 = new RadRibbonBarGroup();
            RadRibbonBarGroup radRibbonBarGroup3 = new RadRibbonBarGroup();
            RadRibbonBarGroup radRibbonBarGroup4 = new RadRibbonBarGroup();
            radRibbonBarGroup2.Text = "Options";
            radRibbonBarGroup3.Text = "Text";
            radRibbonBarGroup4.Text = "Alignment";
            RibbonTab ribbonTab1 = (RibbonTab)radRibbonBar1.CommandTabs[0];
            ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] { radRibbonBarGroup2, radRibbonBarGroup3, radRibbonBarGroup4 });

            //remove speficied tab
            ((RibbonTab)radRibbonBar1.CommandTabs[0]).Items.Remove(radRibbonBarGroup1);

            //remove tab at specified index
            ((RibbonTab)radRibbonBar1.CommandTabs[0]).Items.RemoveAt(2);

            //add buttons
            RadButtonElement radButtonElement1 = new RadButtonElement();
            radButtonElement1.Text = "Button";
            radRibbonBarGroup2.Items.Add(radButtonElement1);

            //add multiple buttons
            RadButtonElement radButtonElement2 = new RadButtonElement();
            RadButtonElement radButtonElement3 = new RadButtonElement();
            radButtonElement2.Text = "Second Button";
            radButtonElement3.Text = "Third Button";
            radRibbonBarGroup2.Items.AddRange(new RadItem[] { radButtonElement2, radButtonElement3 });


            //remove button
            radRibbonBarGroup2.Items.Remove(radButtonElement3);

            //remove button at spcified index
            radRibbonBarGroup2.Items.RemoveAt(1);

            //add button group with buttons
            RadRibbonBarButtonGroup radRibbonBarButtonGroup1 = new RadRibbonBarButtonGroup();
            radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            radRibbonBarButtonGroup1.MinSize = new System.Drawing.Size(22, 22);
            radRibbonBarButtonGroup1.ShowBorder = true;
            RadButtonElement radButtonElement4 = new RadButtonElement();
            RadButtonElement radButtonElement5 = new RadButtonElement();
            radButtonElement4.Text = "Button One";
            radButtonElement5.Text = "Button Two";
            radRibbonBarButtonGroup1.Items.AddRange(new RadItem[] { radButtonElement4, radButtonElement5 });
            radRibbonBarGroup3.Items.Add(radRibbonBarButtonGroup1);
        }  
    }
}

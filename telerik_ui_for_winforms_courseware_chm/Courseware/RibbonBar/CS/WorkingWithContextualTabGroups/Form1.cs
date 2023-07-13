using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkingWithContextualTabGroups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RibbonTab ribbonTab4;
        private Telerik.WinControls.UI.RibbonTab ribbonTab5;
        private Telerik.WinControls.UI.ContextualTabGroup contextualTabGroup1;
        private Telerik.WinControls.UI.ContextualTabGroup contextualTabGroup2;
        
        private void Form1_Load(object sender, EventArgs e)
        {
              // The "this" variable refers to the form that contains the ribbonbar
            // Declare variables for tabs and contextual tab groups

            //Create the tabs
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab4 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab5 = new Telerik.WinControls.UI.RibbonTab();

            ribbonTab1.Text = "Tab one";
            ribbonTab2.Text = "Tab two";
            ribbonTab3.Text = "Tab three";
            ribbonTab4.Text = "Tab four";
            ribbonTab5.Text = "Tab five";

            // Create the contextual tab groups
            this.contextualTabGroup1 = new Telerik.WinControls.UI.ContextualTabGroup();
            this.contextualTabGroup1.Text = "Contextual tab group 1";
            this.contextualTabGroup2 = new Telerik.WinControls.UI.ContextualTabGroup();
            this.contextualTabGroup2.Text = "Contextual tab group 2";



            // Add the command tabs to the ribbon bar's command tabs collection by accessing the
            // ribbon bar's CommandTabs property and using its AddRange method
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.UI.RibbonTab[] { ribbonTab1, ribbonTab2, ribbonTab3, ribbonTab4, ribbonTab5 });

            // Add the contextual tab groups to the ribbon bar's contextual tab groups collection by
            // accessing the ribbon bar's ContextualTabGroups property and using its AddRange method
            this.radRibbonBar1.ContextualTabGroups.AddRange(new Telerik.WinControls.RadItem[] { this.contextualTabGroup1, this.contextualTabGroup2 });

            //Assign some tabs to the contextual tab groups.
            this.contextualTabGroup1.TabItems.Add(this.ribbonTab1);
            this.contextualTabGroup1.TabItems.Add(this.ribbonTab2);
            this.contextualTabGroup2.TabItems.Add(this.ribbonTab3);
            this.contextualTabGroup2.TabItems.Add(this.ribbonTab4);
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Telerik.WinControls;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radWizard1.WelcomeImageLayout = ImageLayout.Center;
            radWizard1.SelectedPageChanged += new Telerik.WinControls.UI.SelectedPageChangedEventHandler(radWizard1_SelectedPageChanged);
            radWizard1.Help += new EventHandler(radWizard1_Help);
            radWizard1.Cancel += new EventHandler(radWizard1_Cancel);
            radWizard1.Finish += new EventHandler(radWizard1_Finish);
        }

        void radWizard1_Finish(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void radWizard1_Cancel(object sender, EventArgs e)
        {
            if (RadMessageBox.Show("Are you sure that you want to stop the installation?", "", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void radWizard1_Help(object sender, EventArgs e)
        {
            Process.Start("http://www.telerik.com");
        }

        void radWizard1_SelectedPageChanged(object sender, Telerik.WinControls.UI.SelectedPageChangedEventArgs e)
        {
            if (e.SelectedPage == wizardPage3)
            {
                radWaitingBar1.StartWaiting();
            }
            else
            {
                radWaitingBar1.StopWaiting();
            }
        }

    
    }
}

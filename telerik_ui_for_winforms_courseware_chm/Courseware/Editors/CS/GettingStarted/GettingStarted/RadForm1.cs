using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Telerik.WinControls.Enumerations;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            this.ThemeName = "Office2007Silver";
            SetTheme(this.Controls);
        }

        // cycle through the controls collection recursively and set the 
        // theme for all rad controls
        private void SetTheme(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is RadControl)
                    (control as RadControl).ThemeName = this.ThemeName;

                if (control.Controls.Count > 0)
                    SetTheme(control.Controls);
            }
        }

        // When the "Gift Wrap" checkbox is unchecked,
        // Disable the "Note" text box and disable it

        private void cbGiftWrap_ToggleStateChanged(object sender,
          Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            tbNote.Enabled = args.ToggleState == ToggleState.On;
            btnChooseColor.Enabled = args.ToggleState == ToggleState.On;
            if (args.ToggleState != ToggleState.On)
                tbNote.Text = String.Empty;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (ValidateControls(this.Controls))
            {
                string caption = "Order Summary";
                string message = "Thank you for your order" +
                  Environment.NewLine +
                  GetFormData(this.Controls);
                RadMessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        private bool ValidateControls(Control.ControlCollection controls)
        {
            return true;
        }

        private string GetFormData(Control.ControlCollection controls)
        {
            return Environment.NewLine + "...summary";
        }
    }
}

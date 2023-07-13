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
using Telerik.WinControls.Primitives;

namespace ValidationWalkthrough
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            // setup initial delivery date
            dtDeliver.Value = Utils.AddBusinessDays(DateTime.Today, (int)seDeliver.Value);

            // configure color dialog
            RadColorDialogForm dialog = (RadColorDialogForm)radColorDialog1.ColorDialogForm;
            dialog.ShowBasicColors = false;
            dialog.ShowCustomColors = false;
            dialog.ShowProfessionalColors = false;
            dialog.ShowHEXColorValue = false;
            dialog.ShowCustomColors = false;
            dialog.AllowColorPickFromScreen = false;
            dialog.WebTabHeading = "Named Colors";
            dialog.ActiveMode = ColorPickerActiveMode.Web;
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

        // iterate the controls and verify the text entry has data
        // and the date time picker has a week day selected.
        private bool ValidateControls(Control.ControlCollection controls)
        {
            bool isValid = true;
            foreach (Control control in controls)
            {
                // clear old errors
                errorProvider1.SetError(control, "");

                if (IsEditorControl(control))
                {

                    object value = GetControlValue(control as RadControl);
                    if ((value is DateTime) && (Utils.IsWeekend((DateTime)value)))
                    {
                        errorProvider1.SetError(control, "Please enter a weekday date to " +
                          control.Tag.ToString());
                        isValid = false;
                    }
                    else if (value.ToString().Equals(String.Empty))
                    {
                        errorProvider1.SetError(control, "Please enter " + control.Tag.ToString());
                        isValid = false;
                    }
                }

                // recurse into child controls of this control
                // so that we get items on the group panels.
                if (control.Controls.Count > 0)
                    if (!ValidateControls(control.Controls))
                        isValid = false;
            }
            return isValid;
        }

        // retrieve the editor controls,
        // get their values, build and return a summary string.
        private string GetFormData(Control.ControlCollection controls)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Control control in controls)
            {
                if (IsEditorControl(control))
                {
                    object value = GetControlValue(control as RadControl);

                    if ((value != null) && (!value.ToString().Equals(String.Empty)))
                    {
                        builder.Append(Environment.NewLine);
                        builder.Append(control.Tag.ToString());
                        builder.Append(": ");
                        builder.Append(value);
                    }
                }

                if (control.Controls.Count > 0)
                    builder.Append(GetFormData(control.Controls));
            }
            return builder.ToString();
        }

        // Based on the spin edit value, add business days to the date time picker.    
        private void seDeliver_ValueChanged(object sender, EventArgs e)
        {
            dtDeliver.Value = Utils.AddBusinessDays(DateTime.Today, (int)seDeliver.Value);
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            // get the fill and text primitives for the button
            FillPrimitive fillPrimitive =
              btnChooseColor.RootElement.Children[0].Children[0] as FillPrimitive;
            TextPrimitive textPrimitive =
              btnChooseColor.RootElement.Children[0].Children[1].Children[1] as TextPrimitive;

            // retrieve the current button color
            radColorDialog1.ColorDialogForm.OldColor = fillPrimitive.BackColor;
            radColorDialog1.ColorDialogForm.SelectedColor = fillPrimitive.BackColor;

            // retrieve the user selected color and calculate a contrasting color,
            // then set the BackColor properties to succesively more transparent 
            // shades of the primary color and set the text to the contrasting color.
            if (radColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = radColorDialog1.SelectedColor;
                textPrimitive.ForeColor = Utils.GetContrastingColor(color);
                fillPrimitive.BackColor = color;
                fillPrimitive.BackColor2 = Color.FromArgb(200, color);
                fillPrimitive.BackColor3 = Color.FromArgb(100, color);
                fillPrimitive.BackColor4 = Color.FromArgb(50, color);
            }
        }

        // True if given control is enabled,
        // is on a group box and is a textbox base,
        // date time picker or radbutton.
        private bool IsEditorControl(Control control)
        {
            if (!control.Enabled)
                return false;

            // only get input from controls within a groupbox
            if (!(control.Parent is GroupBox))
                return false;

            return
              control is RadTextBoxBase ||
              control is RadDateTimePicker ||
              control is RadButton;
        }

        // return the appropriate vaue property for the RadControl
        private object GetControlValue(RadControl control)
        {
            object value = null;

            if (control is RadTextBox)
                value = (control as RadTextBox).Text;
            else if (control is RadMaskedEditBox)
                value = (control as RadMaskedEditBox).Value.ToString();
            else if (control is RadDateTimePicker)
                value = (control as RadDateTimePicker).Value;
            else if (control is RadCheckBox)
                value = (control as RadCheckBox).Checked.ToString();
            else if (control is RadButton)
            {
                FillPrimitive buttonPrimitive =
                  (control as RadButton).RootElement.Children[0].Children[0] as FillPrimitive;
                value = Utils.GetKnownColorName(buttonPrimitive.BackColor);
            }
            return value;
        }

        private void dtDeliver_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (Utils.IsWeekend((sender as RadDateTimePicker).Value))
            {
                error = "Please enter a weekday date for " + (sender as Control).Tag.ToString();
            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void RadForm1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!ValidateControls(this.Controls))
            {
                RadMessageBox.SetThemeName("Office2007Silver");
                DialogResult result = RadMessageBox.Show(
                  "Please correct errors or press Cancel to close the window.", "Input errors",
                  MessageBoxButtons.OKCancel, RadMessageIcon.Error);
                // Cancel == true prevents the form from closing
                e.Cancel = result == DialogResult.OK;
            }
        }
    }
}

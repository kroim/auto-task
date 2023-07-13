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

namespace ColorDialogWalkthrough
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "Office2007Silver";

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

        private bool ValidateControls(Control.ControlCollection controls)
        {
            return true;
        }

        private string GetFormData(Control.ControlCollection controls)
        {
            return Environment.NewLine + "...summary";
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
    }
}

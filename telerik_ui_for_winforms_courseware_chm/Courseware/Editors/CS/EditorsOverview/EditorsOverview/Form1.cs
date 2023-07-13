using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls;

using System.Globalization;

namespace EditorsInput
{
  public partial class gbMasks : RadForm
  {
    public gbMasks()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // set multiple lines of text using several different approaches
      tbMultiLine.Lines = new string[3] 
        { "It was the best of times,", 
          "it was the worst of times,", 
          "it was the age of wisdom..."};

      tbMultiLine.Text =
        "It was the best of times," + Environment.NewLine +
        "it was the worst of times," + Environment.NewLine +
        "it was the age of wisdom...";

      tbMultiLine.Text =
      "It was the best of times,\r\nit was the worst of times,\r\nit was the age of wisdom...";

      // traverse the element tree and locate the text box border. Makes the border invisible.
      (tbMultiLine.TextBoxElement.Children[2] as BorderPrimitive).Visibility = ElementVisibility.Collapsed;

      // setup an auto complete source for a RadTextBox
      tbContainer.AutoCompleteSource = AutoCompleteSource.CustomSource;
      AutoCompleteStringCollection containers = new AutoCompleteStringCollection();
      containers.Add("Box");
      containers.Add("Bundle");
      containers.Add("Pallet");
      containers.Add("Carton");
      tbContainer.AutoCompleteCustomSource = containers;
      // allow the auto completions to be shown in a list and automaticaly appened 
      // during typing
      tbContainer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

      // display a message when there is no entry
      tbContainer.Text = String.Empty;
      tbContainer.NullText = "Enter a container name";

      // load a RadComboBox with MaskType enum memembers
      foreach (MaskType maskType in Enum.GetValues(typeof(MaskType)))
      {
        cbMaskType.Items.Add(new RadListDataItem(maskType.ToString(), maskType));
      }

      // load an assortment of masks to a RadComboBox
      string[] masks = new string[] { 
        "#", "L", "a", "c", "d", "f", "p", "D", "F", "g", "G", "m", "r", "s", "t", "T" };
      foreach (string mask in masks)
      {
          cbMasks.Items.Add(new RadListDataItem(mask, mask));
      }

      // set the initial combo box item selected 
      cbMasks.SelectedIndex = 0;
      cbMaskType.SelectedIndex = 0;

      // set the initial date time picker value and bounds
      radDateTimePicker1.MinDate = DateTime.Today.AddDays(-1);
      radDateTimePicker1.MaxDate = DateTime.Today.AddDays(7);
      radDateTimePicker1.Value = DateTime.Today;

      // hook up a ToggleStateChanged event handler to a date time picker checkbox
      RadCheckBoxElement checkBox =
        radDateTimePicker1.DateTimePickerElement.Children[1].Children[0] as RadCheckBoxElement;
      checkBox.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
      
      // apply a custom format to a date time picker
      radDateTimePicker1.Format = DateTimePickerFormat.Custom;
      radDateTimePicker1.CustomFormat = "yyyy MMMM dd h:m:s tt";

    }

    void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
    {
      RadMessageBox.Show(args.ToggleState.ToString());
    }

    private void tbContainer_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
    {
      btnUseContainer.Enabled = e.NewValue.Length > 0;
    }

    private void tbContainer_TextChanged(object sender, EventArgs e)
    {
      btnUseContainer.Text = "Use " + (sender as RadTextBox).Text + " container";
    }

    private void meDemo_ValueChanged(object sender, EventArgs e)
    {
      lblValue.Text = this.meDemo.Value.ToString();
    }

    private void cbMaskType_SelectedValueChanged(object sender, EventArgs e)
    {
        meDemo.MaskType = (MaskType)(sender as RadDropDownList).SelectedValue;
    }

    private void cbMasks_SelectedValueChanged(object sender, EventArgs e)
    {
        meDemo.Mask = (sender as RadDropDownList).SelectedText;
    }

    private void btnAddMask_Click(object sender, EventArgs e)
    {
      // if the current text in the combo box is not already
      // in the list, add it.
      if (!cbMasks.Items.Any(ri => ri.Text.Equals(cbMasks.Text)))
      {
          cbMasks.Items.Add(new RadListDataItem(cbMasks.Text));
      }
    }

    private void btnChangeColor_Click(object sender, EventArgs e)
    {
      // set the color dialog initial color to the panel background color, 
      // show the color dialog and if the user selects a color, 
      // assign it to the panel.
      radColorDialog1.SelectedColor = pnlColor.BackColor;
      if (radColorDialog1.ShowDialog() == DialogResult.OK)
      {
        pnlColor.BackColor = radColorDialog1.SelectedColor;
      }
    }

    private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
    {
      lblSpin.Text = radSpinEditor1.Value.ToString();
      radProgressBar1.Value1 = (int)radSpinEditor1.Value;
    }

    private void radSpinEditor1_ValueChanging(object sender, ValueChangingEventArgs e)
    {
      e.Cancel = Convert.ToDecimal(e.NewValue) > Convert.ToDecimal(e.OldValue) * 2;
    }

  }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;

namespace GettingStarted
{
    public partial class Form1 : ShapedForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "RadRibbonBar";
            
        }

        private void tbContent_SelectionChanged(object sender, EventArgs e)
        {
            cbBold.IsChecked = tbContent.SelectionFont.Bold;
            cbItalic.IsChecked = tbContent.SelectionFont.Italic;
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            tbContent.Clear();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbContent.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbContent.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName("Office2007Black");
            RadMessageBox.Show(" By " + Environment.UserName + ", "
              + DateTime.Today.ToLongDateString(), "About RadMenu Demo");
        }

        private void miCut_Click(object sender, EventArgs e)
        {
            tbContent.Cut();
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            tbContent.Copy();
        }

        private void miPaste_Click(object sender, EventArgs e)
        {
            tbContent.Paste();
        }

        private void radRibbonBar1_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBold_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                tbContent.SelectionFont =
                  new Font(tbContent.SelectionFont,
                   tbContent.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                tbContent.SelectionFont =
                  new Font(tbContent.SelectionFont,
                    tbContent.SelectionFont.Style & ~FontStyle.Bold);
            }
        }

        private void cbItalic_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                tbContent.SelectionFont =
                  new Font(tbContent.SelectionFont,
                   tbContent.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                tbContent.SelectionFont =
                  new Font(tbContent.SelectionFont,
                    tbContent.SelectionFont.Style & ~FontStyle.Italic);
            }
        }
    }
}

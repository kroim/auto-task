using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRadForm_Click(object sender, EventArgs e)
        {
            RadForm1 radForm1 = new RadForm1();
            radForm1.Activated += new EventHandler(formActivated);
            radForm1.Show();
        }

        private void btnShapedForm_Click(object sender, EventArgs e)
        {
            ShapedForm1 shapedForm1 = new ShapedForm1();
            RoundRectShape shape = new RoundRectShape();
            shape.Radius = 20;
            shapedForm1.Shape = shape;
            shapedForm1.Activated += new EventHandler(formActivated);
            shapedForm1.Show();
        }

        private void btnRadRibbonForm_Click(object sender, EventArgs e)
        {
            RadRibbonForm1 radRibbonForm1 = new RadRibbonForm1();
            radRibbonForm1.Activated += formActivated;
            radRibbonForm1.Show();
        }

        private void btnRadAboutBox_Click(object sender, EventArgs e)
        {
            RadAboutBox1 radAboutBox1 = new RadAboutBox1();
            radAboutBox1.Activated += new EventHandler(formActivated);
            radAboutBox1.Show();
        }

        void formActivated(object sender, EventArgs e)
        {
            lblStatus.Text = "The " + (sender as Control).Name + " form is active";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2007Silver";
        }

        private void btnRadMessageBox_Click(object sender, EventArgs e)
        {
            RadMessageLocalizationProvider.CurrentProvider = new MyMessageLocalizationProvider();

            DialogResult result = RadMessageBox.Show(
              "Go online to register?",
              "Registration",
              MessageBoxButtons.YesNo,
              RadMessageIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                // do something...
            }
        }
    }

    public class MyMessageLocalizationProvider : RadMessageLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMessageStringID.AbortButton:
                    return "Hold it!";
                case RadMessageStringID.CancelButton:
                    return "Lets not";
                case RadMessageStringID.IgnoreButton:
                    return "Forget it";
                case RadMessageStringID.NoButton:
                    return "Nope";
                case RadMessageStringID.OKButton:
                    return "Allright";
                case RadMessageStringID.RetryButton:
                    return "Again Please";
                case RadMessageStringID.YesButton:
                    return "Yup";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}

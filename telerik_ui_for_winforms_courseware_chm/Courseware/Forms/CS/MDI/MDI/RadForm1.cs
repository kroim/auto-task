using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MDI
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            // disable the delete button - there are no child forms
            this.btnDelete.Enabled = false;
            // load drop down list with theme names
            ThemeList themes =
               ThemeResolutionService.GetAvailableThemes(this);
            foreach (Theme theme in themes)
            {
                commandBarDropDownList1.Items.Add(new RadListDataItem(theme.ThemeName));
            }
            commandBarDropDownList1.SelectedIndex = 0;

            this.MdiChildActivate += new EventHandler(RadForm1_MdiChildActivate);
        }

        void RadForm1_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.lblStatus.Text = this.Text;

                //for shaped form uncomment the next line and comment the above one
                //this.lblStatus.Text = ((RadTitleBar)  (this.ActiveMdiChild as ShapedForm1).Controls["radTitleBar1"]).Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // close the active mdi child form
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Create a new mdi child form, using the current theme
            RadForm child = new RadForm();

            //to use the shaped forms commet the line above and uncomment the following two lines
            //ShapedForm1 child = new ShapedForm1();
            //(child.Controls["radTitleBar1"] as RadTitleBar).ThemeName = commandBarDropDownList1.SelectedText;

            child.MdiParent = this;
            child.ThemeName = commandBarDropDownList1.SelectedText;
            child.Text = "Child Form - " + commandBarDropDownList1.SelectedText;
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.Show();

            // enable the delete button
            this.btnDelete.Enabled = true;
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if there are child forms, enable the delete button
            // add one to the count - the child form being closed still exists at this point
            this.btnDelete.Enabled = this.MdiChildren.Length > 1;
        }
    }
}

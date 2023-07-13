using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace Programming
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("Akina", "Yamada", "ykiko@gmail.com"));
            contacts.Add(new Contact("Bob", "Coffee", "bob@mymail.com"));
            contacts.Add(new Contact("Ajit", "Singh", "ajitsingh@yahoo.com"));
            contacts.Add(new Contact("Chavdar", "Ivanov", "civanov@gmail.com"));

            radMultiColumnComboBox1.DataSource = contacts;
            radMultiColumnComboBox1.DisplayMember = "First";
            radMultiColumnComboBox1.ValueMember = "Email";

            RadMultiColumnComboBoxElement combo = radMultiColumnComboBox1.MultiColumnComboBoxElement;
            combo.DropDownWidth = radMultiColumnComboBox1.Width;
            combo.ArrowButtonMinWidth = 100;

            combo.EditorControl.MasterTemplate.AutoSizeColumnsMode =
              GridViewAutoSizeColumnsMode.Fill;

            radMultiColumnComboBox1.AutoFilter = true;
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = radMultiColumnComboBox1.DisplayMember;
            filter.Operator = FilterOperator.StartsWith;
            combo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
        }

        private void btnShowPopup_Click(object sender, EventArgs e)
        {
            RadMultiColumnComboBoxElement combo = radMultiColumnComboBox1.MultiColumnComboBoxElement;
            combo.ShowPopup();
        }

        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewDataRowInfo rowInfo = (sender as RadMultiColumnComboBox).SelectedItem as GridViewDataRowInfo;
            Contact contact = rowInfo.DataBoundItem as Contact;
            if (contact != null)
            {
                lblSelected.Text = contact.First + " " + contact.Last + " " + contact.Email;
            }
        }
    }
}

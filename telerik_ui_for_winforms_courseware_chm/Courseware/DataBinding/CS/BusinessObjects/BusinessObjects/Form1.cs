using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BusinessObjects
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products = new BindingList<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // assign the datasource the Product type
            bindingSource1.DataSource = this.products;
            
            // bind the list control
            lbProducts.DisplayMember = "Description";
            lbProducts.ValueMember = "ID";
            lbProducts.DataSource = bindingSource1;

            // bind text box and spin editor
            tbDescription.DataBindings.Add("Text", bindingSource1, "Description");
            seID.DataBindings.Add("Value", bindingSource1, "ID");

            this.bindingNavigator1.AddNewItem.Click += bindingNavigatorAddNewItem_Click;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // update the UI
            bindingSource1.ResetBindings(false);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // look through existing products and get the maximum ID.
            int maxID = 0;
            foreach (Product product in this.products)
            {
                maxID = Math.Max(maxID, product.ID);
            }

            Product lastProduct = this.products[this.products.Count - 1];
            lastProduct.ID = ++maxID;
            lastProduct.Description = "New Product " + maxID.ToString();
        }
    }
}

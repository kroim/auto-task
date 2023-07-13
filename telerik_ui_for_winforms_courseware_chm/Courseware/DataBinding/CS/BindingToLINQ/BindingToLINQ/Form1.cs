using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace BindingToLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<Product> products = new BindingList<Product>();
            products.Add(new Product(1, "Coffee", 1.40));
            products.Add(new Product(2, "Latte", 2.40));
            products.Add(new Product(3, "Mocha", 2.70));
            products.Add(new Product(4, "Expresso", 2.50));
            products.Add(new Product(5, "Tea", 1.30));
            products.Add(new Product(6, "Chai", 1.50));
            products.Add(new Product(7, "Cafe au Lait", 1.50));

            IEnumerable<Product> productQuery = from product in products
                                                where product.Description.StartsWith("C")
                                                where product.Price > 1.49
                                                orderby product.Description
                                                select product;

            radListControl1.DataSource = new BindingSource(productQuery, "");
            radListControl1.DisplayMember = "Description";
            radListControl1.ValueMember = "ID";
        }
    }
}

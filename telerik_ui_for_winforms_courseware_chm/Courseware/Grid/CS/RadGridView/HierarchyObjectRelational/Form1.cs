using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HierarchyObjectRelational
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities entities = new NorthwindEntities();
            var query = from suppliers in entities.Suppliers.Include("Products") select suppliers;
            
            this.radGridView1.DataSource = query.ToList();
            this.radGridView1.AutoGenerateHierarchy = true;
        }
    }
}
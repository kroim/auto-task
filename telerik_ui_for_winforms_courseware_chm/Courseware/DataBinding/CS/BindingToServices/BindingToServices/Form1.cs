using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BindingToServices.ServiceReference1;

namespace BindingToServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            radListControl1.DataSource = client.GetList();
            radListControl1.DisplayMember = "StringValue";
        }
    }
}

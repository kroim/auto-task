using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingDock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = "xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radDock1.LoadFromXml(dialog.FileName);
                lblStatus.Text = "Loaded layout " + dialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radDock1.SaveToXml(dialog.FileName);
                lblStatus.Text = "Saved layout as " + dialog.FileName;
            }
        }

        private void btnLayout_Click(object sender, EventArgs e)
        {
            toolWindow1.Close();
            toolWindow3.Close();
            toolWindow4.Close();
            lblStatus.Text = "Layout changed";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.txt,*.rtf|*.txt;*.rtf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                if (fileName.Length > 0)
                {
                    richTextBox1.LoadFile(fileName, GetStreamType(fileName));
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.txt,*.rtf|*.txt;*.rtf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                richTextBox1.SaveFile(fileName, GetStreamType(dialog.FileName));
            }
        }

        private RichTextBoxStreamType GetStreamType(string fileName)
        {
            return fileName.EndsWith("rtf") ?
                RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
        }

    }
}

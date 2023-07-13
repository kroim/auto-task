using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace Introduction
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicCollectionDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicCollectionDataSet.Albums);
            ThemeResolutionService.ApplicationThemeName = "Desert";
        }
    }
}

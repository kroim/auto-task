using System;
using System.Data;
using Telerik.WinControls.UI;

namespace Databinding
{
    public partial class XMLBinding : RadForm
    {
        public XMLBinding()
        {
            InitializeComponent();
        }

        private void XMLBinding_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("toc.xml");
            this.radTreeView1.DataMember = "item";
            this.radTreeView1.DisplayMember = "title";
            this.radTreeView1.ChildMember = "id";
            this.radTreeView1.ParentMember = "parentId";
            this.radTreeView1.DataSource = dataSet;
        }
    }
}

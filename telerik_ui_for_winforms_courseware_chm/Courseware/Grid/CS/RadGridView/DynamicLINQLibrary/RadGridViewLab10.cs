using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace _10_DynamicLINQLibrary
{
    public partial class RadGridViewLab10 : Form
    {
        public RadGridViewLab10()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.BeginUpdate();
            IQueryable queryable = new SalesOrderHeaderDataClassDataContext().SalesOrderHeaders.AsQueryable();
            queryable = queryable.OrderBy(String.Format("{0} {1}",
            cbField.Text, cbSortType.Text));
            radGridView1.DataSource =
            queryable.Take(Convert.ToInt32(numRecords.Value));
            this.radGridView1.TableElement.EndUpdate(true);
        }
    }
}

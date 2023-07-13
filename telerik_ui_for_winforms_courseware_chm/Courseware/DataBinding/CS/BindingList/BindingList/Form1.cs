using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BindingList
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        // BindingList to contain list of MyObject
        private BindingList<MyObject> _myObjects;

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Desert";

            // instantiate _myObjects and assign to gridview datasource
            _myObjects = new BindingList<MyObject>();
            radGridView1.DataSource = _myObjects;

            radGridView1.Columns[0].Width = 150;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // newly added MyObject shows up automatically in the grid
            _myObjects.Add(new MyObject());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // updated MyObject TimeStamp property shows up automatically in the grid
            if (radGridView1.CurrentRow != null)
            {
                MyObject currentObject = radGridView1.CurrentRow.DataBoundItem as MyObject;
                currentObject.TimeStamp = DateTime.Now;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // deleted MyObject displays automatically in the grid
            if (radGridView1.CurrentRow != null)
            {
                MyObject currentObject = radGridView1.CurrentRow.DataBoundItem as MyObject;
                _myObjects.Remove(currentObject);
            }
        }
    }

    // MyObject implements INotifyPropertyChanged. 
    // The object has a single property "TimeStamp". When
    // TimeStamp is modified, PropertyChanged is fired
    public class MyObject : INotifyPropertyChanged
    {
        public MyObject()
        {
            _timeStamp = DateTime.Now;
        }

        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }
            set
            {
                _timeStamp = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TimeStamp"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

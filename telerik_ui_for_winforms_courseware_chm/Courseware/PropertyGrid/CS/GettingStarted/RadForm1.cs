using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            Dog myDog = new Dog();
            myDog.Name = "Lassie";
            myDog.Age = 4;
            myDog.Birthday = new DateTime(2007, 5, 4);
            myDog.Gender = "Male";
            myDog.Homeless = false;
            myDog.Weight = 21;

            radPropertyGrid1.SelectedObject = myDog;
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Gender{ get; set; }
        public bool Homeless { get; set; }
        public DateTime Birthday { get; set; }
        private string OwnerName { get; set; }
    }
}

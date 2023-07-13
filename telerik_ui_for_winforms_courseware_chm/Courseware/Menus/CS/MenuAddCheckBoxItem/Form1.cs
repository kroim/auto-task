using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace MenuAddCheckBoxItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomCheckMenuItem checkBoxItem = new CustomCheckMenuItem();
            checkBoxItem.Text = "Check Box";
            checkBoxItem.ToggleStateChanged += new StateChangedEventHandler(checkBoxItem_ToggleStateChanged);
            radMenuItem1.Items.Add(checkBoxItem);
            
        }

        void checkBoxItem_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RadMessageBox.Show("Check box state has changed to " + args.ToggleState);
        }
    }

    public class CustomCheckMenuItem : RadMenuItemBase
    {
        private RadCheckBoxElement checkBoxElement;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            checkBoxElement = new RadCheckBoxElement();
            checkBoxElement.Padding = new Padding(20, 0, 0, 0);
            checkBoxElement.CheckMarkPrimitive.Margin = new Padding(0, 0, 5, 0);
            this.Children.Add(checkBoxElement);
        }

        public event StateChangedEventHandler ToggleStateChanged
        {
            add
            {
                checkBoxElement.ToggleStateChanged += value;
            }
            remove
            {
                checkBoxElement.ToggleStateChanged -= value;
            }
        }

        public override string Text
        {
            get
            {
                return checkBoxElement.Text;
            }
            set
            {
                checkBoxElement.Text = value;
            }
        }
    }
}

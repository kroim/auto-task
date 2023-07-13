using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layout;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;

namespace AddingElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a stack panel to contain the title and bullet points
            StackLayoutPanel layoutPanel = new StackLayoutPanel();
            layoutPanel.Orientation = Orientation.Vertical;
            RadLabelElement label = new RadLabelElement();

            // create the "title"
            label.Text = "Safety Checklist";
            label.Padding = new Padding(5, 10, 0, 0);

            // add the title and bullet points
            layoutPanel.Children.Add(label);
            layoutPanel.Children.Add(GetBulletPoint("Smoke detectors"));
            layoutPanel.Children.Add(GetBulletPoint("Ground-fault circuit interrupters"));
            layoutPanel.Children.Add(GetBulletPoint("Fire retardant roofing materials"));

            // add the layout panel element to the panel's children
            radPanel1.RootElement.Children.Add(layoutPanel);
        }

        private StackLayoutPanel GetBulletPoint(string text)
        {
            // create a layout panel for a single "bullet point"
            StackLayoutPanel layoutPanel = new StackLayoutPanel();
            layoutPanel.Orientation = Orientation.Horizontal;
            layoutPanel.Margin = new Padding(10, 10, 0, 0);

            // add the "bullet point" graphic and add to the layout panel
            ArrowPrimitive arrowPrimitive = new ArrowPrimitive();
            arrowPrimitive.Direction = Telerik.WinControls.ArrowDirection.Right;
            arrowPrimitive.Margin = new Padding(0, 0, 5, 0);
            arrowPrimitive.ForeColor = Color.Maroon;
            layoutPanel.Children.Add(arrowPrimitive);

            // add the text for the bullet point and add to the layout panel
            TextPrimitive textPrimitive = new TextPrimitive();
            textPrimitive.Text = text;
            layoutPanel.Children.Add(textPrimitive);

            return layoutPanel;
        }
    }
}

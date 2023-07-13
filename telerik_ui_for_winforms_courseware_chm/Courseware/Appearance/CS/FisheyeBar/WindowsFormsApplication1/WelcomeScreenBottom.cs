using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Telerik.QuickStart.WinControls
{
    public partial class WelcomeScreenBottom : UserControl
    {
        public WelcomeScreenBottom()
        {
            InitializeComponent();
        }

        private void WelcomeScreenBottom_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;

            SetChildrenNotifyONMouseInput(this.radStackItemsPanelElement2);
            SetChildrenNotifyONMouseInput(this.radStackItemsPanelElement3);
            SetChildrenNotifyONMouseInput(this.radStackItemsPanelElement4);
            SetChildrenNotifyONMouseInput(this.radStackItemsPanelElement5);

            this.radStackItemsPanelElement2.AddBehavior(new WelcomeScreenMouseOverBehavior());
            this.radStackItemsPanelElement3.AddBehavior(new WelcomeScreenMouseOverBehavior());
            this.radStackItemsPanelElement4.AddBehavior(new WelcomeScreenMouseOverBehavior());
            this.radStackItemsPanelElement5.AddBehavior(new WelcomeScreenMouseOverBehavior());
        }

        private void SetChildrenNotifyONMouseInput(RadElement item)
        {
            foreach(RadElement childItem in item.Children)
            {
                childItem.NotifyParentOnMouseInput = true;
                childItem.ShouldHandleMouseInput = false;
                SetChildrenNotifyONMouseInput(childItem);
            }
        }

        private void radStackItemsPanelElement2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.telerik.com/products/winforms.aspx");
        }

        private void radStackItemsPanelElement3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.telerik.com/products/winforms/sample-applications.aspx");
        }

        private void radStackItemsPanelElement4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.telerik.com/products/winforms/tools.aspx");
        }

        private void radStackItemsPanelElement5_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.telerik.com/products/winforms/whats-new.aspx");
        }
    }

    /// <summary>
    /// Behavior class defining the OnMouseOver behavior of the BubbleBar
    /// </summary>
    public class WelcomeScreenMouseOverBehavior : PropertyChangeBehavior
    {
        public WelcomeScreenMouseOverBehavior()
            : base(RadItem.IsMouseOverProperty)
        {
        }

        private Cursor oldCursor = null;

        public override void OnPropertyChange(RadElement element, RadPropertyChangedEventArgs e)
        {
            foreach (RadElement childItem in element.Parent.Children)
            {
                RadItem item = childItem as RadItem;
                if (item != null)
                {
                    AnimatedPropertySetting animation;
                    SizeF scale;

                    if ((bool)e.NewValue == false)
                    {
                        scale = new SizeF(1F, 1F);
                        if (this.oldCursor != null && element.ElementTree != null)
                        {
                            element.ElementTree.Control.Cursor = this.oldCursor;
                        }
                    }
                    else
                    {
                        scale = item == element ? new SizeF(1.1F, 1.1F) : new SizeF(.9F, .9F);
                        if (element.ElementTree != null)
                        {
                            this.oldCursor = element.ElementTree.Control.Cursor;
                            element.ElementTree.Control.Cursor = Cursors.Hand;
                        }
                    }

                    animation = new AnimatedPropertySetting(RadElement.ScaleTransformProperty, scale, 10, 33);
                    animation.SkipToEndValueOnReplace = false;
                    animation.ApplyValue(item);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;

namespace Telerik.QuickStart.WinControls
{
    public class RadStackItemsPanelElement : RadItem
    {
        private RadItemOwnerCollection items;
        private StackLayoutPanel stackLayout;

        public RadStackItemsPanelElement()
        {
            this.NotifyParentOnMouseInput = false;
            this.ShouldHandleMouseInput = true;
        }

        [RadEditItemsAction]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RadItemOwnerCollection Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new RadItemOwnerCollection();
                    this.items.Owner = this.StackLayout;
                }

                return items;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public StackLayoutPanel StackLayout
        {
            get
            {
                return stackLayout;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [RefreshProperties(RefreshProperties.All)]
        public Orientation StackOrientation
        {
            get
            {
                return this.StackLayout.Orientation;
            }
            set
            {
                this.StackLayout.Orientation = value;
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.stackLayout = new StackLayoutPanel();

            this.Children.Add(this.StackLayout);
        }
    }
}

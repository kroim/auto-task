using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;

namespace Telerik.QuickStart.WinControls
{
    public class RadStackItemsPanel : RadControl
    {
        private RadStackItemsPanelElement stackPanelElement;

        public RadStackItemsPanel()
        {
            this.UseNewLayoutSystem = true;
        }

        protected override void CreateChildItems(RadElement parent)
        {
            base.CreateChildItems(parent);

            stackPanelElement = new RadStackItemsPanelElement();
            stackPanelElement.SerializeElement = false;

            parent.Children.Add(stackPanelElement);
        }

        [RadEditItemsAction]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RadItemOwnerCollection Items
        {
            get
            {
                return this.PanelElement.Items;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RadStackItemsPanelElement PanelElement
        {
            get
            {
                return this.stackPanelElement;
            }
        }
    }
}

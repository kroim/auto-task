using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace AddingControlsToElements
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            radListControl1.Items.Add(new RadListDataItem("Item 1"));
            radListControl1.Items.Add(new RadListDataItem("Item 2"));
            radListControl1.Items.Add(new RadListDataItem("Item 3"));
       
            radListControl1.CreatingVisualListItem += new CreatingVisualListItemEventHandler(radListControl1_CreatingVisualListItem);
            radListControl1.VisualItemFormatting += new VisualListItemFormattingEventHandler(radListControl1_VisualItemFormatting);
        }
       
        void radListControl1_CreatingVisualListItem(object sender, CreatingVisualListItemEventArgs args)
        {
            //make the items autosize 
            radListControl1.AutoSizeItems = true;

            // create and configure the groupbox
            GroupBox groupBox = new GroupBox();

            // create the RadHostItem with the groupbox as hosted control
            RadHostItem host = new RadHostItem(groupBox);
          
            // add host item to the list box item
            RadListVisualItem visualItem = new RadListVisualItem();
            visualItem.Children.Insert(0, host);
            visualItem.Padding = new Padding(50);
            args.VisualItem = visualItem;
        }

        void radListControl1_VisualItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            //get the host item from the visual item childred collection
            RadHostItem hostItem = ((RadHostItem)args.VisualItem.Children[0]);
            //get the group box which is hosted by the host item
            GroupBox groupBox = (GroupBox)hostItem.HostedControl;
            //set the text of the group box to eqals the data item text
            groupBox.Text = args.VisualItem.Data.Text;
            //remove the visual item default text
            args.VisualItem.Text = "";
        }
    }
}

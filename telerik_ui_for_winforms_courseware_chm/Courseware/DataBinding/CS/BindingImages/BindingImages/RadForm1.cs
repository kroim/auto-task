using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.albumsTableAdapter.Fill(this.musicCollectionDataSet.Albums);
        }

        private void radListControl1_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            // retrieve the data row that was bound
            MusicCollectionDataSet.AlbumsRow row = ((args.NewItem.DataBoundItem as DataRowView).Row as MusicCollectionDataSet.AlbumsRow);

            // retrieve the item that was bound to and set properties
            RadListDataItem item = args.NewItem as RadListDataItem;
            //item.VisualItem.Padding = new Padding(5);
            item.TextImageRelation = TextImageRelation.ImageBeforeText;
            
            // assign the image as a thumbnail
            item.Image = GetImageFromData(row.Image).GetThumbnailImage(64, 64, null, new IntPtr());
        }
       
        // return true if the byte array has an OLE DB header
        private bool HasOleContainerHeader(byte[] imageByteArray)
        {
            const byte OleByte0 = 21;
            const byte OleByte1 = 28;
            return (imageByteArray[0] == OleByte0) && (imageByteArray[1] == OleByte1);
        }

        // convert the image byte array to a memory stream, then a bitmap 
        private Image GetImageFromData(byte[] imageData)
        {
            const int OleHeaderLength = 78;
            MemoryStream memoryStream = new MemoryStream();

            // if the byte array has a OLE DB header, leave the header out of the copy
            if (HasOleContainerHeader(imageData))
            {
                memoryStream.Write(imageData, OleHeaderLength, imageData.Length - OleHeaderLength);
            }
            else
            {
                memoryStream.Write(imageData, 0, imageData.Length);
            }

            // convert to Bitmap/Image
            return new Bitmap(memoryStream);
        }

      
    }
}

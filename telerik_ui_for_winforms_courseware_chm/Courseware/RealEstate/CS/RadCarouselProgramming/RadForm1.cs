using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Xml;
using Telerik.WinControls;

namespace RadCarouselProgramming
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            radCarousel1.VisibleItemCount = 5;

            XmlTextReader reader = new XmlTextReader("http://silverlight.net/blogs/MainFeed.aspx");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);

            // get just the top three links
            List<DataRow> topRows = new List<DataRow>();
            for (int i = 0; i < radCarousel1.VisibleItemCount; i++)
            {
                topRows.Add(ds.Tables["item"].Rows[i]);
            }

            radCarousel1.DataSource = topRows;
        }

        private void radCarousel1_NewCarouselItemCreating(object sender, NewCarouselItemCreatingEventArgs e)
        {
            e.NewCarouselItem = new RadButtonElement();
        }

        private void radCarousel1_ItemDataBound(object sender, ItemDataBoundEventArgs e)
        {
            if (e.DataBoundItem is RadButtonElement)
            {
                // get the button that was created in NewCarouselItemCreating
                RadButtonElement button = (e.DataBoundItem as RadButtonElement);
                // retrieve the DataRow for this item
                DataRow row = e.DataItem as DataRow;
                string url = row["link"].ToString();
                string title = row["title"].ToString();

                // configure the button element
                button.Text = title;
                button.DisplayStyle = DisplayStyle.Image;
                button.AngleTransform = 15;
                button.Click += new EventHandler(button_Click);

                // create the webbrowser component, size it to pick up 
                // as much of the page as possible.
                // set the url and attach the button element as the tag for 
                // use in the DocumentCompleted event handler.
                WebBrowser browser = new WebBrowser();
                browser.Width = 800;
                browser.Height = 600;
                browser.Url = new Uri(url);
                browser.ScrollBarsEnabled = false;
                browser.Tag = button;
                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
            }
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // browser that just completed rendering
            WebBrowser browser = sender as WebBrowser;
            // the element we want to add an image to
            RadButtonElement element = browser.Tag as RadButtonElement;
            // temporary bitmap to draw to
            Bitmap bitmap = new Bitmap(browser.Bounds.Width, browser.Bounds.Height);
            // draw the browser image to the bitmap      
            browser.DrawToBitmap(bitmap, browser.Bounds);
            // scrunch the image down and place it in the element image
            element.Image = bitmap.GetThumbnailImage(150, 150, null, new IntPtr());
        }

        void button_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show((sender as RadButtonElement).Text);
        }

    }
}

Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Xml

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        RadCarousel1.VisibleItemCount = 5

        Dim reader As New XmlTextReader("http://silverlight.net/blogs/MainFeed.aspx")
        Dim ds As New DataSet()
        ds.ReadXml(reader)

        ' get just the top three links
        Dim topRows As New List(Of DataRow)()
        Dim i As Integer = 0
        While i < RadCarousel1.VisibleItemCount
            topRows.Add(ds.Tables("item").Rows(i))
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While

        RadCarousel1.DataSource = topRows
    End Sub

    Private Sub radCarousel1_NewCarouselItemCreating(ByVal sender As Object, ByVal e As NewCarouselItemCreatingEventArgs) Handles RadCarousel1.NewCarouselItemCreating
        e.NewCarouselItem = New RadButtonElement()
    End Sub

    Private Sub radCarousel1_ItemDataBound(ByVal sender As Object, ByVal e As ItemDataBoundEventArgs) Handles RadCarousel1.ItemDataBound
        If TypeOf e.DataBoundItem Is RadButtonElement Then
            ' get the button that was created in NewCarouselItemCreating
            Dim button As RadButtonElement = (TryCast(e.DataBoundItem, RadButtonElement))
            ' retrieve the DataRow for this item
            Dim row As DataRow = TryCast(e.DataItem, DataRow)
            Dim url As String = row("link").ToString()
            Dim title As String = row("title").ToString()

            ' configure the button element
            button.Text = title
            button.DisplayStyle = DisplayStyle.Image
            button.AngleTransform = 15
            AddHandler button.Click, AddressOf button_Click

            ' create the webbrowser component, size it to pick up 
            ' as much of the page as possible.
            ' set the url and attach the button element as the tag for 
            ' use in the DocumentCompleted event handler.
            Dim browser As New WebBrowser()
            browser.Width = 800
            browser.Height = 600
            browser.Url = New Uri(url)
            browser.ScrollBarsEnabled = False
            browser.Tag = button
            AddHandler browser.DocumentCompleted, AddressOf browser_DocumentCompleted
        End If
    End Sub

    Private Sub browser_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        ' browser that just completed rendering
        Dim browser As WebBrowser = TryCast(sender, WebBrowser)
        ' the element we want to add an image to
        Dim element As RadButtonElement = TryCast(browser.Tag, RadButtonElement)
        ' temporary bitmap to draw to
        Dim bitmap As New Bitmap(browser.Bounds.Width, browser.Bounds.Height)
        ' draw the browser image to the bitmap 
        browser.DrawToBitmap(bitmap, browser.Bounds)
        ' scrunch the image down and place it in the element image
        element.Image = bitmap.GetThumbnailImage(150, 150, Nothing, New IntPtr())
    End Sub

    Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
        RadMessageBox.Show(TryCast(sender, RadButtonElement).Text)
    End Sub


End Class

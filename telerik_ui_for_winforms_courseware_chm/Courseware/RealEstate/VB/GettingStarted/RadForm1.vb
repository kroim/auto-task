Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RadButtonElement1.Image = New Bitmap(My.Resources.Lighthouse, New Size(200, 200))
        Me.RadButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement2.Image = New Bitmap(My.Resources.Penguins, New Size(200, 200))
        Me.RadButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement3.Image = New Bitmap(My.Resources.Tulips, New Size(200, 200))
        Me.RadButtonElement3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement4.Image = New Bitmap(My.Resources.Desert, New Size(50, 50))
        Me.RadButtonElement4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement4.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement5.Image = New Bitmap(My.Resources.Hydrangeas, New Size(50, 50))
        Me.RadButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement6.Image = New Bitmap(My.Resources.Koala, New Size(50, 50))
        Me.RadButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButtonElement6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter

        RadCarousel1.EnableAutoLoop = True
        RadRotator1.Running = True
    End Sub
End Class

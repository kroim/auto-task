Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Primitives

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create a stack panel to contain the title and bullet points
        Dim layoutPanel As StackLayoutPanel = New StackLayoutPanel()
        layoutPanel.Orientation = Orientation.Vertical
        Dim label As RadLabelElement = New RadLabelElement()

        ' create the "title"
        label.Text = "Safety Checklist"
        label.Padding = New Padding(5, 10, 0, 0)

        ' add the title and bullet points
        layoutPanel.Children.Add(label)
        layoutPanel.Children.Add(GetBulletPoint("Smoke detectors"))
        layoutPanel.Children.Add(GetBulletPoint("Ground-fault circuit interrupters"))
        layoutPanel.Children.Add(GetBulletPoint("Fire retardant roofing materials"))

        ' add the layout panel element to the panel's children
        radPanel1.RootElement.Children.Add(layoutPanel)
    End Sub

    Private Function GetBulletPoint(ByVal text As String) As StackLayoutPanel
        ' create a layout panel for a single "bullet point"
        Dim layoutPanel As StackLayoutPanel = New StackLayoutPanel()
        layoutPanel.Orientation = Orientation.Horizontal
        layoutPanel.Margin = New Padding(10, 10, 0, 0)

        ' add the "bullet point" graphic and add to the layout panel
        Dim arrowPrimitive As ArrowPrimitive = New ArrowPrimitive()
        arrowPrimitive.Direction = Telerik.WinControls.ArrowDirection.Right
        arrowPrimitive.Margin = New Padding(0, 0, 5, 0)
        arrowPrimitive.ForeColor = Color.Maroon
        layoutPanel.Children.Add(arrowPrimitive)

        ' add the text for the bullet point and add to the layout panel
        Dim textPrimitive As TextPrimitive = New TextPrimitive()
        textPrimitive.Text = text
        layoutPanel.Children.Add(textPrimitive)

        Return layoutPanel
    End Function

End Class

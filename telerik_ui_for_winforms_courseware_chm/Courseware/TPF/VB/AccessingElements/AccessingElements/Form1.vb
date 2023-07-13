Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' get the "ButtonElement", just under the root element,
        ' set the padding and text
        Dim buttonElement As RadButtonElement = TryCast(radButton2.RootElement.Children(0), RadButtonElement)
        buttonElement.TextImageRelation = TextImageRelation.TextBeforeImage
        buttonElement.Padding = New Padding(10)
        buttonElement.Text = "World" & Environment.NewLine & "Clock"

        ' access the fill primitive, use "OfficeGlass" style and set coloring
        Dim fillPrimitive As FillPrimitive = CType(buttonElement.GetChildrenByType(GetType(FillPrimitive))(0), FillPrimitive)
        fillPrimitive.GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlass
        fillPrimitive.BackColor = Color.Blue
        fillPrimitive.BackColor2 = Color.LightBlue
        fillPrimitive.BackColor3 = Color.Lavender
        fillPrimitive.BackColor4 = Color.Purple

        ' get the image primitive and set image. Set the opacity to be 50% transparent.
        Dim imagePrimitive As ImagePrimitive = TryCast(CType(buttonElement.Children(1).Children(0), ImagePrimitive), ImagePrimitive)
        imagePrimitive.Image = My.Resources._1403_Globe
        imagePrimitive.Opacity = 0.5

        ' get the text primitive and set the font to use a bold, script
        Dim textPrimitive As TextPrimitive = TryCast(CType(buttonElement.Children(1).Children(1), TextPrimitive), TextPrimitive)
        textPrimitive.Font = New Font("Segoe Script", 8.25F, FontStyle.Bold)

        ' get the border primitive and hide it.
        Dim borderPrimitive As BorderPrimitive = CType(buttonElement.GetChildrenByType(GetType(BorderPrimitive))(0), BorderPrimitive)
        borderPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Hidden

        ' match the button sizes 
        radButton2.Size = radButton1.Size
    End Sub
End Class

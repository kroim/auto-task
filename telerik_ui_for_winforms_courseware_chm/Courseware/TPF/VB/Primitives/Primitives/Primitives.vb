Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Primitives

Public Class MyElement
    Inherits RadItem
    Protected Overrides Sub CreateChildElements()
        Dim gradientStyleValues As Array = System.Enum.GetValues(GetType(GradientStyles))
        Dim layoutPanel As StackLayoutPanel = New StackLayoutPanel()
        layoutPanel.Orientation = System.Windows.Forms.Orientation.Vertical

        For Each gradientStyle As GradientStyles In gradientStyleValues
            Dim panel As StackLayoutPanel = New StackLayoutPanel()
            panel.Orientation = System.Windows.Forms.Orientation.Vertical
            panel.Margin = New System.Windows.Forms.Padding(20, 1, 20, 0)

            Dim textPrimitive As TextPrimitive = New TextPrimitive()
            textPrimitive.Text = gradientStyle.ToString("g")
            textPrimitive.Font = New Font("Arial", 10.0F)
            textPrimitive.ForeColor = Color.Black
            textPrimitive.Shadow = New Telerik.WinControls.Paint.ShadowSettings(New System.Drawing.Point(1, 1), Color.DarkGray)
            panel.Children.Add(textPrimitive)

            Dim fillPrimitive As FillPrimitive = New FillPrimitive()
            fillPrimitive.MinSize = New System.Drawing.Size(0, 20)
            fillPrimitive.NumberOfColors = 4
            fillPrimitive.GradientStyle = gradientStyle
            fillPrimitive.BackColor = Color.Blue
            fillPrimitive.BackColor2 = Color.BlueViolet
            fillPrimitive.BackColor3 = Color.Violet
            fillPrimitive.BackColor4 = Color.Red
            panel.Children.Add(fillPrimitive)

            layoutPanel.Children.Add(panel)
        Next gradientStyle
        Me.Children.Add(layoutPanel)
        MyBase.CreateChildElements()
    End Sub
End Class
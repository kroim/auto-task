Imports Telerik.WinControls

Public Class WelcomeScreenBottom

    Private Sub WelcomeScreenBottom_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent

        SetChildrenNotifyONMouseInput(Me.radStackItemsPanelElement2)
        SetChildrenNotifyONMouseInput(Me.radStackItemsPanelElement3)
        SetChildrenNotifyONMouseInput(Me.radStackItemsPanelElement4)
        SetChildrenNotifyONMouseInput(Me.radStackItemsPanelElement5)

        Me.radStackItemsPanelElement2.AddBehavior(New WelcomeScreenMouseOverBehavior())
        Me.radStackItemsPanelElement3.AddBehavior(New WelcomeScreenMouseOverBehavior())
        Me.radStackItemsPanelElement4.AddBehavior(New WelcomeScreenMouseOverBehavior())
        Me.radStackItemsPanelElement5.AddBehavior(New WelcomeScreenMouseOverBehavior())
    End Sub

    Private Sub SetChildrenNotifyONMouseInput(ByVal item As RadElement)
        For Each childItem As RadElement In item.Children
            childItem.NotifyParentOnMouseInput = True
            childItem.ShouldHandleMouseInput = False
            SetChildrenNotifyONMouseInput(childItem)
        Next childItem
    End Sub

    Private Sub radStackItemsPanelElement2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radStackItemsPanelElement2.Click
        Process.Start("http://www.telerik.com/winforms")
    End Sub

    Private Sub radStackItemsPanelElement3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radStackItemsPanelElement3.Click
        Process.Start("http://www.telerik.com/products/winforms/sample-applications.aspx")
    End Sub

    Private Sub radStackItemsPanelElement4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radStackItemsPanelElement4.Click
        Process.Start("http://www.telerik.com/products/winforms/tools.aspx")
    End Sub

    Private Sub radStackItemsPanelElement5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radStackItemsPanelElement5.Click
        Process.Start("http://www.telerik.com/products/winforms/whats-new.aspx")
    End Sub

    ''' <summary>
    ''' Behavior class defining the OnMouseOver behavior of the BubbleBar
    ''' </summary>
    Public Class WelcomeScreenMouseOverBehavior
        Inherits PropertyChangeBehavior
        Public Sub New()
            MyBase.New(RadItem.IsMouseOverProperty)
        End Sub

        Private oldCursor As Cursor = Nothing

        Public Overrides Sub OnPropertyChange(ByVal element As RadElement, ByVal e As RadPropertyChangedEventArgs)
            For Each childItem As RadElement In element.Parent.Children
                Dim item As RadItem = TryCast(childItem, RadItem)
                If item IsNot Nothing Then
                    Dim animation As AnimatedPropertySetting
                    Dim scale As SizeF

                    If CBool(e.NewValue) = False Then
                        scale = New SizeF(1.0F, 1.0F)
                        If Me.oldCursor IsNot Nothing AndAlso element.ElementTree IsNot Nothing Then
                            element.ElementTree.Control.Cursor = Me.oldCursor
                        End If
                    Else
                        If item.Equals(element) Then
                            scale = New SizeF(1.1F, 1.1F)
                        Else
                            scale = New SizeF(0.9F, 0.9F)
                        End If

                        If element.ElementTree IsNot Nothing Then
                            Me.oldCursor = element.ElementTree.Control.Cursor
                            element.ElementTree.Control.Cursor = Cursors.Hand
                        End If
                    End If

                    animation = New AnimatedPropertySetting(RadElement.ScaleTransformProperty, scale, 10, 33)
                    animation.SkipToEndValueOnReplace = False
                    animation.ApplyValue(item)
                End If
            Next
        End Sub

    End Class
End Class


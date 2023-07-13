Imports System.ComponentModel
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports System.Drawing.Design

Public Class RadStackItemsPanelElement
    Inherits RadItem
    Private _items As RadItemOwnerCollection
    Private _stackLayout As StackLayoutPanel

    Public Sub New()
        Me.NotifyParentOnMouseInput = False
        Me.ShouldHandleMouseInput = True
    End Sub

    <RadEditItemsAction(), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Editor(GetType(RadItemCollectionEditor), GetType(UITypeEditor))> _
    Public ReadOnly Property Items() As RadItemOwnerCollection
        Get
            If Me._items Is Nothing Then
                Me._items = New RadItemOwnerCollection()
                Me._items.Owner = Me._stackLayout
            End If

            Return _items
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), TypeConverter(GetType(ExpandableObjectConverter))> _
    Public ReadOnly Property StackLayout() As StackLayoutPanel
        Get
            Return _stackLayout
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), RefreshProperties(RefreshProperties.All)> _
    Public Property StackOrientation() As Orientation
        Get
            Return Me._stackLayout.Orientation
        End Get
        Set(ByVal value As Orientation)
            Me._stackLayout.Orientation = value
        End Set
    End Property

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        Me._stackLayout = New StackLayoutPanel()

        Me.Children.Add(Me._stackLayout)
    End Sub
End Class
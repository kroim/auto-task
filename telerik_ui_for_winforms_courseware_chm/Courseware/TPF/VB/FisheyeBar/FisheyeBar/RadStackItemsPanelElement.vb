Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class RadStackItemsPanelElement
    Inherits RadItem
    Private m_items As RadItemOwnerCollection
    Private m_stackLayout As StackLayoutPanel

    Public Sub New()
        Me.NotifyParentOnMouseInput = False
        Me.ShouldHandleMouseInput = True
    End Sub

    <RadEditItemsAction()> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property Items() As RadItemOwnerCollection
        Get
            If Me.m_items Is Nothing Then
                Me.m_items = New RadItemOwnerCollection()
                Me.m_items.Owner = Me.StackLayout
            End If

            Return m_items
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    <TypeConverter(GetType(ExpandableObjectConverter))> _
    Public ReadOnly Property StackLayout() As StackLayoutPanel
        Get
            Return m_stackLayout
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    <RefreshProperties(RefreshProperties.All)> _
    Public Property StackOrientation() As Orientation
        Get
            Return Me.StackLayout.Orientation
        End Get
        Set(ByVal value As Orientation)
            Me.StackLayout.Orientation = value
        End Set
    End Property

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        Me.m_stackLayout = New StackLayoutPanel()

        Me.Children.Add(Me.StackLayout)
    End Sub

End Class
Imports Telerik.WinControls
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class RadStackItemsPanel
    Inherits RadControl
    Private stackPanelElement As RadStackItemsPanelElement

    Public Sub New()
        Me.UseNewLayoutSystem = True
    End Sub

    Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
        MyBase.CreateChildItems(parent)

        stackPanelElement = New RadStackItemsPanelElement()
        stackPanelElement.SerializeElement = False

        parent.Children.Add(stackPanelElement)
    End Sub

    <RadEditItemsAction(), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Editor(GetType(RadItemCollectionEditor), GetType(UITypeEditor))> _
    Public ReadOnly Property Items() As RadItemOwnerCollection
        Get
            Return Me.PanelElement.Items
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property PanelElement() As RadStackItemsPanelElement
        Get
            Return Me.stackPanelElement
        End Get
    End Property
End Class
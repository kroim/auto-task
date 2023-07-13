Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts

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

    <RadEditItemsAction()> _
     <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
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
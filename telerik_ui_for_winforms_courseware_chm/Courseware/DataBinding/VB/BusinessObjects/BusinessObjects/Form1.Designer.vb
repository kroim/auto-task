<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbProducts = New Telerik.WinControls.UI.RadListControl()
        Me.bindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.seID = New Telerik.WinControls.UI.RadSpinEditor()
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        CType(Me.lbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNavigator1.SuspendLayout()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbProducts
        '
        Me.lbProducts.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbProducts.CaseSensitiveSort = True
        Me.lbProducts.ItemHeight = 18
        Me.lbProducts.Location = New System.Drawing.Point(12, 28)
        Me.lbProducts.Name = "lbProducts"
        '
        '
        '
        Me.lbProducts.RootElement.AccessibleDescription = Nothing
        Me.lbProducts.RootElement.AccessibleName = Nothing
        Me.lbProducts.RootElement.ControlBounds = New System.Drawing.Rectangle(12, 28, 120, 95)
        Me.lbProducts.Size = New System.Drawing.Size(259, 112)
        Me.lbProducts.TabIndex = 0
        '
        'bindingNavigator1
        '
        Me.bindingNavigator1.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.bindingNavigator1.BindingSource = Me.bindingSource1
        Me.bindingNavigator1.CountItem = Me.bindingNavigatorCountItem
        Me.bindingNavigator1.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.bindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem})
        Me.bindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.bindingNavigator1.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.bindingNavigator1.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.bindingNavigator1.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.bindingNavigator1.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.bindingNavigator1.Name = "bindingNavigator1"
        Me.bindingNavigator1.PositionItem = Me.bindingNavigatorPositionItem
        Me.bindingNavigator1.Size = New System.Drawing.Size(284, 25)
        Me.bindingNavigator1.TabIndex = 1
        Me.bindingNavigator1.Text = "bindingNavigator1"
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorAddNewItem.Text = "Add new"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorDeleteItem.Text = "Delete"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.AccessibleName = "Position"
        Me.bindingNavigatorPositionItem.AutoSize = False
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbDescription
        '
        Me.tbDescription.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbDescription.Location = New System.Drawing.Point(91, 162)
        Me.tbDescription.Name = "tbDescription"
        '
        '
        '
        Me.tbDescription.RootElement.AccessibleDescription = Nothing
        Me.tbDescription.RootElement.AccessibleName = Nothing
        Me.tbDescription.RootElement.ControlBounds = New System.Drawing.Rectangle(91, 162, 100, 20)
        Me.tbDescription.RootElement.StretchVertically = True
        Me.tbDescription.Size = New System.Drawing.Size(180, 20)
        Me.tbDescription.TabIndex = 2
        Me.tbDescription.TabStop = False
        '
        'seID
        '
        Me.seID.BackColor = System.Drawing.Color.White
        Me.seID.Location = New System.Drawing.Point(91, 189)
        Me.seID.Name = "seID"
        '
        '
        '
        Me.seID.RootElement.AccessibleDescription = Nothing
        Me.seID.RootElement.AccessibleName = Nothing
        Me.seID.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.seID.RootElement.ControlBounds = New System.Drawing.Rectangle(91, 189, 100, 20)
        Me.seID.RootElement.StretchVertically = True
        Me.seID.ShowBorder = True
        Me.seID.Size = New System.Drawing.Size(48, 20)
        Me.seID.TabIndex = 3
        Me.seID.TabStop = False
        Me.seID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'radLabel1
        '
        Me.radLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radLabel1.Location = New System.Drawing.Point(12, 162)
        Me.radLabel1.Name = "radLabel1"
        '
        '
        '
        Me.radLabel1.RootElement.AccessibleDescription = Nothing
        Me.radLabel1.RootElement.AccessibleName = Nothing
        Me.radLabel1.Size = New System.Drawing.Size(64, 14)
        Me.radLabel1.TabIndex = 4
        Me.radLabel1.Text = "Description:"
        Me.radLabel1.ThemeName = "Desert"
        '
        'radLabel2
        '
        Me.radLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radLabel2.Location = New System.Drawing.Point(12, 189)
        Me.radLabel2.Name = "radLabel2"
        '
        '
        '
        Me.radLabel2.RootElement.AccessibleDescription = Nothing
        Me.radLabel2.RootElement.AccessibleName = Nothing
        Me.radLabel2.Size = New System.Drawing.Size(19, 14)
        Me.radLabel2.TabIndex = 5
        Me.radLabel2.Text = "ID:"
        Me.radLabel2.ThemeName = "Desert"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(197, 229)
        Me.btnUpdate.Name = "btnUpdate"
        '
        '
        '
        Me.btnUpdate.RootElement.AccessibleDescription = Nothing
        Me.btnUpdate.RootElement.AccessibleName = Nothing
        Me.btnUpdate.RootElement.ControlBounds = New System.Drawing.Rectangle(197, 229, 130, 24)
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radLabel1)
        Me.Controls.Add(Me.seID)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.bindingNavigator1)
        Me.Controls.Add(Me.lbProducts)
        Me.Name = "Form1"
        Me.Text = "Data Binding"
        CType(Me.lbProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNavigator1.ResumeLayout(False)
        Me.bindingNavigator1.PerformLayout()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private lbProducts As Telerik.WinControls.UI.RadListControl
    Private bindingNavigator1 As System.Windows.Forms.BindingNavigator
    Private bindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Private bindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Private bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Private bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private tbDescription As Telerik.WinControls.UI.RadTextBox
    Private seID As Telerik.WinControls.UI.RadSpinEditor
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Private bindingSource1 As System.Windows.Forms.BindingSource
End Class

Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits RadForm

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
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem14 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Me.lcLeft = New Telerik.WinControls.UI.RadListControl
        Me.lcRight = New Telerik.WinControls.UI.RadListControl
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel
        CType(Me.lcLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcLeft
        '
        Me.lcLeft.CaseSensitiveSort = True
        Me.lcLeft.ItemHeight = 18
        RadListDataItem8.Text = "RadControls for WPF"
        RadListDataItem8.TextWrap = True
        RadListDataItem9.Text = "Sitefinity"
        RadListDataItem9.TextWrap = True
        RadListDataItem10.Text = "OpenAccess ORM"
        RadListDataItem10.TextWrap = True
        RadListDataItem11.Text = "RadControls for ASP.NET AJAX"
        RadListDataItem11.TextWrap = True
        RadListDataItem12.Text = "RadControls for WinForms"
        RadListDataItem12.TextWrap = True
        RadListDataItem13.Text = "RadControls for Silverlight"
        RadListDataItem13.TextWrap = True
        RadListDataItem14.Text = "Telerik Reporting"
        RadListDataItem14.TextWrap = True
        Me.lcLeft.Items.Add(RadListDataItem8)
        Me.lcLeft.Items.Add(RadListDataItem9)
        Me.lcLeft.Items.Add(RadListDataItem10)
        Me.lcLeft.Items.Add(RadListDataItem11)
        Me.lcLeft.Items.Add(RadListDataItem12)
        Me.lcLeft.Items.Add(RadListDataItem13)
        Me.lcLeft.Items.Add(RadListDataItem14)
        Me.lcLeft.Location = New System.Drawing.Point(12, 34)
        Me.lcLeft.Name = "lcLeft"
        Me.lcLeft.Size = New System.Drawing.Size(221, 238)
        Me.lcLeft.TabIndex = 0
        Me.lcLeft.Text = "RadListControl1"
        '
        'lcRight
        '
        Me.lcRight.CaseSensitiveSort = True
        Me.lcRight.ItemHeight = 18
        Me.lcRight.Location = New System.Drawing.Point(295, 34)
        Me.lcRight.Name = "lcRight"
        Me.lcRight.Size = New System.Drawing.Size(221, 238)
        Me.lcRight.TabIndex = 1
        Me.lcRight.Text = "RadListControl2"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(40, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Source"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(295, 12)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Destination"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 288)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.lcRight)
        Me.Controls.Add(Me.lcLeft)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form1"
        CType(Me.lcLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lcLeft As Telerik.WinControls.UI.RadListControl
    Friend WithEvents lcRight As Telerik.WinControls.UI.RadListControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel

End Class

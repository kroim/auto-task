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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadWizard1 = New Telerik.WinControls.UI.RadWizard
        Me.WizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.WizardPage1 = New Telerik.WinControls.UI.WizardPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.WizardCompletionPage1 = New Telerik.WinControls.UI.WizardCompletionPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.WizardPage2 = New Telerik.WinControls.UI.WizardPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.WizardPage3 = New Telerik.WinControls.UI.WizardPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.RadRadioButton1 = New Telerik.WinControls.UI.RadRadioButton
        Me.RadRadioButton2 = New Telerik.WinControls.UI.RadRadioButton
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBox2 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBox3 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBox4 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBox5 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBox6 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBox7 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBox8 = New Telerik.WinControls.UI.RadCheckBox
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel
        Me.RadWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadWizard1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadWizard1
        '
        Me.RadWizard1.CompletionPage = Me.WizardCompletionPage1
        Me.RadWizard1.Controls.Add(Me.Panel1)
        Me.RadWizard1.Controls.Add(Me.Panel2)
        Me.RadWizard1.Controls.Add(Me.Panel3)
        Me.RadWizard1.Controls.Add(Me.Panel4)
        Me.RadWizard1.Controls.Add(Me.Panel5)
        Me.RadWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadWizard1.Location = New System.Drawing.Point(0, 0)
        Me.RadWizard1.Mode = Telerik.WinControls.UI.WizardMode.Wizard97
        Me.RadWizard1.Name = "RadWizard1"
        Me.RadWizard1.PageHeaderIcon = CType(resources.GetObject("RadWizard1.PageHeaderIcon"), System.Drawing.Image)
        Me.RadWizard1.Pages.Add(Me.WizardWelcomePage1)
        Me.RadWizard1.Pages.Add(Me.WizardPage1)
        Me.RadWizard1.Pages.Add(Me.WizardPage2)
        Me.RadWizard1.Pages.Add(Me.WizardPage3)
        Me.RadWizard1.Pages.Add(Me.WizardCompletionPage1)
        Me.RadWizard1.Size = New System.Drawing.Size(688, 474)
        Me.RadWizard1.TabIndex = 0
        Me.RadWizard1.Text = "RadWizard1"
        Me.RadWizard1.WelcomePage = Me.WizardWelcomePage1
        '
        'WizardWelcomePage1
        '
        Me.WizardWelcomePage1.ContentArea = Me.Panel1
        Me.WizardWelcomePage1.CustomizePageHeader = True
        Me.WizardWelcomePage1.Header = ""
        Me.WizardWelcomePage1.Icon = CType(resources.GetObject("WizardWelcomePage1.Icon"), System.Drawing.Image)
        Me.WizardWelcomePage1.Name = "WizardWelcomePage1"
        Me.WizardWelcomePage1.Title = "RadControls for WinForms installation wizard"
        Me.WizardWelcomePage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.WizardWelcomePage1.WelcomeImage = CType(resources.GetObject("WizardWelcomePage1.WelcomeImage"), System.Drawing.Image)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Location = New System.Drawing.Point(171, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 362)
        Me.Panel1.TabIndex = 0
        '
        'WizardPage1
        '
        Me.WizardPage1.ContentArea = Me.Panel2
        Me.WizardPage1.Header = ""
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Title = "Choose installation type"
        Me.WizardPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.RadRadioButton2)
        Me.Panel2.Controls.Add(Me.RadRadioButton1)
        Me.Panel2.Controls.Add(Me.RadLabel2)
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 362)
        Me.Panel2.TabIndex = 1
        '
        'WizardCompletionPage1
        '
        Me.WizardCompletionPage1.ContentArea = Me.Panel3
        Me.WizardCompletionPage1.Name = "WizardCompletionPage1"
        Me.WizardCompletionPage1.Title = "Installation Successful"
        Me.WizardCompletionPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.RadLabel5)
        Me.Panel3.Location = New System.Drawing.Point(150, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(538, 370)
        Me.Panel3.TabIndex = 2
        '
        'WizardPage2
        '
        Me.WizardPage2.ContentArea = Me.Panel4
        Me.WizardPage2.Header = ""
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Title = "Choose components to install"
        Me.WizardPage2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.RadCheckBox8)
        Me.Panel4.Controls.Add(Me.RadCheckBox5)
        Me.Panel4.Controls.Add(Me.RadCheckBox4)
        Me.Panel4.Controls.Add(Me.RadCheckBox6)
        Me.Panel4.Controls.Add(Me.RadCheckBox3)
        Me.Panel4.Controls.Add(Me.RadCheckBox7)
        Me.Panel4.Controls.Add(Me.RadCheckBox2)
        Me.Panel4.Controls.Add(Me.RadCheckBox1)
        Me.Panel4.Controls.Add(Me.RadLabel3)
        Me.Panel4.Location = New System.Drawing.Point(0, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(688, 362)
        Me.Panel4.TabIndex = 3
        '
        'WizardPage3
        '
        Me.WizardPage3.ContentArea = Me.Panel5
        Me.WizardPage3.Header = ""
        Me.WizardPage3.Name = "WizardPage3"
        Me.WizardPage3.Title = "Installation progress"
        Me.WizardPage3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.RadWaitingBar1)
        Me.Panel5.Controls.Add(Me.RadLabel4)
        Me.Panel5.Location = New System.Drawing.Point(0, 64)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(688, 362)
        Me.Panel5.TabIndex = 4
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RadLabel1.Location = New System.Drawing.Point(32, 84)
        Me.RadLabel1.MinimumSize = New System.Drawing.Size(0, 50)
        Me.RadLabel1.Name = "RadLabel1"
        '
        '
        '
        Me.RadLabel1.RootElement.MinSize = New System.Drawing.Size(0, 50)
        Me.RadLabel1.Size = New System.Drawing.Size(431, 57)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "<html><p>Wellcome, </p><p></p><p>Thank you for choosing Telerik RadControls for W" & _
            "inForms.</p></html>"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(31, 41)
        Me.RadLabel2.MinimumSize = New System.Drawing.Size(0, 100)
        Me.RadLabel2.Name = "RadLabel2"
        '
        '
        '
        Me.RadLabel2.RootElement.MinSize = New System.Drawing.Size(0, 100)
        Me.RadLabel2.Size = New System.Drawing.Size(444, 100)
        Me.RadLabel2.TabIndex = 0
        Me.RadLabel2.Text = resources.GetString("RadLabel2.Text")
        '
        'RadRadioButton1
        '
        Me.RadRadioButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton1.Location = New System.Drawing.Point(31, 160)
        Me.RadRadioButton1.Name = "RadRadioButton1"
        Me.RadRadioButton1.Size = New System.Drawing.Size(136, 27)
        Me.RadRadioButton1.TabIndex = 1
        Me.RadRadioButton1.Text = "Full"
        '
        'RadRadioButton2
        '
        Me.RadRadioButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton2.Location = New System.Drawing.Point(31, 193)
        Me.RadRadioButton2.Name = "RadRadioButton2"
        Me.RadRadioButton2.Size = New System.Drawing.Size(136, 27)
        Me.RadRadioButton2.TabIndex = 2
        Me.RadRadioButton2.Text = "Customize"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 26)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(126, 16)
        Me.RadLabel3.TabIndex = 0
        Me.RadLabel3.Text = "Select features to install"
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Location = New System.Drawing.Point(12, 68)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(152, 18)
        Me.RadCheckBox1.TabIndex = 1
        Me.RadCheckBox1.Text = "RadControls for WinForms"
        '
        'RadCheckBox2
        '
        Me.RadCheckBox2.Location = New System.Drawing.Point(32, 92)
        Me.RadCheckBox2.Name = "RadCheckBox2"
        Me.RadCheckBox2.Size = New System.Drawing.Size(84, 18)
        Me.RadCheckBox2.TabIndex = 2
        Me.RadCheckBox2.Text = "Components"
        '
        'RadCheckBox3
        '
        Me.RadCheckBox3.Location = New System.Drawing.Point(32, 116)
        Me.RadCheckBox3.Name = "RadCheckBox3"
        Me.RadCheckBox3.Size = New System.Drawing.Size(55, 18)
        Me.RadCheckBox3.TabIndex = 2
        Me.RadCheckBox3.Text = "Demos"
        '
        'RadCheckBox4
        '
        Me.RadCheckBox4.Location = New System.Drawing.Point(32, 140)
        Me.RadCheckBox4.Name = "RadCheckBox4"
        Me.RadCheckBox4.Size = New System.Drawing.Size(141, 18)
        Me.RadCheckBox4.TabIndex = 2
        Me.RadCheckBox4.Text = "Visual Studio Extensions"
        '
        'RadCheckBox5
        '
        Me.RadCheckBox5.Location = New System.Drawing.Point(54, 164)
        Me.RadCheckBox5.Name = "RadCheckBox5"
        Me.RadCheckBox5.Size = New System.Drawing.Size(113, 18)
        Me.RadCheckBox5.TabIndex = 5
        Me.RadCheckBox5.Text = "Visual Studio 2005"
        '
        'RadCheckBox6
        '
        Me.RadCheckBox6.Location = New System.Drawing.Point(54, 188)
        Me.RadCheckBox6.Name = "RadCheckBox6"
        Me.RadCheckBox6.Size = New System.Drawing.Size(113, 18)
        Me.RadCheckBox6.TabIndex = 4
        Me.RadCheckBox6.Text = "Visual Studio 2008"
        '
        'RadCheckBox7
        '
        Me.RadCheckBox7.Location = New System.Drawing.Point(54, 212)
        Me.RadCheckBox7.Name = "RadCheckBox7"
        Me.RadCheckBox7.Size = New System.Drawing.Size(113, 18)
        Me.RadCheckBox7.TabIndex = 3
        Me.RadCheckBox7.Text = "Visual Studio 2010"
        '
        'RadCheckBox8
        '
        Me.RadCheckBox8.Location = New System.Drawing.Point(32, 236)
        Me.RadCheckBox8.Name = "RadCheckBox8"
        Me.RadCheckBox8.Size = New System.Drawing.Size(98, 18)
        Me.RadCheckBox8.TabIndex = 4
        Me.RadCheckBox8.Text = "Documentation"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.RadLabel4.Location = New System.Drawing.Point(45, 52)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(181, 25)
        Me.RadLabel4.TabIndex = 0
        Me.RadLabel4.Text = "Installation progress"
        '
        'RadWaitingBar1
        '
        Me.RadWaitingBar1.Location = New System.Drawing.Point(45, 135)
        Me.RadWaitingBar1.Name = "RadWaitingBar1"
        Me.RadWaitingBar1.Size = New System.Drawing.Size(621, 38)
        Me.RadWaitingBar1.TabIndex = 1
        Me.RadWaitingBar1.Text = "RadWaitingBar1"
        Me.RadWaitingBar1.WaitingSpeed = 10
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(36, 107)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(353, 40)
        Me.RadLabel5.TabIndex = 0
        Me.RadLabel5.Text = "<html><p>Congratulations, </p><p></p><p>RadControls for WinForms is successfully " & _
            " installed on your computer.</p></html>"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 474)
        Me.Controls.Add(Me.RadWizard1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadWizard1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadWizard1 As Telerik.WinControls.UI.RadWizard
    Friend WithEvents WizardCompletionPage1 As Telerik.WinControls.UI.WizardCompletionPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents WizardWelcomePage1 As Telerik.WinControls.UI.WizardWelcomePage
    Friend WithEvents WizardPage1 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents WizardPage2 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents WizardPage3 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadRadioButton2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox8 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox5 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox4 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox6 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox3 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox7 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox2 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel

End Class

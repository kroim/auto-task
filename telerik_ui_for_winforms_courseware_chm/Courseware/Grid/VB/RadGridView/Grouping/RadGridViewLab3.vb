Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Data

Namespace _03_Grouping
    Partial Public Class RadGridViewLab3
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub


        Private Sub RadGridViewLab3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.customersTableAdapter.Fill(Me.dataSet1.Customers)

            ' uncomment the following code to enable programmatic grouping

            ''remove the "City" grouping added in the designer
            'radGridView1.MasterTemplate.GroupDescriptors.RemoveAt(1)
            ''add a new grouping by "Contact Title"
            'radGridView1.MasterTemplate.GroupDescriptors.Add(New GroupDescriptor("ContactTitle ASC"))

        End Sub
    End Class
End Namespace

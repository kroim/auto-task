Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Reflection
Imports System.Text

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = "Desert"
    End Sub

    ' return a string surrounded with parenthesis and containing
    ' a comma-delimited list of parameter types, e.g.
    ' "(String, String, Int32)"
    Private Function GetParameterList(ByVal parameters As ParameterInfo()) As String
        Dim builder As StringBuilder = New StringBuilder("(")

        Dim i As Integer = 0
        For Each parameter As ParameterInfo In parameters
            builder.Append(parameter.ParameterType.Name)

            If i < parameters.Length Then
                builder.Append(", ")
                i += 1
            End If
        Next parameter
        builder.Append(")")
        Return builder.ToString()
    End Function

    ' Get a path and load an Assembly.
    ' Call private method LoadNodes() to begin reflecting
    ' on the assembly contents
    Private Sub miOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpen.Click
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "Dynamic Link Libraries|*.dll|Executable|*.exe"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim [assembly] As System.Reflection.Assembly = System.Reflection.Assembly.ReflectionOnlyLoadFrom(dialog.FileName)
            LoadNodes(tvReflection.Nodes, [assembly])
        End If
        lblStatus.Text = "Loaded " & System.IO.Path.GetFileNameWithoutExtension(dialog.FileName)
        tvReflection.ExpandAll()
    End Sub

    Private Sub LoadNodes(ByVal nodes As RadTreeNodeCollection, ByVal [assembly] As System.Reflection.Assembly)
        nodes.Clear()

        ' get the name, e.g. "MyDll" from the Assembly
        Dim assemblyName As String = System.IO.Path.GetFileNameWithoutExtension([assembly].Location)

        ' add a root node with the assembly name and a "library" icon
        ' store the assembly reference itself in the tag for later retrieval
        Dim rootNode As RadTreeNode = nodes.Add(assemblyName)
        rootNode.Image = ilIcons.Images("library")
        rootNode.Tag = [assembly]

        ' reflect all the types in the assembly
        For Each type As Type In [assembly].GetTypes()
            ' only look at top level types 
            If (Not type.IsNested) Then
                ' load a node for each top level type
                Dim typeNode As RadTreeNode = rootNode.Nodes.Add(type.Name)
                typeNode.Tag = type
                If type.IsClass Then
                    typeNode.Image = ilIcons.Images("class")
                End If

                ' drill down for further reflection on the type
                LoadTypeNode(type, typeNode)
            End If
        Next type
    End Sub

    ' add nodes with reflection information for constructors, methods, 
    ' properties and types of the type.
    Private Sub LoadTypeNode(ByVal type As Type, ByVal typeNode As RadTreeNode)
        ' add nodes for different categories of reflection
        Dim constructorNode As RadTreeNode = typeNode.Nodes.Add("Constructors")
        constructorNode.Image = ilIcons.Images("method")
        Dim methodNode As RadTreeNode = typeNode.Nodes.Add("Methods")
        methodNode.Image = ilIcons.Images("method")
        Dim propertyNode As RadTreeNode = typeNode.Nodes.Add("Properties")
        propertyNode.Image = ilIcons.Images("property")
        Dim nestedTypeNode As RadTreeNode = typeNode.Nodes.Add("Types")

        ' add nodes for each type...

        For Each constructor As ConstructorInfo In type.GetConstructors()
            Dim tempNode As RadTreeNode = constructorNode.Nodes.Add(constructor.Name + GetParameterList(constructor.GetParameters()))
            tempNode.Tag = constructor
        Next constructor

        For Each method As MethodInfo In type.GetMethods()
            Dim methodText As String = method.Name + GetParameterList(method.GetParameters()) & ": " & method.ReturnParameter.ParameterType.Name
            Dim tempNode As RadTreeNode = methodNode.Nodes.Add(methodText)
            tempNode.Tag = method
        Next method

        For Each [property] As PropertyInfo In type.GetProperties()
            Dim tempNode As RadTreeNode = propertyNode.Nodes.Add([property].Name & ": " & [property].PropertyType.Name)
            tempNode.Tag = [property]
        Next [property]

        For Each nestedType As Type In type.GetNestedTypes()
            Dim tempNode As RadTreeNode = nestedTypeNode.Nodes.Add(nestedType.Name)
            tempNode.Tag = nestedType
        Next nestedType
    End Sub

    Private Sub tvReflection_SelectedNodeChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.RadTreeViewEventArgs) Handles tvReflection.SelectedNodeChanged
        lblDetail.Text = String.Empty
        If Not e.Node.Tag Is Nothing Then
            If TypeOf e.Node.Tag Is System.Reflection.Assembly Then
                lblDetail.Text = GetAssemblyDescription(TryCast(e.Node.Tag, System.Reflection.Assembly))
            ElseIf TypeOf e.Node.Tag Is Type Then
                lblDetail.Text = GetTypeDescription(TryCast(e.Node.Tag, Type))
            ElseIf TypeOf e.Node.Tag Is ConstructorInfo Then
                lblDetail.Text = GetMethodDescription(TryCast(e.Node.Tag, ConstructorInfo))
            ElseIf TypeOf e.Node.Tag Is MethodInfo Then
                lblDetail.Text = GetMethodDescription(TryCast(e.Node.Tag, MethodInfo))
            ElseIf TypeOf e.Node.Tag Is PropertyInfo Then
                lblDetail.Text = GetPropertyDescription(TryCast(e.Node.Tag, PropertyInfo))
            End If
        End If
    End Sub

    Private Function GetAssemblyDescription(ByVal [assembly] As System.Reflection.Assembly) As String
        Dim builder As StringBuilder = New StringBuilder([assembly].GetName().Name)

        Dim version As Version = [assembly].GetName().Version
        builder.AppendFormat("{0}.{1}.{2}.{3}", version.Major, version.MajorRevision, version.Minor, version.MinorRevision)

        Return builder.ToString()
    End Function

    Private Function GetTypeDescription(ByVal type As Type) As String
        Dim builder As StringBuilder = New StringBuilder()

        If type.IsPublic Then
            builder.Append("public ")
        End If

        If type.IsClass Then
            builder.Append("class ")
        ElseIf type.IsEnum Then
            builder.Append("enum ")
        End If

        builder.Append(type.Name)
        builder.Append(Environment.NewLine)
        builder.Append("Name: ")
        builder.Append(type.FullName)
        builder.Append(Environment.NewLine)
        builder.Append("Assembly: ")
        builder.Append(GetAssemblyDescription(type.Assembly))

        Return builder.ToString()
    End Function

    Private Function GetMethodDescription(ByVal method As MethodBase) As String
        Dim builder As StringBuilder = New StringBuilder()
        If method.IsPublic Then
            builder.Append("public ")
        End If
        If TypeOf method Is MethodInfo Then
            builder.Append(method.Name)
        Else
            builder.Append(method.DeclaringType.Name)
        End If
        builder.Append(GetParameterList(method.GetParameters()))
        If TypeOf method Is MethodInfo Then
            builder.Append(": ")
            builder.Append((TryCast(method, MethodInfo)).ReturnType.Name)
        End If
        builder.Append(Environment.NewLine)
        builder.Append("Declaring Type: ")
        builder.Append(method.DeclaringType.FullName)
        builder.Append(Environment.NewLine)
        builder.Append("Assembly: ")
        builder.Append(GetAssemblyDescription(method.DeclaringType.Assembly))

        Return builder.ToString()
    End Function

    Private Function GetPropertyDescription(ByVal [property] As PropertyInfo) As String
        Dim builder As StringBuilder = New StringBuilder()

        If [property].PropertyType.IsPublic Then
            builder.Append("public ")
        End If
        builder.Append([property].PropertyType.Name)
        builder.Append(" { ")
        For Each method As MethodInfo In [property].GetAccessors()
            builder.AppendFormat("{0}; ", method.Name)
        Next method
        builder.Append(" } ")

        builder.Append(Environment.NewLine)
        builder.Append("Declaring Type: ")
        builder.Append([property].DeclaringType.FullName)
        builder.Append(Environment.NewLine)
        builder.Append("Assembly: ")
        builder.Append(GetAssemblyDescription([property].DeclaringType.Assembly))

        Return builder.ToString()
    End Function

    Private Sub miClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miClose.Click
        tvReflection.Nodes.Clear()
        lblStatus.Text = String.Empty
        lblDetail.Text = String.Empty
    End Sub

    Private Sub miExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miExit.Click
        Me.Close()
    End Sub

End Class

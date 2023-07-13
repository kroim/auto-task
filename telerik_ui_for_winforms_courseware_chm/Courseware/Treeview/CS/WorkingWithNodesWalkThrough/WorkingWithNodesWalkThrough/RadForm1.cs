using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WorkingWithNodesWalkThrough
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        // return a string surrounded with parenthesis and containing
        // a comma-delimited list of parameter types, e.g.
        // "(String, String, Int32)"
        private string GetParameterList(ParameterInfo[] parameters)
        {
            StringBuilder builder = new StringBuilder("(");

            int i = 0;
            foreach (ParameterInfo parameter in parameters)
            {
                builder.Append(parameter.ParameterType.Name);
                if (++i < parameters.Length)
                    builder.Append(", ");
            }
            builder.Append(")");
            return builder.ToString();
        }

        // Get a path and load an Assembly.
        // Call private method LoadNodes() to begin reflecting
        // on the assembly contents
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Dynamic Link Libraries|*.dll|Executable|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Assembly assembly = Assembly.ReflectionOnlyLoadFrom(dialog.FileName);
                LoadNodes(tvReflection.Nodes, assembly);
            }
            lblStatus.Text = "Loaded " + Path.GetFileNameWithoutExtension(dialog.FileName);
            tvReflection.ExpandAll();
        }

        private void LoadNodes(RadTreeNodeCollection nodes, Assembly assembly)
        {
            nodes.Clear();

            // get the name, e.g. "MyDll" from the Assembly
            string assemblyName = Path.GetFileNameWithoutExtension(assembly.Location);

            // add a root node with the assembly name and a "library" icon
            // store the assembly reference itself in the tag for later retrieval
            RadTreeNode rootNode = nodes.Add(assemblyName);
            rootNode.Image = ilIcons.Images["library"];
            rootNode.Tag = assembly;

            // reflect all the types in the assembly
            foreach (Type type in assembly.GetTypes())
            {
                // only look at top level types 
                if (!type.IsNested)
                {
                    // load a node for each top level type
                    RadTreeNode typeNode = rootNode.Nodes.Add(type.Name);
                    typeNode.Tag = type;
                    if (type.IsClass)
                          typeNode.Image = ilIcons.Images["class"];

                    // drill down for further reflection on the type
                        LoadTypeNode(type, typeNode);
                }
            }
        }

        // add nodes with reflection information for constructors, methods, 
        // properties and types of the type.
        private void LoadTypeNode(Type type, RadTreeNode typeNode)
        {
            // add nodes for different categories of reflection
            RadTreeNode constructorNode = typeNode.Nodes.Add("Constructors");
            constructorNode.Image = ilIcons.Images["method"];
            RadTreeNode methodNode = typeNode.Nodes.Add("Methods");
            methodNode.Image = ilIcons.Images["method"];
            RadTreeNode propertyNode = typeNode.Nodes.Add("Properties");
            propertyNode.Image = ilIcons.Images["property"];
            RadTreeNode nestedTypeNode = typeNode.Nodes.Add("Types");

            // add nodes for each type...

            foreach (ConstructorInfo constructor in type.GetConstructors())
            {
                RadTreeNode tempNode = constructorNode.Nodes.Add(constructor.Name +
                                                                 GetParameterList(constructor.GetParameters()));
                tempNode.Tag = constructor;
            }

            foreach (MethodInfo method in type.GetMethods())
            {
                string methodText = method.Name +
                                    GetParameterList(method.GetParameters()) + ": " +
                                    method.ReturnParameter.ParameterType.Name;
                RadTreeNode tempNode = methodNode.Nodes.Add(methodText);
                tempNode.Tag = method;
            }

            foreach (PropertyInfo property in type.GetProperties())
            {
                RadTreeNode tempNode =
                propertyNode.Nodes.Add(property.Name + ": " + property.PropertyType.Name);
                tempNode.Tag = property;
            }

            foreach (Type nestedType in type.GetNestedTypes())
            {
                RadTreeNode tempNode = nestedTypeNode.Nodes.Add(nestedType.Name);
                tempNode.Tag = nestedType;
            }
        }




        private void tvReflection_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
             lblDetail.Text = String.Empty;
             if (e.Node.Tag != null)
             {
                 if (e.Node.Tag is Assembly)
                     lblDetail.Text = GetAssemblyDescription(e.Node.Tag as Assembly);
                 else if (e.Node.Tag is Type)
                     lblDetail.Text = GetTypeDescription(e.Node.Tag as Type);
                 else if (e.Node.Tag is ConstructorInfo)
                     lblDetail.Text = GetMethodDescription(e.Node.Tag as ConstructorInfo);
                 else if (e.Node.Tag is MethodInfo)
                     lblDetail.Text = GetMethodDescription(e.Node.Tag as MethodInfo);
                 else if (e.Node.Tag is PropertyInfo)
                     lblDetail.Text = GetPropertyDescription(e.Node.Tag as PropertyInfo);
             }
        }

        #region reflection description helper methods

        private string GetAssemblyDescription(Assembly assembly)
        {
            StringBuilder builder = new StringBuilder(assembly.GetName().Name);

            Version version = assembly.GetName().Version;
            builder.AppendFormat("{0}.{1}.{2}.{3}", version.Major,
                                 version.MajorRevision, version.Minor, version.MinorRevision);

            return builder.ToString();
        }

        private string GetTypeDescription(Type type)
        {
            StringBuilder builder = new StringBuilder();

            if (type.IsPublic)
                builder.Append("public ");

            if (type.IsClass)
                builder.Append("class ");
            else if (type.IsEnum)
                builder.Append("enum ");

            builder.Append(type.Name);
            builder.Append(Environment.NewLine);
            builder.Append("Name: ");
            builder.Append(type.FullName);
            builder.Append(Environment.NewLine);
            builder.Append("Assembly: ");
            builder.Append(GetAssemblyDescription(type.Assembly));

            return builder.ToString();
        }

        private string GetMethodDescription(MethodBase method)
        {
            StringBuilder builder = new StringBuilder();
            if (method.IsPublic)
                builder.Append("public ");
            if (method is MethodInfo)
                builder.Append(method.Name);
            else
                builder.Append(method.DeclaringType.Name);
            builder.Append(GetParameterList(method.GetParameters()));
            if (method is MethodInfo)
            {
                builder.Append(": ");
                builder.Append((method as MethodInfo).ReturnType.Name);
            }
            builder.Append(Environment.NewLine);
            builder.Append("Declaring Type: ");
            builder.Append(method.DeclaringType.FullName);
            builder.Append(Environment.NewLine);
            builder.Append("Assembly: ");
            builder.Append(GetAssemblyDescription(method.DeclaringType.Assembly));

            return builder.ToString();
        }

        private string GetPropertyDescription(PropertyInfo property)
        {
            StringBuilder builder = new StringBuilder();

            if (property.PropertyType.IsPublic)
                builder.Append("public ");
            builder.Append(property.PropertyType.Name);
            builder.Append(" { ");
            foreach (MethodInfo method in property.GetAccessors())
            {
                builder.AppendFormat("{0}; ", method.Name);
            }
            builder.Append(" } ");

            builder.Append(Environment.NewLine);
            builder.Append("Declaring Type: ");
            builder.Append(property.DeclaringType.FullName);
            builder.Append(Environment.NewLine);
            builder.Append("Assembly: ");
            builder.Append(GetAssemblyDescription(property.DeclaringType.Assembly));

            return builder.ToString();
        }

        #endregion

        private void miClose_Click(object sender, EventArgs e)
        {
            tvReflection.Nodes.Clear();
            lblStatus.Text = String.Empty;
            lblDetail.Text = String.Empty;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
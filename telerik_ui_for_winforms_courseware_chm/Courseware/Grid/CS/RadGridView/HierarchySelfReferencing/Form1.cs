using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Telerik.WinControls.UI;

namespace HierarchySelfReferencing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetFilesAndFolders(@"C:\Program Files (x86)\Telerik", fileFolderIndex);

            this.radGridView1.Relations.AddSelfReference(this.radGridView1.MasterTemplate, "Id", "ParentFolderId");
            this.radGridView1.DataSource = list;

            this.radGridView1.Columns["Id"].IsVisible = false;
            this.radGridView1.Columns["ParentFolderId"].IsVisible = false;
            this.radGridView1.Columns["FileSystemInfoType"].IsVisible = false;
        }

        BindingList<FileSystemItem> list = new BindingList<FileSystemItem>();
        int fileFolderIndex = 0;

        public void GetFilesAndFolders(string dir, int parentId)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            FileInfo[] rgFiles = di.GetFiles();
            foreach (FileInfo fi in rgFiles)
            {
                fileFolderIndex++;
                list.Add(new FileSystemItem(fileFolderIndex, "File", fi.Name, fi.CreationTime, parentId));
            }

            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo d in dirs)
            {
                fileFolderIndex++;
                list.Add(new FileSystemItem(fileFolderIndex, "Folder", d.Name, d.CreationTime, parentId));
                GetFilesAndFolders(d.FullName, fileFolderIndex);
            }
        }

        // Getting the images from the resources of the project
        Image documentImage = HierarchySelfReferencing.Properties.Resources.Document;
        Image folderImage = HierarchySelfReferencing.Properties.Resources.Folder;

        void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            GridDataCellElement dataCell = e.CellElement as GridDataCellElement;

            if (dataCell.ColumnInfo.Name == "Name")
            {
                GridViewDataRowInfo dataRow = dataCell.RowInfo as GridViewDataRowInfo;
                if (dataRow != null)
                {
                    dataCell.ImageAlignment = ContentAlignment.MiddleLeft;

                    string valueType = Convert.ToString(dataRow.Cells["FileSystemInfoType"].Value).ToUpperInvariant();

                    if (valueType.Contains("FILE"))
                    {
                        dataCell.Image = documentImage;
                    }
                    else
                    {
                        dataCell.Image = folderImage;
                    }

                    dataCell.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
            else
            {
                dataCell.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local);
                dataCell.ResetValue(LightVisualElement.ImageAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local);
                dataCell.ResetValue(LightVisualElement.TextImageRelationProperty, Telerik.WinControls.ValueResetFlags.Local);
                dataCell.ResetValue(LightVisualElement.ImageLayoutProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }
    }
}

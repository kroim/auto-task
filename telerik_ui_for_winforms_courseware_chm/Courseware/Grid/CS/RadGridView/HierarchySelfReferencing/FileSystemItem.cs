using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HierarchySelfReferencing
{
    public class FileSystemItem
    {
        int id;
        string name;
        DateTime creationTime;
        int parentFolderId;
        private string type;
        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string FileSystemInfoType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return creationTime;
            }
            set
            {
                creationTime = value;
            }
        }

        public int ParentFolderId
        {
            get
            {
                return parentFolderId;
            }
            set
            {
                parentFolderId = value;
            }
        }

        public FileSystemItem(int id, string type, string name, DateTime creationTime, int parentFolderId)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.creationTime = creationTime;
            this.parentFolderId = parentFolderId;
        }
    }
}

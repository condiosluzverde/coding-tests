using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace c8sciencesFileManager
{
    public class FSNode
    {
        public static string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        public string Name { get; set; }
        public string FullName { get; set; }
        public DirectoryInfo Parent { get; set; }
        public DirectoryInfo Self { get; set; }
        public List<FileInfo> Files { get; set; }
        public List<DirectoryInfo> Children { get; set; }
        public FSNode(string name)
        {
            Name = name;
            FullName = Path.IsPathRooted(Name) ? Name : Path.Combine(Directory.GetCurrentDirectory());
            Parent = Directory.GetParent(FullName);
            Self = new DirectoryInfo(FullName);
            Files = new List<FileInfo>();
            Children = new List<DirectoryInfo>();
        }

        public FSNode(FSNode node) : this(node.Name)
        {
        }

        public bool IsValid()
        {
            return Directory.Exists(FullName) && Directory.Exists(Parent.FullName);
        }

        public int TreeCopy(FSNode target)
        {
            int status = -1;

            // Create the destination folder tree
            return status;
        }

    }
}

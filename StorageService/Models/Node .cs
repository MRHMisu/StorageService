using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageService.Models
{
    public class Node
    {
        
        public String RootDirectory { get; set; }
        public String Name { get; set; }
        public String CreationTime { get; set; }
        public String LastWriteTime { get; set; }
        public String LastAccessTime { get; set; }

        public Node(String RootDirectory, String Name, String CreationTime, String LastWriteTime, String LastAccessTime)
        {
            this.RootDirectory = RootDirectory;
            this.Name = Name;
            this.CreationTime = CreationTime;
            this.LastWriteTime = LastWriteTime;
            this.LastAccessTime = LastAccessTime;

        }

    }


}
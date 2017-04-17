using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageService.Models
{
    public class StorageDirectory : Node
    {

        public long Size { get; set; }
        public int NumberOfFiles { get; set; }
        public StorageDirectory(String RootDirectory, String Name, String CreationTime, String LastWriteTime, String LastAccessTime
            , long Size, int NumberOfFiles) : base(RootDirectory, Name, CreationTime, LastWriteTime, LastAccessTime)
        {

            this.Size = Size;
            this.NumberOfFiles = NumberOfFiles;
        }

    }
}
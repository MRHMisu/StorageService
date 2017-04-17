using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageService.Models
{
    public class StorageFile : Node
    {

        public string Extention { get; set; }
        public long Size { get; set; }
        public string AccessURL { get; set; }

        public StorageFile(String RootDirectory, String Name, String CreationTime, String LastWriteTime, String LastAccessTime
            , String Extention, long Size, string AccessURL) : base(RootDirectory, Name, CreationTime, LastWriteTime, LastAccessTime)
        {
            this.Extention = Extention;
            this.Size = Size;
            this.AccessURL = AccessURL;
        }

    }
}
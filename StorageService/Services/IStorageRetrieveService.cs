using StorageService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageService.Services
{
    interface IStorageRetrieveService
    {

        List<StorageFile> GetFiles(string accessId, string baseUrl);
        StorageFile GetFileByName(string accessId, string name);
        List<StorageFile> GetFilesByExtention(string accessId, string extention);
        List<StorageDirectory> GetDirectories(string accessId);
        StorageDirectory GetDirectoryByName(string accessId, string name);
        StorageDirectory GetDirectoryWithFiles(string accessId, string name);
        List<StorageDirectory> GetDirectoriesWithFiles();
    }
}
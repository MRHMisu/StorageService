using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace StorageService.Services
{
    public class StroageModifyService : IStroageModifyService
    {

        private string _baseStoragePath = "~/FileStorage/";

        Boolean IStroageModifyService.CreateAccessId(string accessId)
        {

            string path = HttpContext.Current.Server.MapPath(_baseStoragePath + accessId);
            Directory.CreateDirectory(path);
            if (Directory.Exists(path))
            {
                return true;
            }

            return false;

        }
        bool IStroageModifyService.CreateDirectory(string accessId, string directoryName)
        {
            string path = HttpContext.Current.Server.MapPath(_baseStoragePath + accessId + "/" + directoryName);
            Directory.CreateDirectory(path);
            if (Directory.Exists(path))
            {
                return true;
            }

            return false;
        }

        bool IStroageModifyService.CreateFile(string accessId, string fileName, byte[] fileContent)
        {
            throw new NotImplementedException();
        }

        bool IStroageModifyService.MordifyDirectory(string accessId, string directoryName)
        {
            throw new NotImplementedException();
        }

        bool IStroageModifyService.MordifyFileContent(string accessId, string fileName, byte[] fileContent)
        {
            throw new NotImplementedException();
        }

        bool IStroageModifyService.MordifyFileName(string accessId, string oldFileName, string newFileName)
        {
            throw new NotImplementedException();
        }

        bool IStroageModifyService.MordifyFileNameWithContent(string accessId, string oldFileName, string newFileName, byte[] fileContent)
        {
            throw new NotImplementedException();
        }
    }
}
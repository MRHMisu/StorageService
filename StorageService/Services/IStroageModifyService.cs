using StorageService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageService.Services
{
    interface IStroageModifyService
    {

        Boolean CreateAccessId(string accessId);
        Boolean CreateFile(string accessId, string fileName, byte[] fileContent);
        Boolean MordifyFileContent(string accessId, string fileName, byte[] fileContent);
        Boolean MordifyFileName(string accessId, string oldFileName, string newFileName);
        Boolean MordifyFileNameWithContent(string accessId, string oldFileName, string newFileName, byte[] fileContent);
        Boolean CreateDirectory(string accessId, string directoryName);
        Boolean MordifyDirectory(string accessId, string directoryName);



        
    }
}

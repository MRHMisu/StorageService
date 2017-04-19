using StorageService.ClientModel;
using StorageService.Services;
using StorageService.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace StorageService.Controllers
{

    
    [RoutePrefix("api/storage")]
    public class StorageModifyServiceController : ApiController
    {
        private IStroageModifyService _storageModifyService = new StroageModifyService();



        /// <summary>  
        /// Create Access Directory
        /// </summary>  
        /// <param name="accessId"></param>

        [HttpPost]
        [Route("access")]
        public IHttpActionResult CreateAccessId([FromBody] string accessId)
        {
            if (accessId != null)
            {
                Boolean isCreated = _storageModifyService.CreateAccessId(accessId);
                Ok(isCreated);
            }
            return BadRequest("Must contain accessid");

        }


        /// <summary>  
        /// Create Directory Under Access Directory
        /// </summary>  
        /// <param name="_directoryCreationBinding"></param>

        [HttpPost]
        [Route("createDirectory")]
        public IHttpActionResult CreateDirectory(DirectoryCreationBinding _directoryCreationBinding)
        {

            if (ModelState.IsValid)
            {
                Boolean isCreated = _storageModifyService.CreateDirectory(_directoryCreationBinding.accessId, _directoryCreationBinding.directoryName);
                return Ok(isCreated);
            }
            return BadRequest("Must contain accessid, and directory name");

        }

        
        //public async Task<HttpResponseMessage> UploadFile(HttpRequestMessage request)
        //{
        //    if (!request.Content.IsMimeMultipartContent())
        //    {
        //        throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
        //    }

        //    var data = await Request.Content.ParseMultipartAsync();

        //    if (data.Files.ContainsKey("image"))
        //    {
        //        long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        //        byte[] file = data.Files["image"].File;
        //        var fileName = data.Files["image"].Filename;
        //        string path = HttpContext.Current.Server.MapPath("~/FileStorage/" + milliseconds + "-" + fileName);
        //        File.WriteAllBytes(path, file);
        //    }

        //    if (data.Fields.ContainsKey("description"))
        //    {
        //        var description = data.Fields["description"].Value;
        //    }

        //    return new HttpResponseMessage(HttpStatusCode.OK)
        //    {
        //        Content = new StringContent("FileUploaded Successfully")
        //    };
        //}


    }
}

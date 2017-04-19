using Newtonsoft.Json;
using StorageService.ClientModel;
using StorageService.Models;
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
using System.Web.Http.Description;

namespace StorageService.Controllers
{

    [RoutePrefix("api/storage")]
    public class StorageRetrieveServiceController : ApiController

    {

        private IStorageRetrieveService _storageRetrieveService = new StorageRetrieveService();



        /// <summary>  
        /// Get Files From Access Directory
        /// </summary>  
        /// <param name="accessId"></param>

        [HttpPost]
        [Route("getFiles")]
        [ResponseType(typeof(IEnumerable<StorageFile>))]
        public IHttpActionResult GetFiles([FromBody] string accessId)

        {
            var baseUrl = Request.RequestUri.GetLeftPart(UriPartial.Authority);

            if (accessId != null)
            {
                List<StorageFile> _stroageFile = _storageRetrieveService.GetFiles(accessId, baseUrl);
                return Ok(_stroageFile);
            }
            return BadRequest("Must Contain AccesId");

        }


        /// <summary>  
        /// Get Directories From Access Directory
        /// </summary>  
        /// <param name="accessId"></param>

        [HttpPost]
        [Route("getDirectories")]

        public IHttpActionResult GetDirectories([FromBody] string accessId)

        {

            if (accessId != null)
            {
                List<StorageDirectory> _stroageDirectoies = _storageRetrieveService.GetDirectories(accessId);
                return Ok(_stroageDirectoies);
            }
            return BadRequest("Must Contain AccesId");

        }

    }
}

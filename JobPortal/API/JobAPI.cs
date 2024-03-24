using JobPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.API
{
 
    [ApiController]
    [AllowAnonymous]
    public class JobAPIController : ControllerBase
    {
        DB.DBJob db = new DB.DBJob();



        [Route("api/UserAPI/postJobData")]
        [HttpPost]
        public string postJobData(ModalJob md)
        {
            return db.postJobData(md);
        }


        //[Route("api/UserAPI/postUserData")]
        //[HttpGet]
        //public IEnumerable<ModalUser> getUserData()
        //{
        //    return db.getUserData();
        //}


        //[Route("api/UserAPI/getUserDataWithId")]
        //[HttpGet]
        //public IEnumerable<ModalUser> getUserDataWithId(int id)
        //{
        //    return db.getUserDataWithId(id);
        //}

    }


}

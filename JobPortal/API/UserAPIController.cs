using JobPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.API
{
 
    [ApiController]
    [AllowAnonymous]
    public class UserAPIController : ControllerBase
    {
        DB.DBUser db = new DB.DBUser();


        //[Route("api/UserAPI/get")]
        ////  [ActionName("get")]
        //public string get()
        //{
        //    return "success";
        //}
        //ModalUser md = new ModalUser();
        [Route("api/UserAPI/postUserData")]
        [HttpPost]
        public string postUserData(ModalUser md)
        {
            return db.postUserData(md) ;
        }


        [Route("api/UserAPI/postUserData")]
        [HttpGet]
        public IEnumerable<ModalUser> getUserData()
        {
            return db.getUserData();
        }


        [Route("api/UserAPI/getUserDataWithId")]
        [HttpGet]
        public IEnumerable<ModalUser> getUserDataWithId(int id)
        {
            return db.getUserDataWithId(id);
        }

    }


}

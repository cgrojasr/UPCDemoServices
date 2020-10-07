using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UPC.Demo.BE;
using UPC.Demo.BL;

namespace UPCDemoServices.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly UserBL objUserBL;
        public UserController()
        {
            objUserBL = new UserBL();
        }

        [HttpGet]
        public IEnumerable<UserBE.Entity> ListWithFilters()
        {
            return objUserBL.ListWithFilters(null);
        }


        [HttpGet]
        [Route("Login")]
        public UserBE.Entity Login([FromBody] UserBE.Authentication objUserBE)
        {
            return objUserBL.Login(objUserBE);
        }

        [HttpPost]
        public UserBE.Entity Register([FromBody] UserBE.Entity objUserBE)
        {
            return objUserBL.Register(objUserBE);
        }

        [HttpPut]
        public UserBE.Entity Update([FromBody] UserBE.Entity objUserBE)
        {
            return objUserBL.Update(objUserBE);
        }

        [HttpPut]
        [Route("ChangePass")]
        public bool Update([FromBody] UserBE.ChangePassword objUserBE)
        {
            return objUserBL.ChangePassword(objUserBE);
        }
    }
}

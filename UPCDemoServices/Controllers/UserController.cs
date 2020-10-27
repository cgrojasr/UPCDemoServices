using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UPC.Demo.BE;
using UPC.Demo.BL;
using UPCDemoServices.Models;

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
        public Response<IEnumerable<UserBE.Entity>> ListWithFilters()
        {
            var model = new Response<IEnumerable<UserBE.Entity>>();
            try
            {
                model.response = objUserBL.ListWithFilters(null);
            }
            catch (Exception ex)
            {
                model.code = 400;
                model.description = ex.Message;
            }
            return model;
        }


        [HttpPost]
        [Route("Login")]
        public Response<UserBE.Login> Login([FromBody] UserBE.Authentication objUserBE)
        {
            var model = new Response<UserBE.Login>();
            try
            {
                model.response = objUserBL.Login(objUserBE);
            }
            catch (Exception ex)
            {
                model.code = 400;
                model.description = ex.Message;
            }
            return model;
        }

        [HttpPost]
        public Response<UserBE.Entity> Register([FromBody] UserBE.Entity objUserBE)
        {
            var model = new Response<UserBE.Entity>();
            try
            {
                model.response = objUserBL.Register(objUserBE);
            }
            catch (Exception ex)
            {
                model.code = 400;
                model.description = ex.Message;
            }
            return model;
        }

        [HttpPut]
        public Response<UserBE.Entity> Update([FromBody] UserBE.Entity objUserBE)
        {
            var model = new Response<UserBE.Entity>();
            try
            {
                model.response = objUserBL.Update(objUserBE);
            }
            catch (Exception ex)
            {
                model.code = 400;
                model.description = ex.Message;
            }
            return model;
        }

        [HttpPut]
        [Route("ChangePassword")]
        public Response<bool> ChangePassword([FromBody] UserBE.ChangePassword objUserBE)
        {
            var model = new Response<bool>();
            try
            {
                model.response = objUserBL.ChangePassword(objUserBE);
            }
            catch (Exception ex)
            {
                model.code = 400;
                model.description = ex.Message;
            }
            return model;
        }
    }
}

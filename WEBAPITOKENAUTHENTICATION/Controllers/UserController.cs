using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace WEBAPITOKENAUTHENTICATION.Controllers
{
    public class UserController : ApiController
    {

        [AllowAnonymous]
        [HttpGet]
        [Route("api/data/Home")]
        public IHttpActionResult Get()
        {
            return Ok("Selamat datang, ini adalah halaman Home ");
        }

        [Authorize]
        [HttpGet]
        [Route("api/data/authenticate")]
        public IHttpActionResult GetForAuthenticate()
        {
            var identity = (ClaimsIdentity)User.Identity;
            return Ok("Hello " + identity.Name);
        }
    }
}

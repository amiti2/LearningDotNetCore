using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Authenticate([FromBody] string password)
        {
            return password;
        }

        #region "Test APIs"
        //[HttpGet]
        //public ActionResult<List<string>> Get()
        //{
        //    List<string> users = new();
        //    users.Add("amit");
        //    users.Add("rajan");
        //    return users;
        //}

        //this will break swagger. Move it to private
        //public ActionResult<List<string>> Put()
        //{
        //    List<string> users = new();
        //    users.Add("amit");
        //    users.Add("rajan");
        //    return users;
        //}

        //[HttpGet(template:"aa")]
        //public ActionResult<List<string>> Get2()
        //{
        //    List<string> users = new();
        //    users.Add("amit");
        //    users.Add("rajan");
        //    return users;
        //}
        #endregion
    }
}

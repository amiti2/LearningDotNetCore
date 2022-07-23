using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public record AuthenticationData(string? Username, string? Password);
        public record Userdata(int UserId, string UserName);

        [HttpPost("token")]
        public ActionResult<string> Authenticate([FromBody] AuthenticationData data)
        {
            var userdata = ValidateCredentials(data);
            if (userdata != null)
            {
                return userdata!.UserName;
            }
            return Unauthorized();
        }

        private Userdata? ValidateCredentials(AuthenticationData data)
        {
            //THIS IS NOT PRODUCTION CODE - THIS IS DEMO - DONT USE IT IN REAL LIFE
            if(CompareValues(data.Username, "airodha") && CompareValues(data.Password,"Admin$11"))
            {
                return new Userdata(UserId: 1, UserName: data.Username!);
            }
            if (CompareValues(data.Username, "rsidhpuria") && CompareValues(data.Password, "Admin$11"))
            {
                return new Userdata(UserId: 2, UserName: data.Username!);
            }
            return null;
        }

        private bool CompareValues(string? actual, string expected)
        {
            if(actual != null)
            {
                if(actual.Equals(expected))
                {
                    return true;
                }
            }
            return false;
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

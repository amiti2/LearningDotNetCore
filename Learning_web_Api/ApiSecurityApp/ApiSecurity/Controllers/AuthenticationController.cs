using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration config;

        public record AuthenticationData(string? Username, string? Password);
        public record Userdata(int UserId, string UserName);

        public AuthenticationController(IConfiguration config)
        {
            this.config = config;
        }

        [HttpPost("token")]
        public ActionResult<string> Authenticate([FromBody] AuthenticationData data)
        {
            var userdata = ValidateCredentials(data);
            if (userdata != null)
            {
                return GenerateToken(userdata);
            }
            return Unauthorized();
        }

        private string GenerateToken(Userdata user)
        {
            SymmetricSecurityKey secretkey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(
                this.config.GetValue<string>("Authentication:SecretKey")
                ));

            SigningCredentials signingCredentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new();
            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.UserId.ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName));

            var token = new JwtSecurityToken(issuer: config.GetValue<string>("Issuer"),
                                            audience: config.GetValue<string>("Audience"),
                                            claims:claims,
                                            DateTime.UtcNow,
                                            DateTime.UtcNow.AddMinutes(1),
                                            signingCredentials
                                          );


            return new JwtSecurityTokenHandler().WriteToken(token);
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

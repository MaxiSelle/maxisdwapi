using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {


        public AuthenticationController()
        {
        }
        [HttpPost("Login")]

        public async Task<ActionResult<bool>> Login([FromBody] LoginAttempt lg)
        {

            if (lg.Password == "kek")
                return true;
            return false;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<bool>> CreateUser([FromBody] LoginAttempt lg)
        {


            return false;
        }

    }

    public class LoginAttempt
    {
        public string Password { get; set; }
        public string UserName { get; set; }
    }

}

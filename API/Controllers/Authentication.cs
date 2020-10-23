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
    public class Authentication : ControllerBase
    {


        [HttpPost("Login")]

        public async Task<ActionResult<bool>> Login([FromBody] LoginAttempt lg)
        {
            if (lg.password == "kek")
                return true;
            return false;
        }

    }

    public class LoginAttempt
    {
        public string password { get; set; }
    }

}

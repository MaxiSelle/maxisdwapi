using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class DWUser : IdentityUser
    {
        public DWUser():base()
        {
        }

        public String SwagLvl { get; set; }
    }
}

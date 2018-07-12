using System;
using System.Collections.Generic;
using System.Text;

namespace BDTools.Domain.Entitys
{
    public class User : IdentityUser
    {
        public string FamilyName { get; set; }
        public string Email { get; set; }
    }
}

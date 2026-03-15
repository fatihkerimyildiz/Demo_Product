using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>    //Database deki AspNetUsers tablosuna karşılık gelir ve bu bir primary key ister(id)
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Gender { get; set; }

    }
}

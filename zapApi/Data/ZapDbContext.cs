using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zapApi.Models.Identity;

namespace zapApi.Data
{
    public class ZapDbContext : IdentityDbContext<ZapUser>
    {
        public ZapDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPUser.Models;

namespace RPUser.Data
{
    public class RPUserContext : DbContext
    {
        public RPUserContext (DbContextOptions<RPUserContext> options)
            : base(options)
        {
        }

        public DbSet<RPUser.Models.User> User { get; set; }
    }
}

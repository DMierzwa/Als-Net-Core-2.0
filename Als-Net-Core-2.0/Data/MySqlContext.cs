using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Als_Net_Core_2.Models;

namespace Als_Net_Core_2.Data
{
    //public class MySqlContext : IdentityDbContext<ApplicationUser>
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<League> Leagues { get; set; }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public class CatContext : IdentityDbContext
    {
        DbSet<Cat> Cats { get; set; }
        DbSet<CatBread> CatBreads { get; set; }
        DbSet<User> users { get; set; }
        public CatContext(DbContextOptions<CatContext> options) : base(options)
        {

        }
    }
}

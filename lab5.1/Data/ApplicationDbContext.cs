using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using lab5._1.Components.Class;

namespace lab5._1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<lab5._1.Components.Class.Movie> Movie { get; set; } = default!;

       


    }
}

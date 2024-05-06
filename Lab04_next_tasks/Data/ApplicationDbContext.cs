using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab04_next_tasks.Components;

namespace Lab04_next_tasks.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Lab04_next_tasks.Components.Movie> Movie { get; set; } = default!;
    }
}

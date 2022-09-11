using Microsoft.EntityFrameworkCore;
using WellaMvcProject.Models;

namespace WellaMvcProject.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserData> UserDataTable { get; set; }
    }
}
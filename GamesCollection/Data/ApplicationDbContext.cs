using GamesCollection.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace GamesCollection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GameDbModel> Games { get; set; }
        public DbSet<ReviewDbModel> Reviews { get; set; }
    }
}

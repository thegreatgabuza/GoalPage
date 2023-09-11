using GoalPage.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoalPage.Data
{
    public class GoalPageDbContext : DbContext
    {
        public GoalPageDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Goal> Goals { get; set; }
    }
}

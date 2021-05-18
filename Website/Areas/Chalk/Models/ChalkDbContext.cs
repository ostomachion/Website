using Microsoft.EntityFrameworkCore;

namespace Website.Areas.Chalk.Models
{
    public class ChalkDbContext : DbContext
    {
        public ChalkDbContext(DbContextOptions opts) : base(opts) { }

        public DbSet<ChalkDrawing> ChalkDrawings { get; set; }
    }
}
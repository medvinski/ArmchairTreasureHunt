using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArmchairTreasureHunt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		public DbSet<ArmchairTreasureHunt.Models.Notebook1> Notebook1 { get; set; }
		public DbSet<ArmchairTreasureHunt.Models.Notebook2> Notebook2 { get; set; }
		public DbSet<ArmchairTreasureHunt.Models.Notebook3> Notebook3 { get; set; }
	}
}
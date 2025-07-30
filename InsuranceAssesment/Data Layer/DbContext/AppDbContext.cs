using Microsoft.EntityFrameworkCore;

namespace InsuranceAssesment.Data_Layer.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Policy> Policies { get; set; }
    }
}

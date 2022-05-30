using Microsoft.EntityFrameworkCore;
using lcs_core_console.Entities;
using System.Reflection;

namespace lcs_core_console.Repositories
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data Source=localhost;initial catalog=lcs-core;integrated security=false;persist security info=true;user id=sa;password=@Abc1234;Connection Timeout=120");
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(), t => t.Namespace == "lcs_core_console.Repositories.Mappings");
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
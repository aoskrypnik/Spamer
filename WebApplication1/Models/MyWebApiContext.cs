using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Department)
                .WithMany()
                .HasForeignKey(u => u.DepartmentId);
        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Message> Messages { get; set; }

    }
}
using ApplicationDB.Tables;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=local;Username=postgres;Password=qwer");
        }
    }
}
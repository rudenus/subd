using ApplicationDB.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ApplicationDB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }

        private readonly StreamWriter _logStream = new StreamWriter("../../../../mylog.txt", append: true);
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(_logStream.WriteLine, LogLevel.Information);
            
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=local;Username=postgres;Password=qwer");
        }
        public override void Dispose()
        {
            base.Dispose();
            _logStream.Dispose();
        }
    }
}
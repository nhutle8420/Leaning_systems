using Leaning_system.Models;
using Microsoft.EntityFrameworkCore;

namespace Leaning_system.DBContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Leaning_system.Models.Examl_detial>? Examl_detial { get; set; }
        public DbSet<Leaning_system.Models.Scord>? Scord { get; set; }
        public DbSet<Leaning_system.Models.test_schedule>? test_schedule { get; set; }
    }









}


using Leaning_system.Models;
using Microsoft.EntityFrameworkCore;

namespace Leaning_system.DBContext
{
    public class DataContext:DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Examl_detial> examl_Detials { get; set; }
        
        public DbSet<Chat> chats { get; set; }
        public DbSet<Scord> scords { get; set; }
        public DbSet<test_schedule> test_Schedules { get; set; }
        
    }
}

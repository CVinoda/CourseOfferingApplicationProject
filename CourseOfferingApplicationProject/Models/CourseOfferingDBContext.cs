using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CourseOfferingApplicationProject.Models.Mapping;

namespace CourseOfferingApplicationProject.Models
{
    public partial class CourseOfferingDBContext : DbContext
    {
        static CourseOfferingDBContext()
        {
            Database.SetInitializer<CourseOfferingDBContext>(null);
        }

        public CourseOfferingDBContext()
            : base("Name=CourseOfferingDBContext")
        {
        }

        public DbSet<Cours> Courses { get; set; }
        public DbSet<CourseXUser> CourseXUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CoursMap());
            modelBuilder.Configurations.Add(new CourseXUserMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CourseOfferingApplicationProject.Models.Mapping
{
    public class CourseXUserMap : EntityTypeConfiguration<CourseXUser>
    {
        public CourseXUserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CourseId, t.UserId });

            // Properties
            this.Property(t => t.CourseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CourseXUser");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}

using NoticeBoardDtos.Input.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic.EntityConfiguration.Users
{
    class UsersConfiguration : EntityTypeConfiguration<UserProfile>
    {
        public UsersConfiguration()
        {
            this.HasKey(a => a.UserProfileId).Property(a=>a.UserProfileId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.FirstName).HasMaxLength(100).IsRequired();

            this.Property(a => a.LastName).HasMaxLength(100).IsRequired();

            this.Property(a => a.EmailAddress).HasMaxLength(50).IsRequired();

            this.Property(a => a.MobileNumber).HasMaxLength(10).IsRequired();
            
            this.Property(a => a.Gender).IsRequired();

            this.Property(a => a.UserName).HasMaxLength(100).IsRequired();

            this.Property(a => a.Password).HasMaxLength(50).IsRequired();

            this.Property(a => a.ConfirmPassword).HasMaxLength(50).IsRequired();

            this.HasMany(a => a.OtherAreasOfInterest).WithRequired(a => a.UserProfile).HasForeignKey(a => a.UserId);

            this.ToTable("UserProfile");
        }
    }
}

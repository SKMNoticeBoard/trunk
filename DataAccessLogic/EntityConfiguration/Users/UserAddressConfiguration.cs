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
    class UserAddressConfiguration : EntityTypeConfiguration<UserAddress>
    {
        public UserAddressConfiguration()
        {
            this.HasKey(a => a.UserAddressId).Property(a=>a.UserAddressId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.Province).HasMaxLength(50).IsRequired();

            this.Property(a => a.Town).HasMaxLength(50).IsRequired();

            this.Property(a => a.SuburbName).HasMaxLength(50).IsRequired();

            this.Property(a => a.StreetName).HasMaxLength(50).IsRequired();

            this.Property(a => a.LocalMunicipality).HasMaxLength(100).IsRequired();

            this.Property(a => a.PostalCode).HasMaxLength(4).IsRequired();

            this.Property(a => a.HouseNumber).HasMaxLength(10).IsOptional();

            this.Property(a => a.Ward).IsRequired();

            this.HasRequired(a => a.UserProfile).WithRequiredDependent(a => a.UserAddress);

            this.ToTable("UserAddress");
        }
    }
}

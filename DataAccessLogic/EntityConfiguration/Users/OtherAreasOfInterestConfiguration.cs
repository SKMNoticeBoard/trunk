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
    class OtherAreasOfInterestConfiguration:EntityTypeConfiguration<OtherAreasOfInterest>
    {
        public OtherAreasOfInterestConfiguration()
        {
            this.HasKey(a => a.OtherAreasOfInterestId).Property(a => a.OtherAreasOfInterestId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.UserId).IsRequired();

            this.Property(a => a.Subscribed).IsRequired();

            this.Property(a => a.SubscriptionType).IsRequired();

            this.Property(a => a.Province).IsRequired();

            this.Property(a => a.Town).IsRequired();

            this.Property(a => a.LocalMunicipality).IsRequired();

            this.Property(a => a.Ward).IsRequired();

            this.ToTable("OtherAreasOfInterest");
        }
    }
}

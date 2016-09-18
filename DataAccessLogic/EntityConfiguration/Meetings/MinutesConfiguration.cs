using NoticeBoardDtos.Input.Meetings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic.EntityConfiguration.Meetings
{
    class MinutesConfiguration: EntityTypeConfiguration<Minutes>
    {
        public MinutesConfiguration()
        {
            this.HasKey(a => a.MinutesId).Property(a => a.MinutesId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.MeetingId).IsRequired();

            this.Property(a => a.Date).IsRequired();

            this.Property(a => a.Time).IsRequired();

            this.Property(a => a.MeetingType).HasMaxLength(100).IsRequired();

            this.Property(a => a.Venue).HasMaxLength(100).IsRequired();

            this.Property(a => a.Organizer).HasMaxLength(100).IsRequired();

            this.Property(a => a.Facilitator).HasMaxLength(100).IsRequired();

            this.Property(a => a.TimeKeeperName).HasMaxLength(100).IsRequired();

            this.Property(a => a.NumberOfAttendees).IsRequired();

            this.HasMany(a => a.MeetingItems).WithRequired(a => a.Minutes);

            this.ToTable("Minutes");
        }
    }
}

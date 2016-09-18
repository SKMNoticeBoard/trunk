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
    class MeetingItemConfiguration : EntityTypeConfiguration<MeetingItem>
    {
        public MeetingItemConfiguration()
        {
            this.HasKey(a => a.MeetingItemId).Property(a => a.MeetingItemId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.MinutesId).IsRequired();

            this.Property(a => a.TimeAllocated).IsRequired();

            this.Property(a => a.DeadLine).IsRequired();

            this.Property(a => a.TopicOfDiscussion).HasMaxLength(200).IsRequired();

            this.Property(a => a.PresenterName).HasMaxLength(100).IsRequired();

            this.Property(a => a.DiscussionSummary).HasMaxLength(5000).IsRequired();

            this.Property(a => a.Conclusion).HasMaxLength(5000).IsRequired();

            this.Property(a => a.DiscussionSummary).HasMaxLength(5000).IsRequired();

            this.HasMany(a => a.ItemsOfAction).WithRequired(a => a.MeetingItem);

            this.ToTable("MeetingItem");
        }
    }
}

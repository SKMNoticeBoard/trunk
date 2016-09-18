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
    class ItemOfActionConfiguration : EntityTypeConfiguration<ItemOfAction>
    {
        public ItemOfActionConfiguration()
        {
            this.HasKey(a => a.ItemOfActionId).Property(a => a.ItemOfActionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.ItemName).HasMaxLength(100).IsRequired();

            this.Property(a => a.MeetingItemId).IsRequired();

            this.Property(a => a.ResponsiblePerson).HasMaxLength(100).IsRequired();

            this.Property(a => a.DeadLine).IsRequired();

            this.ToTable("ItemOfAction");
        }
    }
}

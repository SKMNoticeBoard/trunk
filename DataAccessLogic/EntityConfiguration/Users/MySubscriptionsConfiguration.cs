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
    class MySubscriptionsConfiguration: EntityTypeConfiguration<MySubscriptions>
    {
        public MySubscriptionsConfiguration()
        {
            this.HasKey(a => a.SubscriptionId).Property(a => a.SubscriptionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.UserId).IsRequired();

            this.Property(a => a.Subscribed).IsRequired();

            this.Property(a => a.URLIcon).IsRequired();

            this.Property(a => a.SubscriptionType).IsRequired();

            this.HasRequired(a => a.UserProfile).WithRequiredDependent(a => a.MySubscriptions);

            this.ToTable("MySubscriptions");
        }
    }
}

using DataAccessLogic.EntityConfiguration.Users;
using NoticeBoardDtos.Input;
using NoticeBoardDtos.Input.Meetings;
using NoticeBoardDtos.Input.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic.DBContext
{
    public class NoticeBoardDbContext : DbContext
    {
        public NoticeBoardDbContext()
            : base("NoticeBoard")
        {

        }
        public IDbSet<UserProfile> UserProfile { get; set; }
        public IDbSet<UserAddress> UserAddress { get; set; }
        public IDbSet<OtherAreasOfInterest> OtherAreasOfInterest { get; set; }
        public IDbSet<MySubscriptions> MySubscriptions { get; set; }
        public IDbSet<Agenda> Agenda { get; set; }
        public IDbSet<Meeting> Meeting { get; set; }
        public IDbSet<MeetingLocation> MeetingLocation { get; set; }
        public IDbSet<Event> Event { get; set; }
        public IDbSet<EventLocation> EventLocation { get; set; }
        public IDbSet<EventSpeaker> EventSpeaker { get; set; }
        public IDbSet<EventSubActivity> EventSubActivity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MySubscriptionsConfiguration());
            modelBuilder.Configurations.Add(new OtherAreasOfInterestConfiguration());
            modelBuilder.Configurations.Add(new UserAddressConfiguration());
            modelBuilder.Configurations.Add(new UsersConfiguration());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Meetings
{
    public class Minutes
    {
        public int MinutesId { get; set; }
        public int MeetingId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string MeetingType { get; set; }
        public string Venue { get; set; }
        public string Organizer { get; set; }
        public string Facilitator { get; set; }
        public string TimeKeeperName { get; set; }
        public int NumberOfAttendees { get; set; }
        public ICollection<MeetingItem> MeetingItems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Meetings
{
    public class NextMeetingDetails
    {
        public int NextMeetingDetailsId { get; set; }
        public int MeetingId { get; set; }
        public DateTime NextMeetingDetailsDate { get; set; }
        public DateTime NextMeetingDetailsTime { get; set; }
        public string City { get; set; }
        public int Saburb { get; set; }
        public int Street { get; set; }
        public int HouseNumber { get; set; }
        public Meeting Meeting { get; set; }
    }
}

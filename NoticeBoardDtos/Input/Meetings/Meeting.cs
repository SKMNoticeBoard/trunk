using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Meetings
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
        public string ihhconUrl { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string ShortDescription { get; set; }
        public MeetingLocation Location { get; set; }
    }
}

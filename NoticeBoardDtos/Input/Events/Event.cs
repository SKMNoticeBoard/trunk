using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
        public DateTime Date { get; set; }
        public string ShortDescription { get; set; }
        public List<EventSpeaker> Speakers { get; set; }
        public List<EventSubActivity> SubActivities { get; set; }
        public EventLocation Location { get; set; }
    }
}

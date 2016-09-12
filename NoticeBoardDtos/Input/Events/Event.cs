using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input
{
    public class Event
    {
        public Event()
        {
            this.Speakers = new HashSet<EventSpeaker>();
            this.SubActivities = new HashSet<EventSubActivity>();
        }
        [Key]
        public int EventId { get; set; }
        public int EventLocationId { get; set; }
        public int EventSpeakerId { get; set; }
        public int EventSubActivityId { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
        public DateTime Date { get; set; }
        public string ShortDescription { get; set; }
        public virtual EventLocation Location { get; set; }
        public ICollection<EventSpeaker> Speakers { get; set; }
        public ICollection<EventSubActivity> SubActivities { get; set; }
    }
}

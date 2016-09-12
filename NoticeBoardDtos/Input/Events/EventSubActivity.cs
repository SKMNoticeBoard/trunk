using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input
{
    public class EventSubActivity
    {
        [Key]
        public int EventSubActivityId { get; set; }
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string Type { get; set; }
        public string Room { get; set; }
        public DateTime Date { get; set; }
        public Event Event { get; set; }
    }
}

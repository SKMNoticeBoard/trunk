using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input
{
    public class EventSubActivity
    {
        public int EventSubActivityId { get; set; }
        public string Title { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string Type { get; set; }
        public string Room { get; set; }
        public DateTime Date { get; set; }
    }
}

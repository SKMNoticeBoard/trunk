using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input
{
    public class EventSpeaker
    {
        public int EventSpeakerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Background { get; set; }
        public string IconUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoticeBoardDtos.Input.Meetings
{
    public class MeetingLocation
    {
        public int MeetingLocationId { get; set; }
        public string City { get; set; }
        public int Saburb { get; set; }
        public int Street { get; set; }
        public int HouseNumber { get; set; }
    }
}

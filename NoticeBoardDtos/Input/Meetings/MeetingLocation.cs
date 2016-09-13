using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NoticeBoardDtos.Input.Meetings
{
    public class MeetingLocation
    {
        [Key]
        public int MeetingLocationId { get; set; }
        public int MeetingId { get; set; }
        public string City { get; set; }
        public int Saburb { get; set; }
        public int Street { get; set; }
        public int HouseNumber { get; set; }
    }
}

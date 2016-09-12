using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input
{
    public class EventLocation
    {
        public int EventLocationId { get; set; }
        public string City { get; set; }
        public int Saburb { get; set; }
        public int Street { get; set; }
        public int HouseNumber { get; set; }
    }
}

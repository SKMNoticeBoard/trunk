using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Enums
{
    public class Enums
    {
        public enum Gender
        {
            Male,
            Female,
            Unknown
        }

        public enum Subscriptions
        {
            Meetings,
            Events, 
            PastMeetings,
            PastEvents
        }
    }
}

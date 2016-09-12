using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Meetings
{
    public class Agenda
    {
        [Key]
        public int AgendaId { get; set; }

        public string MeetingInformation { get; set; }

        public string AdditionInformation { get; set; }

        public string CallToOrder { get; set; }

        public string PledgeOfPreviousMeetingMinutes { get; set; }
    }
}

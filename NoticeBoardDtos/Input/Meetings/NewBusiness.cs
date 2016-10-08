using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Meetings
{
    public class NewBusiness
    {
        public int NewBusinessId { get; set; }
        public int AgendaId { get; set; }
        public string Presenter { get; set; }
        public string Content { get; set; }
        public Agenda Agenda { get; set; }
    }
}

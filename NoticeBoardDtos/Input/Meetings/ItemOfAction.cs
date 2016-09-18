using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoticeBoardDtos.Input.Meetings
{
    public class ItemOfAction
    {
        public int ItemOfActionId { get; set; }
        public string ItemName { get; set; }
        public int MeetingItemId { get; set; }
        public string ResponsiblePerson { get; set; }
        public DateTime DeadLine { get; set; }
        public MeetingItem MeetingItem { get; set; }
    }
}

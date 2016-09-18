using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoticeBoardDtos.Input.Meetings
{
    public class MeetingItem
    {
        public int MeetingItemId { get; set; }
        public int MinutesId { get; set; }
        public DateTime TimeAllocated { get; set; }
        public DateTime DeadLine { get; set; }
        public string TopicOfDiscussion { get; set; }
        public string PresenterName { get; set; }
        public string DiscussionSummary { get; set; }
        public string Conclusion { get; set; }
        public Minutes Minutes { get; set; }
        public ICollection<ItemOfAction> ItemsOfAction { get; set; }
    }
}

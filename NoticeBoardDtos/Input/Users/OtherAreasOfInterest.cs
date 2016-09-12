using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Users
{
    public class OtherAreasOfInterest
    {
        [Key]
        public int OtherAreasOfInterestId { get; set; }
        public int UserId { get; set; }
        public bool Subscribed { get; set; }
        public NoticeBoardDtos.EnumServices.EnumServices.Subscriptions SubscriptionType { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
        public string LocalMunicipality { get; set; }
        public int Ward { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Users
{
   public class OtherAreasOfInterest
    {
       public int OtherAreasOfInterestId { get; set; }
       public int UserId { get; set; }
       public bool Subscribed { get; set; }
       public NoticeBoardDtos.Enums.Enums.Subscriptions SubscriptionType { get; set; }
       public UserProfile UserProfile { get; set; }
    }
}

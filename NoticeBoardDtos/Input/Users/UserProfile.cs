using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoticeBoardDtos.Enums;

namespace NoticeBoardDtos.Input.Users
{
   public class UserProfile
    {
       public UserProfile()
       {
           this.OtherAreasOfInterest = new HashSet<OtherAreasOfInterest>();
       }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string IdNumber { get; set; }
       public string EmailAddress { get; set; }
       public string MobileNumber { get; set; }
       public Enums.Enums.Gender Gender { get; set; }
       public Login Credentials { get; set; }
       public string ConfirmPassword { get; set; }
       public UserAddressDetails ResidentialDetails { get; set;}
       public virtual MySubscriptions MySubscriptions { get; set;}
       public virtual ICollection<OtherAreasOfInterest> OtherAreasOfInterest { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoticeBoardDtos.Input.Users
{
   public class UserProfile
    {
       public UserProfile()
       {
           this.OtherAreasOfInterest = new HashSet<OtherAreasOfInterest>();
       }
       public int UserProfileId { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string EmailAddress { get; set; }
       public string MobileNumber { get; set; }
       public NoticeBoardDtos.EnumServices.EnumServices.Gender Gender { get; set; }
       public string UserName { get; set; }
       public string Password { get; set; }
       public string ConfirmPassword { get; set; }
       public virtual UserAddress UserAddress { get; set; }
       public virtual MySubscriptions MySubscriptions { get; set;}
       public virtual ICollection<OtherAreasOfInterest> OtherAreasOfInterest { get; set;}
    }
}

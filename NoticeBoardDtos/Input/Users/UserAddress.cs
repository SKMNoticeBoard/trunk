using NoticeBoardDtos.Input.UserLocationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Users
{
    public class UserAddress
    {
        public int UserAddressId { get; set; }
        public int UserProfileId { get; set; }
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string SuburbName { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
        public string LocalMunicipality { get; set; }
        public int Ward { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
 
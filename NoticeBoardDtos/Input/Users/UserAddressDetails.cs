using NoticeBoardDtos.Input.UserLocationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.Users
{
    public class UserAddressDetails
    {
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string SuburbName { get; set; }
        public string PostalCode { get; set; }
        public Province Province { get; set; }
        public Town Town { get; set; }
        public LocalMunicipality LocalMunicipality { get; set; }

    }
}

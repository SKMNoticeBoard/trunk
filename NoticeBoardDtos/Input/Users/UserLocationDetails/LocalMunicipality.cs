using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.UserLocationDetails
{
    public class LocalMunicipality
    {
        public int LocalMunicipalityId { get; set; }
        public string LocalMunicipalityName { get; set; }
        public int Wards { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.UserLocationDetails
{
    public class LocalMunicipality
    {
        public LocalMunicipality()
        {
            this.Wards = new HashSet<Ward>();
        }
        public int LocalMunicipalityId { get; set; }
        public int WardId { get; set; }
        public string LocalMunicipalityName { get; set; }
        public ICollection<Ward> Wards { get; set; }
    }
}

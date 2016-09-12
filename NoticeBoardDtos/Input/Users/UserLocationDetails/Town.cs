using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.UserLocationDetails
{
    
    public class Town
    {
        public int TownId { get; set; }
        public int ProvinceId { get; set; }
        public string TownName { get; set; }
        public List<LocalMunicipality> LocalMunicipality { get; set; }
    }
}

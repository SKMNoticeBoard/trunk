using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.UserLocationDetails
{
    
    public class Town
    {
        [Key]
        public int TownId { get; set; }
        public int ProvinceId { get; set; }
        public string TownName { get; set; }
        public ICollection<LocalMunicipality> LocalMunicipality { get; set; }
    }
}

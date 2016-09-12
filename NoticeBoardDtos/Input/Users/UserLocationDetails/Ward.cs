using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.UserLocationDetails
{
    public class Ward
    {
        [Key]
        public int WardId { get; set; }
        public int WardNumber { get; set; }
        public LocalMunicipality LocalMunicipality { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.UserLocationDetails
{
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }
        public int ProvinceName { get; set; }
        public ICollection<Town> Towns { get; set; }
    }
}

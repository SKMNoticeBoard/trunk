using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardDtos.Input.UserLocationDetails
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public int ProvinceName { get; set; }
        public List<Town> Towns { get; set; }
    }
}

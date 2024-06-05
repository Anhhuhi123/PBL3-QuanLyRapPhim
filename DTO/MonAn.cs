using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {
        public int Id { get; set; }
        public string TenMonAn { get; set; }
        public double GiaTien { get; set; }
        public MonAn(int id, string tenMonAn, double giaTien)
        {
            Id = id;
            TenMonAn = tenMonAn;
            GiaTien = giaTien;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VeDuocDat : PhongChieu
    {
        public int Id { get; set; }
        public int SoVe { get; set; }
        public float TongTien { get; set; } 
        public bool TrangThai { get; set; }
        public string HinhThuc { get; set; }
        public VeDuocDat() { }
    }
}

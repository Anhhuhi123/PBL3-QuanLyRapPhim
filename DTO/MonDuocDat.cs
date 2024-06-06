using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonDuocDat :MonAn
    {
        public int SoLuong { get; set; }
        public MonDuocDat(int id,string tenMonAn, double giaTien, int soLuong)
            : base(id, tenMonAn, giaTien)
        {
            SoLuong = soLuong;
        }
    }
}

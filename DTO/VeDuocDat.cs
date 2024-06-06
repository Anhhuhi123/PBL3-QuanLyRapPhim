using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VeDuocDat 
    {
        public int Id { get; set; }
        public int SoVe { get; set; }
        public double TongTien { get; set; } 
        public VeDuocDat(int id,int sove, double tongtien) {
            Id=id;
            SoVe = sove;
            TongTien = tongtien;
        }
        public VeDuocDat() { }
    }
}

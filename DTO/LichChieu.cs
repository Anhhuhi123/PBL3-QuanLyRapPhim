using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieu
    {
        public String Id { get; set; }
        public string TenPhim { get; set; }
        public string TenNVQL { get; set; }
        public DateTime NgayChieu { get; set; }
        public int GioChieu { get; set; }
        public int GioKetThuc { get; set; }
        public LichChieu(String id, string tenphim, string tennvql, DateTime ngayChieu, int gioChieu,int gioketthuc)
        {
            Id = id;
            TenNVQL = tennvql;
            TenPhim = tenphim;
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
            GioKetThuc= gioketthuc;
        }
    }
}

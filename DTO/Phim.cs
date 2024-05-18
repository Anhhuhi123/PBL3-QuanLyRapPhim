using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phim
    {
        public int Id { get; set; }
        public string TenPhim { get; set; }
        public string TheLoai { get; set; }
        public int ThoiLuong { get; set; }
        public string Mota { get; set; }
        public Phim(int id, string tenPhim, string theLoai, int thoiLuong, string mota)
        {
            Id = id;
            TenPhim = tenPhim;
            TheLoai = theLoai;
            ThoiLuong = thoiLuong;
            Mota = mota;
        }
    }
}

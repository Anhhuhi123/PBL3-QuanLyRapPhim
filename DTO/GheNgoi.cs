using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GheNgoi
    {
        public int Id { get; set; }
        public int IdPhong { get; set; }
        public int IdLichChieu { get; set; }
        public bool TrangThai { get; set; }
        public GheNgoi(int id, int idPhong,int idlich, bool trangThai)
        {
            Id = id;
            IdPhong = idPhong;
            IdLichChieu = idlich;
            TrangThai = trangThai;
        }
    }
}

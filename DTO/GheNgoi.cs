using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GheNgoi
    {
        public static List<string> TenGhe = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "K", "M" };
        public int Id { get; set; }
        public bool TrangThai { get; set; }
        public GheNgoi(int id, bool trangThai)
        {
            Id = id;
            TrangThai = trangThai;
        }
        public override string ToString()
        {
            int row = (Id-1) / 10;
            int col= (Id-1) % 10+1;
            return TenGhe[row] + col;
        }
    }
}

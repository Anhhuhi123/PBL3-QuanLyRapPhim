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
        public bool TrangThai { get; set; }
        public GheNgoi(int id, bool trangThai)
        {
            Id = id;
            TrangThai = trangThai;
        }
    }
}

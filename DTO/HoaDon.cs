using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int Id { get; set; }
        public float TongTien { get; set; }
        public string MoTa { get; set; }
        public string TenKhach { get; set; }
        public string TenNVBH { get; set; }
        public HoaDon(int id, float tongTien, string moTa, string tenKhach, string tenNVBH)
        {
            Id = id;
            TongTien = tongTien;
            MoTa = moTa;
            TenKhach = tenKhach;
            TenNVBH = tenNVBH;
        }
    }
}

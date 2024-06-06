using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int Id { get;  set; }
        public string TenPhim { get; set; }
        public double TongTien { get; set; }
        public string GhiChu { get; set; }
        public string TenKhach { get; set; }
        public string TenNVBH { get; set; }
        public HoaDon(int id,string tenphim,double tongTien, string ghiChu, string tenKhach, string tenNVBH)
        {
            Id = id;
            TenPhim = tenphim;
            TongTien = tongTien;
            GhiChu = ghiChu;
            TenKhach = tenKhach;
            TenNVBH = tenNVBH;
        }
        public HoaDon()
        {

        }
    }
}

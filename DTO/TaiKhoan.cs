using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string TenTK { get; set; }
        public string MatKhau { get; set; }

        public TaiKhoan(string tenTK, string matKhau)
        {
            TenTK = tenTK;
            MatKhau = matKhau;
        }
    }
}

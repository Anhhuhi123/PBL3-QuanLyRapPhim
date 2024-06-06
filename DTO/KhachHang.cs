using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang : NguoiDung
    {
        public KhachHang(string id, string ten, string sdt, string email, string vaitro) : base(id, ten, sdt, email,vaitro)
        {
        }
    }
}

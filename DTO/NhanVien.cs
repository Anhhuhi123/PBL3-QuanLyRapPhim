using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien : NguoiDung
    {
        public bool Active { get; set; }
        public NhanVien(String id, string fullName, string soDt, string email, string vaitro, bool active) 
            : base(id, fullName, soDt, email, vaitro)
        {
            Active = active;
        }

    }
}

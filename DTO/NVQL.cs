using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NVQL:NhanVien
    {
        public NVQL(string id, string ten, string sdt, string email, string vaitro,bool active) 
            : base(id, ten, sdt, email, vaitro,active)
        {
        }
    }
}

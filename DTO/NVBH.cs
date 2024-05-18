using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NVBH:NhanVien
    {
        public int KPI { get; set; }
        public NVBH(String id,string name, string sdt, string email,string vaitro, bool active, int kpi) 
            : base(id,name, sdt, email, vaitro,active)
        {
            KPI = kpi;
        }
    }
}

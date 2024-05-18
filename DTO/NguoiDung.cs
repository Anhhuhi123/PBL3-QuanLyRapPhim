using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string SoDt { get; set; }
        public string Email { get; set; }
        public string Vaitro { get; set; }
        public NguoiDung(string id, string fullName, string soDt, string email, string vaitro)
        {
            Id = id;
            FullName = fullName;
            SoDt = soDt;
            Email = email;
            Vaitro = vaitro;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Succhua { get; set; }
        public string MoTa { get; set; }
        public PhongChieu(int id, string name, int succhua, string moTa)
        {
            Id = id;
            Name = name;
            Succhua = succhua;
            MoTa = moTa;
        }
        public PhongChieu() { }
    }
}

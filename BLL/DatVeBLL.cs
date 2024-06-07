using BLL.UnitOfWork;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DatVeBLL
    {
        CinemaUnitOfWork unitOfWork;
        public DatVeBLL()
        {
            unitOfWork = CinemaUnitOfWork.Instance;
        }
        public List<string> GetPhimDangChieu()
        {

           List<string> list = new List<string>();
           foreach(PhongChieu pc in unitOfWork.GetAll<PhongChieu>())
           {
                foreach (LichChieu lc in unitOfWork.GetLichDangChieu(pc.Id))
                {
                    list.Add(lc.TenPhim);
                }
           }
            return list.Distinct().ToList();
        }
    }
}

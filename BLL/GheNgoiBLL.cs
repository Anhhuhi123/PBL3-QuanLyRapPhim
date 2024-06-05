using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GheNgoiBLL
    {
        GheNgoiDAO gheNgoiDAO;
        public GheNgoiBLL()
        {
            gheNgoiDAO = new GheNgoiDAO();
        }
        public List<GheNgoi> GetAll(int idLich,int idPhong)
        {
            return gheNgoiDAO.GetAll(idLich, idPhong);
        }
        public void Update(GheNgoi obj,int idlich,int idphong,int idVeDuocDat)
        {
            gheNgoiDAO.Update(obj, idlich, idphong,idVeDuocDat);
        }
        public GheNgoi GetGheNgoi(int id, int idlich, int idphong)
        {
            foreach(GheNgoi gheNgoi in gheNgoiDAO.GetAll(idlich, idphong))
            {
                if(gheNgoi.Id == id)
                {
                    return gheNgoi;
                }
            }
            return null;
        }
    }
}

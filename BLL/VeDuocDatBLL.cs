using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VeDuocDatBLL
    {
        VeDuocDatDAO veDuocDatDAO;
        public VeDuocDatBLL()
        {
            veDuocDatDAO = new VeDuocDatDAO();
        }
        public void Insert(VeDuocDat veDuocDat,int idLich)
        {
            veDuocDatDAO.Insert(veDuocDat,idLich);
        }
        public void Delete(int id)
        {
            veDuocDatDAO.Delete(id);
        }

    }
}

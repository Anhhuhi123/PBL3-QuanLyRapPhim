using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PhongChieuBLL
    {
        PhongChieuDAO phongChieuDAO;
        public PhongChieuBLL()
        {
            phongChieuDAO = new PhongChieuDAO();
        }
        public void setDGV(DataGridView dgv)
        {
            dgv.DataSource = phongChieuDAO.GetAll();
        }
    }
}

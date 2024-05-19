using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PhimBLL
    {
        PhimDAO phimDAO;
        public PhimBLL()
        {
            phimDAO = new PhimDAO();
        }
        public void setDGV(DataGridView dgv,ComboBox text)
        {
            List<Phim> list = new List<Phim>();
            foreach(Phim phim in phimDAO.GetAll())
            {
                if (phim.TheLoai.Contains(text.Text))
                {
                    list.Add(phim);
                }
            }
            dgv.DataSource = list;
        }
        public void setCBB(ComboBox cbb)
        {
            List<string> tenphim = new List<string>();
            foreach(Phim phim in phimDAO.GetAll())
            {
                tenphim.Add(phim.TheLoai);
            }
            cbb.Items.AddRange(tenphim.Distinct().ToArray());
        }
    }
}

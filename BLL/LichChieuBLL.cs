using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class LichChieuBLL
    {
        LichChieuDAO lichChieuDAO;
        public LichChieuBLL()
        {
            lichChieuDAO = new LichChieuDAO();
        }
        public void SetCbb(ComboBox cb)
        {
            List<string> list = new List<string>();
            foreach(LichChieu lc in lichChieuDAO.GetAll())
            {
                list.Add(lc.TenPhim);
            }
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.Add("Tất cả");
            cb.SelectedIndex = 0;
            cb.Items.AddRange(list.Distinct().ToArray());
        }
        public void SetDGV(DataGridView dgv,ComboBox cb)
        {
            List<LichChieu> list = new List<LichChieu>();
            foreach(LichChieu lc in lichChieuDAO.GetAll())
            {
                if(cb.Text=="Tất cả" || lc.TenPhim.Contains(cb.Text))
                    list.Add(lc);
            }
            dgv.DataSource = list;
        }
        
    }
}

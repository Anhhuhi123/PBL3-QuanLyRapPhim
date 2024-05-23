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
        PhimBLL phimBLL;
        NguoiDungBLL nguoiDungBLL;
        public LichChieuBLL()
        {
            lichChieuDAO = new LichChieuDAO();
            phimBLL = new PhimBLL();
            nguoiDungBLL = new NguoiDungBLL();
        }

        public List<LichChieu> GetAllLichChieu()
        {
            return lichChieuDAO.GetAll();
        }

        public List<int> GetLichChieuid(string name)
        {
            List<int> list = new List<int>();
            foreach (LichChieu lc in GetAllLichChieu())
            {
                if (lc.TenPhim == name)
                {
                    list.Add(lc.Id);
                }
            }
            return list;
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
        private void Insert(TextBox txtIDLichChieu, ComboBox ccbTenPhim, string idnvql, DateTimePicker dateTimeLichChieu, TextBox txtGioChieu)
        {
            if (ccbTenPhim.Text == "Tất cả")
            {
                MessageBox.Show("Vui lòng chọn phim");
                return;
            }
            try
            {
                int idphim=phimBLL.TimKiemPhim(ccbTenPhim.Text);
                string tennvql = nguoiDungBLL.GetNguoiDung(idnvql).FullName;

                int id =Convert.ToInt32(txtIDLichChieu.Text);
                string tenphim = ccbTenPhim.Text;
                DateTime ngaychieu = dateTimeLichChieu.Value;
                int giochieu = Convert.ToInt32(txtGioChieu.Text);
                double time = phimBLL.GetPhim(idphim).ThoiLuong/60;
                int gioketthuc = giochieu + (int)Math.Ceiling(time);
                LichChieu temp =new LichChieu(id, tenphim, tennvql, ngaychieu, giochieu, gioketthuc);
                lichChieuDAO.Insert(temp,idphim,idnvql);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi "+e.Message);
            }
        }
        private void Update(TextBox txtId,ComboBox cbbtenphim,string idnvql,DateTimePicker DTngaychieu,TextBox txtgio)
        {
            try
            {
                if (cbbtenphim.Text == "" || txtgio.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    int id = Convert.ToInt32(txtId.Text);
                    string tenphim = cbbtenphim.Text;
                    DateTime ngaychieu = DTngaychieu.Value;
                    int giochieu = Convert.ToInt32(txtgio.Text);
                    double time = phimBLL.GetPhim(phimBLL.TimKiemPhim(tenphim)).ThoiLuong / 60;
                    int gioketthuc = giochieu + (int)Math.Ceiling(time);
                    lichChieuDAO.Update(new LichChieu(id, tenphim, idnvql, ngaychieu, giochieu, gioketthuc));
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi " + e.Message);
            }
        }
        private void Delete(TextBox txtId)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                lichChieuDAO.Delete(id);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e.Message);
            }
        }

        public void XuLySuKien(Button sender, TextBox txtIDLichChieu, ComboBox ccbTenPhim, string idnvql, DateTimePicker dateTimeLichChieu, TextBox txtGioChieu)
        {
            switch(sender.Text)
            {
                case "Thêm":
                    Insert(txtIDLichChieu, ccbTenPhim, idnvql, dateTimeLichChieu, txtGioChieu);
                    break;
                case "Sửa":
                    Update(txtIDLichChieu, ccbTenPhim, idnvql, dateTimeLichChieu, txtGioChieu);
                    break;
                case "Xóa":
                    Delete(txtIDLichChieu);
                    break;
                case "Lọc":
                    break;
            }
        }

        public void SetInfo(DataGridView dataGridView1, TextBox txtIDLichChieu, ComboBox ccbTenPhim, DateTimePicker dateTimeLichChieu, TextBox txtGioChieu,int index)
        {
            if(index>=0)
            {
                DataGridViewRow dr= dataGridView1.Rows[index];
                dr.Selected = true;
                txtIDLichChieu.Text = dr.Cells["Id"].Value.ToString();
                dateTimeLichChieu.Value = Convert.ToDateTime(dr.Cells[3].Value);
                txtGioChieu.Text = dr.Cells[4].Value.ToString();
                ccbTenPhim.Text = dr.Cells["TenPhim"].Value.ToString();
            }
        }
    }
}

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
        public List<LichChieu> GetLichDangChieu(int id)
        {
            return lichChieuDAO.GetLichDangChieu(id);
        }
        public bool CheckPhimDangChieu(int idlc, int idPhong)
        {
            foreach(LichChieu lc in GetLichDangChieu(idPhong))
            {
                if (lc.Id == idlc)
                    return true;
            }
            return false;
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
            foreach(Phim p in phimBLL.GetAllPhim())
            {
                list.Add(p.TenPhim);
            }
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.Add("Tất cả");
            cb.SelectedIndex = 0;
            cb.Items.AddRange(list.Distinct().ToArray());
        }

        public void setDGVHeader(DataGridView dgv)
        {
            if(dgv.Columns.Count>0)
            {
                dgv.Columns[0].HeaderText = "ID";
                dgv.Columns[1].HeaderText = "Tên phim";
                dgv.Columns[2].HeaderText = "Nhân viên quản lý";
                dgv.Columns[3].HeaderText = "Ngày chiếu";
                dgv.Columns[4].HeaderText = "Giờ chiếu";
                dgv.Columns[5].HeaderText="Giờ kết thúc";
            }
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
            setDGVHeader(dgv);
        }
        public void SetDGV(DataGridView dgv, CheckBox cb, int idphong)
        {
            List<LichChieu> list = new List<LichChieu>();
            if (cb.Checked)
            {
                foreach (LichChieu lc in GetAllLichChieu())
                {
                    list.Add(lc);
                }
            }
            else
            {
                foreach (LichChieu lc in GetLichDangChieu(idphong))
                {
                    list.Add(lc);
                }
            }
            dgv.DataSource = list;
            setDGVHeader(dgv);
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
        private void Delete(TextBox txtId,int idPhongChieu=0)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if(idPhongChieu==0)
                {
                    lichChieuDAO.Delete(id);
                }
                else
                {
                    XoaPhimDangChieu(id, idPhongChieu);
                }
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e.Message);
            }
        }
        public void ThemPhimDangChieu(int idlc,int idpc)
        {
            if(CheckPhimDangChieu(idlc,idpc))
            {
                throw new Exception ("Lịch chiếu đã có trong phòng chiếu");
            }
            lichChieuDAO.ThemPhimDangChieu(idlc, idpc);
        }
        public void XoaPhimDangChieu(int idphim, int idphong)
        {
            lichChieuDAO.XoaPhimDangChieu(idphim, idphong);
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
        public void XuLySuKien(Button sender, DataGridView dataGridView1,int idPhong)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu");
                return;
            }
            else
            {
                foreach(DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    try
                    {
                        int id = Convert.ToInt32(dr.Cells["Id"].Value.ToString());
                        switch (sender.Text)
                        {
                            case "Thêm":
                                ThemPhimDangChieu(id, idPhong);
                                break;
                            case "Xóa":
                                XoaPhimDangChieu(id, idPhong);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Lỗi " + e.Message);
                    }
                }
                MessageBox.Show("Thay đổi thành công!");
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

        public int OpenPhongChieu(DataGridViewRow dataGridViewRow)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
                if (id != 0)
                {
                    MessageBox.Show(string.Format("Lịch chiếu của phòng {0} là ", id));
                    return id;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            return 0;
        }

    }
}

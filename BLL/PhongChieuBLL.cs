using BLL.UnitOfWork;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PhongChieuBLL
    {
        CinemaUnitOfWork unitOfWork;
        public PhongChieuBLL()
        {
            unitOfWork = CinemaUnitOfWork.Instance;
        }
        public PhongChieu GetPhongByName(string text)
        {
            foreach (PhongChieu pc in unitOfWork.GetAll<PhongChieu>())
            {
                if (pc.Name == text)
                {
                    return pc;
                }
            }
            return null;
        }
        public bool CheckPhongChieuPhim(int idphim, int idphong)
        {
            if (idphim == 0 || idphong == 0) return false;
            foreach (PhongChieu chieu in unitOfWork.GetAllPhongDangChieuPhim(idphim))
            {
                if (chieu.Id == idphong) return true;
            }
            return false;
        }
        private void setDGVHeader(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Tên phòng";
            dgv.Columns[2].HeaderText = "Sức chứa";
            dgv.Columns[3].HeaderText = "Mô tả";
        }
        public void SetDGV(DataGridView dgv)
        {
            dgv.DataSource = unitOfWork.GetAll<PhongChieu>();
            setDGVHeader(dgv);
        }
        public void SetDGV(DataGridView dataGridView1, CheckBox checkBox1, int idLich)
        {
            List<PhongChieu> list = new List<PhongChieu>();
            if (checkBox1.Checked)
            {
                foreach (PhongChieu lc in unitOfWork.GetAll<PhongChieu>())
                {
                    list.Add(lc);
                }
            }
            else
            {
                foreach (PhongChieu lc in unitOfWork.GetAllPhongDangChieuPhim(idLich))
                {
                    list.Add(lc);
                }
            }
            dataGridView1.DataSource = list;
            setDGVHeader(dataGridView1);
        }
        public void Insert(TextBox txtid, TextBox txtname, TextBox txtsize, TextBox txtmota)
        {
            try
            {
                if(txtid.Text == "" || txtname.Text == "" || txtsize.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                int id= Convert.ToInt32(txtid.Text);
                if(unitOfWork.GetById<PhongChieu>(id) != null)
                {
                    throw new Exception("ID đã tồn tại");
                }
                string name = txtname.Text;
                int size = Convert.ToInt32(txtsize.Text);
                if(size==0 || size > 100){
                    throw new Exception("Sức chứa phải lớn hơn 0 và không quá 100");
                }
                string mota = txtmota.Text;
                unitOfWork.Insert(new PhongChieu(id, name, size, mota));
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message);
            }

        }
        public void Update(TextBox txtid , TextBox txtname,TextBox txtsize,TextBox txtmota)
        {
            try
            {
                if (txtid.Text == "" || txtname.Text == "" || txtsize.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                int id= Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                int size = Convert.ToInt32(txtsize.Text);
                string mota = txtmota.Text;
                unitOfWork.Update(new PhongChieu(id, name, size, mota));
                MessageBox.Show("Sửa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message);
            }
        }
        public void Delete(TextBox txtid)
        {
            try
            {
                if (txtid.Text == "")
                {
                    throw new Exception("Vui lòng nhập ID cần xóa");
                }
                int id= Convert.ToInt32(txtid.Text);
                unitOfWork.Delete<PhongChieu>(id);
                MessageBox.Show("Xóa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message);
            }
        }
        public void xuLySuKien(Button sender, TextBox txtid, TextBox txtname, TextBox txtsize, TextBox txtmota)
        {
            try
            {
                switch (sender.Text)
                {
                    case "Thêm":
                        Insert(txtid, txtname, txtsize, txtmota);
                        break;
                    case "Sửa":
                        Update(txtid, txtname, txtsize, txtmota);
                        break;
                    case "Xóa":
                        Delete(txtid);
                        break;
                    default:
                        throw new Exception("Lỗi chưa xác định");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void xuLySuKien(Button sender, DataGridView dataGridView1, int idLichChieu)
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
                                unitOfWork.ThemSuatChieu(idLichChieu, id);
                                break;
                            case "Xóa":
                                unitOfWork.XoaSuatChieu(idLichChieu, id);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Lỗi " + e.Message);
                        return;
                    }
                }
                MessageBox.Show("Thay đổi thành công!");
            }
        }
        public int OpenLichChieu(DataGridViewRow dataGridViewRow)
        {
            try
            {
                int idPhong = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
                if(idPhong != 0)
                {
                    MessageBox.Show(string.Format("Lịch chiếu của phòng {0} là ",idPhong));
                    return idPhong;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return 0;
        }
    }
}

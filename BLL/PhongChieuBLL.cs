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
        public void Insert(TextBox txtid, TextBox txtname, TextBox txtsize, TextBox txtmota)
        {
            try
            {
                int id= Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                int size = Convert.ToInt32(txtsize.Text);
                string mota = txtmota.Text;
                phongChieuDAO.Insert(new PhongChieu(id, name, size, mota));
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
                int id= Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                int size = Convert.ToInt32(txtsize.Text);
                string mota = txtmota.Text;
                phongChieuDAO.Update(new PhongChieu(id, name, size, mota));
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
                int id= Convert.ToInt32(txtid.Text);
                phongChieuDAO.Delete(id);
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
    }
}

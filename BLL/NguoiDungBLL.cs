using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class NguoiDungBLL
    {
        UnitofWork UnitofWork;
        public NguoiDungBLL()
        {
            UnitofWork = UnitofWork.Instance;
        }
        public void setDGV(DataGridView dgv,ComboBox cb)
        {
            switch (cb.Text)
            {
                case "Khách hàng":
                    dgv.DataSource = UnitofWork.KhachHangDAO.GetAll();
                    break;
                case "Nhân viên quản lý":
                    dgv.DataSource=UnitofWork.NhanVienQuanLyDAO.GetAll();
                    break;
                case "Nhân viên bán hàng":
                    dgv.DataSource = UnitofWork.NhanVienBanHangDAO.GetAll();
                    break;
                case "Nhân viên":
                    dgv.DataSource = UnitofWork.NhanVienDAO.GetAll();
                    break;
                case "Người dùng":
                    dgv.DataSource=UnitofWork.NguoiDungDAO.GetAll();
                    break;
                default:
                    MessageBox.Show("Không hợp lệ!");
                    break;
            }
        }
        public void Insert(TextBox txtid,TextBox txtname,ComboBox role, TextBox sdt, TextBox email,TextBox kpi ,RadioButton bt)
        {
            string id= txtid.Text;
            string name = txtname.Text;
            string vaitro =role.Text;
            string sodt= sdt.Text;
            string mail = email.Text;
            int kpi1 = (kpi.Text=="")?0:Convert.ToInt32(kpi.Text);
            switch (role.Text)
            {
                case "Khách Hàng":
                    
                    break;
                case "Nhân viên quản lý":
                    break;
                case "Nhân viên bán hàng":
                    break;
                default:
                    MessageBox.Show("Combo không hợp lệ");
                    break;
            }
        }

    }
}

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
    public class TaiKhoanBLL
    {
        TaiKhoanDAO taikhoanDAO;
        public TaiKhoanBLL()
        {
            taikhoanDAO = new TaiKhoanDAO();
        }
        public string checkLogin(TextBox txtTK, TextBox txtMK)
        {
            if(txtTK.Text==""||txtMK.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản và mật khẩu!");
                return null;
            }
            foreach(TaiKhoan temp in taikhoanDAO.GetAll())
            {
                if(temp.TenTK==txtTK.Text)  
                    if (temp.MatKhau == txtMK.Text) return txtTK.Text;
            }
            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            return null;
        }
    }
}

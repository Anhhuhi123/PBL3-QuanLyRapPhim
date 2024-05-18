using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        private string mkhauPlaceholder = "Password";
        private string dnhapsPlaceholder = "Login";

        private string tkql = "admin";
        private string mkql = "admin";

        private string tknv = "nv";
        private string mknv = "nv";
        public LoginForm()
        {
            InitializeComponent();
            MKhau.Text = mkhauPlaceholder;
            DNhap.Text = dnhapsPlaceholder;

        }

        private void Dang_Nhap_Click(object sender, EventArgs e)
        {
            if (DNhap.Text == tkql && MKhau.Text == mkql)
            {
                QuanLyForm ql = new QuanLyForm();
                ql.Show();
            }
            /*else if (DNhap.Text == tknv && MKhau.Text == mknv)
            {
                NhanVien nv = new NhanVien();
                nv.Show();
            }*/
            else
            {
                MessageBox.Show("Enror");
            }

        }

        private void MKhau_Enter(object sender, EventArgs e)
        {
            // Xóa văn bản mặc định khi TextBox được focus
            if (MKhau.Text == mkhauPlaceholder)
                MKhau.Text = "";
        }

        private void MKhau_Leave(object sender, EventArgs e)
        {
            // Khôi phục văn bản mặc định nếu không có dữ liệu được nhập vào TextBox
            if (string.IsNullOrWhiteSpace(MKhau.Text))
                MKhau.Text = mkhauPlaceholder;
        }

        private void DNhap_Leave(object sender, EventArgs e)
        {
            // Khôi phục văn bản mặc định nếu không có dữ liệu được nhập vào TextBox
            if (string.IsNullOrWhiteSpace(DNhap.Text))
                DNhap.Text = dnhapsPlaceholder;
        }

        private void DNhap_Enter(object sender, EventArgs e)
        {
            // Xóa văn bản mặc định khi TextBox được focus
            if (DNhap.Text == dnhapsPlaceholder)
                DNhap.Text = "";
        }

        private void DNhap_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu văn bản của TextBox trùng với văn bản mặc định thì xóa nó đi khi có phím được nhấn
            if (DNhap.Text == dnhapsPlaceholder)
                DNhap.Text = "";
        }

        private void Mkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (MKhau.Text == dnhapsPlaceholder)
                MKhau.Text = "";
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

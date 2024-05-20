using BLL;
using DTO;
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
        public string user;
        TaiKhoanBLL controller;
        private string mkhauPlaceholder = "Password";
        private string dnhapsPlaceholder = "Login";
        public LoginForm()
        {
            controller =new TaiKhoanBLL();
            InitializeComponent();
            MKhau.Text = mkhauPlaceholder;
            DNhap.Text = dnhapsPlaceholder;

        }

        private void Dang_Nhap_Click(object sender, EventArgs e)
        {
            string username =controller.checkLogin(DNhap,MKhau);
            if (username == null) return;
            user = username;
            this.DialogResult = DialogResult.OK;
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

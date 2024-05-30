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
        public LoginForm()
        {
            controller =new TaiKhoanBLL();
            InitializeComponent();

        }

        private void Dang_Nhap_Click(object sender, EventArgs e)
        {
            string username = controller.checkLogin(DNhap,MKhau);
            if (username == null) return;
            user = username;
            this.DialogResult = DialogResult.OK;
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

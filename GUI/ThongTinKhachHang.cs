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
    public partial class ThongTinKhachHang : Form
    {
        NguoiDungBLL nguoiDungBLL;
        public KhachHang khachHang;
        public string ghiChu;
        public ThongTinKhachHang()
        {
            InitializeComponent();
            nguoiDungBLL = new NguoiDungBLL();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khachHang = nguoiDungBLL.AddOrUpdateKH(txtId, txtName, txtPhone, txtEmail);
            ghiChu= txtGhiChu.Text;
            if (khachHang != null)
            {
                DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

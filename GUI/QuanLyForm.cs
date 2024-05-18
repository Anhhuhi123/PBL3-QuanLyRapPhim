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
    public partial class QuanLyForm : Form
    {
        public Form currentChildForm;
        public QuanLyForm()
        {
            InitializeComponent();
        }

        public void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Quan_Ly_Phong_Chieu_Click(object sender, EventArgs e)
        {
            openChildForm(new PhongChieu());
        }

        private void Quan_Ly_Phim_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyPhim());
        }

        private void Quan_Ly_Lich_Chieu_Click(object sender, EventArgs e)
        {
            openChildForm(new LichChieu());
        }

        private void Quan_Ly_Nhan_Vien_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinNhanVien());
        }

        private void Doanh_Thu_Click(object sender, EventArgs e)
        {
            openChildForm(new DoanhThu());
        }

        private void btTHoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyForm_Load(object sender, EventArgs e)
        {

        }
    }
}

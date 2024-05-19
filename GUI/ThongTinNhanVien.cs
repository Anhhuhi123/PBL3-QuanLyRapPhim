using BLL;
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
    public partial class ThongTinNhanVien : Form
    {
        NguoiDungBLL controller;
        public ThongTinNhanVien()
        {
            controller = new NguoiDungBLL();
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolecbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.setDGV(dataGridView1, rolecbb);
        }
    }
}

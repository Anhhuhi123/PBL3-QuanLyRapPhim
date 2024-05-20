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
    public partial class QuanLyPhim : Form
    {
        PhimBLL controller;
        public QuanLyPhim()
        {
            controller = new PhimBLL();
            InitializeComponent();
            controller.setDGV(dataGridView1,ccbTheLoai);
            controller.setCBB(ccbTheLoai);
        }

        private void ccbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.setDGV(dataGridView1, ccbTheLoai);
        }
        private void button_Click(object sender,EventArgs e)
        {
            controller.xuLySuKien((Button)sender,txtMaPhim,txtTenPhim,ccbTheLoai,txtThoiLuong,txtMoTa);
            controller.setDGV(dataGridView1,ccbTheLoai);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.setInfo((DataGridView)sender,txtMaPhim,txtTenPhim,ccbTheLoai,txtThoiLuong,txtMoTa,e.RowIndex);
        }
    }
}

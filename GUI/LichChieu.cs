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
    public partial class LichChieu : Form
    {
        private LichChieuBLL controller;
        public string idnvql;
        private int idPhongChieu;
        public LichChieu(int id=0)
        {
            controller =new LichChieuBLL();
            InitializeComponent();
            idPhongChieu = id;
            if(idPhongChieu!=0)
            {
                controller.SetDGV(dataGridView1,checkBox1,idPhongChieu);

                txtIDLichChieu.Enabled = false;
                ccbTenPhim.Enabled = false;
                dateTimeLichChieu.Enabled = false;
                txtGioChieu.Enabled = false;
                Filterbtn.Enabled = false;

                checkBox1.Visible = true;
                checkBox1.Enabled = true;
                btThem.Enabled = false;
                btThem.BackColor = Color.Gray;
                btSua.Enabled = false;
                btSua.BackColor = Color.Gray;
                dataGridView1.CellDoubleClick -= dataGridView1_CellDoubleClick;
                dataGridView1.CellClick -= dataGridView1_CellClick;
            }
            else
            {
                controller.SetCbb(ccbTenPhim);
                controller.SetDGV(dataGridView1, ccbTenPhim);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if(idPhongChieu==0)
            {
                controller.XuLySuKien((Button)sender, txtIDLichChieu, ccbTenPhim, idnvql, dateTimeLichChieu, txtGioChieu);
                controller.SetDGV(dataGridView1, ccbTenPhim);
            }
            else
            {
                controller.XuLySuKien((Button) sender,dataGridView1,idPhongChieu);
                controller.SetDGV(dataGridView1,checkBox1,idPhongChieu);
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.SetInfo(dataGridView1,txtIDLichChieu,ccbTenPhim,dateTimeLichChieu,txtGioChieu,e.RowIndex);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PhongChieu pc = new PhongChieu(controller.OpenPhongChieu(dataGridView1.Rows[e.RowIndex]));
            pc.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                controller.SetDGV(dataGridView1, checkBox1, idPhongChieu);
                btThem.Enabled = true;
                btThem.BackColor = Color.DarkRed;
                btXoa.Enabled = false;
                btXoa.BackColor = Color.Gray;
                MessageBox.Show("Hãy chọn lịch chiếu muốn thêm vào phòng");
            }
            else
            {
                btThem.Enabled = false;
                btThem.BackColor = Color.Gray;
                btXoa.Enabled = true;
                btXoa.BackColor = Color.DarkRed;
                controller.SetDGV(dataGridView1,checkBox1, idPhongChieu);
                MessageBox.Show("Đã tắt chế độ thêm");
            }
        }
    }
}

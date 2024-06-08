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
    public partial class PhongChieu : Form
    {
        PhongChieuBLL controller;
        private int idLichChieu;
        public PhongChieu(int id= 0)
        {
            controller =new PhongChieuBLL();
            InitializeComponent();
            idLichChieu = id;
            if (idLichChieu != 0)
            {
                controller.SetDGV(dataGridView1, checkBox1, idLichChieu);

                dataGridView1.MultiSelect = true;

                txtid.Enabled = false;
                txtname.Enabled = false;
                txtsize.Enabled = false;
                txtmota.Enabled = false;

                txtid.Visible = false;
                txtname.Visible = false;
                txtsize.Visible = false;
                txtmota.Visible = false;

                checkBox1.Enabled = true;
                checkBox1.Visible = true;
                btSua.Enabled = false;
                btSua.BackColor = Color.Gray;
                btThem.Enabled = false;
                btThem.BackColor = Color.Gray;
                dataGridView1.CellDoubleClick -= dataGridView1_CellContentDoubleClick;
            }
            else
                controller.SetDGV(dataGridView1);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if(idLichChieu==0)
            {
                controller.xuLySuKien((Button)sender, txtid, txtname, txtsize, txtmota);
                controller.SetDGV(dataGridView1);
            }
            else
            {
                controller.xuLySuKien((Button)sender, dataGridView1, idLichChieu);
                controller.SetDGV(dataGridView1, checkBox1, idLichChieu);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LichChieu lc = new LichChieu(controller.OpenLichChieu(dataGridView1.Rows[e.RowIndex]));
            lc.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btThem.Enabled = true;
                btThem.BackColor = Color.DarkRed;
                btXoa.Enabled = false;
                btXoa.BackColor = Color.Gray;
                controller.SetDGV(dataGridView1,checkBox1,idLichChieu);
                MessageBox.Show("Hãy chọn phòng chiếu muốn thêm lịch chiếu");
            }
            else
            {
                btXoa.Enabled = true;
                btXoa.BackColor = Color.DarkRed;
                btThem.Enabled = false;
                btThem.BackColor = Color.Gray;
                controller.SetDGV(dataGridView1, checkBox1, idLichChieu);
                MessageBox.Show("Đã tắt chế độ thêm phòng vào lịch");
            }
        }
    }
}

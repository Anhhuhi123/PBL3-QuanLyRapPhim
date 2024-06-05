using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class BanVe : Form
    {

        private readonly BanVeBLL controller;
        public string idnvbh;
        public BanVe(string search)
        {
            controller = new BanVeBLL();
            controller.eventHandler += XuLyDatVeThanhCong;
            InitializeComponent();
            txtTenPhim.Text = search;
            txtTenPhim.Enabled = false;
            controller.SetCbb(comboBox1);
            controller.SetDGV(txtTenPhim,dataGridView1, dateTimePicker1, DTSearch, comboBox1);
        }

        private void btTimPhong_Click(object sender, EventArgs e)
        {
            List<GheNgoi> list =controller.Search(txtTenPhim,dateTimePicker1, DTSearch, comboBox1, dataGridView1,flowLayoutPanel1);
            if(list!=null)
                CreateGheNgoiButtons(list);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetDGV(txtTenPhim, dataGridView1, dateTimePicker1, DTSearch, comboBox1);
        }
        private void DatVe_Click(object sender, EventArgs e)
        {
            controller.DatVe( dataGridView1, comboBox1,flowLayoutPanel1,totallbl);
        }
        private void HuyVe_Click(object sender, EventArgs e)
        {
            controller.HuyVe(flowLayoutPanel1,totallbl);
        }
        private void GheButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            controller.GheButton_Click(button,totallbl);
        }
        private void CreateGheNgoiButtons(List<GheNgoi> danhSachGheNgoi)
        {
            if(flowLayoutPanel1.Controls.Count>0)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach(Control control in flowLayoutPanel1.Controls)
                {
                    control.Dispose();
                }
            }
            foreach(GheNgoi gheNgoi in danhSachGheNgoi)
            {
                Button button = new Button();
                button.Text= gheNgoi.ToString();
                button.Name = gheNgoi.Id.ToString();
                button.Size = new System.Drawing.Size(55, 36);
                if(gheNgoi.TrangThai)
                {
                    button.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    button.BackColor = System.Drawing.Color.Gray;
                }
                button.Click += new EventHandler(GheButton_Click);
                flowLayoutPanel1.Controls.Add(button);
            }
        }
        private void XuLyDatVeThanhCong(object sender , VeDuocDatEventArgs e)
        {
            ThongTinKhachHang thongTinKhachHang = new ThongTinKhachHang();
            thongTinKhachHang.ShowDialog();
            if(thongTinKhachHang.DialogResult == DialogResult.Cancel)
            {
                controller.HuyVe(flowLayoutPanel1,totallbl);
            }
            else if(thongTinKhachHang.DialogResult == DialogResult.OK)
            {
                KhachHang khachHang = thongTinKhachHang.khachHang;
                string ghichu = thongTinKhachHang.ghiChu;
                controller.XuLyDatVeThanhCong(khachHang,e.VeDuocDat,idnvbh,ghichu);
            }
        }
    }
}

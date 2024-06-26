﻿using DTO;
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
        private readonly string idnvql ;
        private Form currentChildForm=null;
        public QuanLyForm(string username)
        {
            idnvql=username;
            InitializeComponent();
            Welcomelbl.Text = "Xin chào " + idnvql;
        }

        public void openChildForm(Form childForm)
        {
            if (currentChildForm != null && currentChildForm.GetType() == childForm.GetType())
            {
                currentChildForm.Dispose();
                currentChildForm= null;
                return;
            }
            else if(currentChildForm != null)
            {
                currentChildForm.Dispose();
                currentChildForm = null;
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(childForm);
            GC.Collect();
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
            LichChieu lc = new LichChieu();
            lc.idnvql = idnvql;
            openChildForm(lc);
        }

        private void Quan_Ly_Nhan_Vien_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinNhanVien(idnvql));
        }

        private void Doanh_Thu_Click(object sender, EventArgs e)
        {
            openChildForm(new DoanhThu());
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

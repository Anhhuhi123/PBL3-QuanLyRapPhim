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
        private readonly LichChieuBLL controller;
        public BanVe(String search)
        {
            controller = new LichChieuBLL();
            InitializeComponent();
            txtTenPhim.Text = search;
            txtTenPhim.Enabled = false;
            refreshDGV(txtTenPhim.Text);
        }

        private void refreshDGV(String tenPhim)
        {
            List<DTO.LichChieu> lc = new List<DTO.LichChieu>();
            foreach(DTO.LichChieu l in controller.GetAllLichChieu())
            {                 
                if (l.TenPhim == tenPhim)
                {
                    lc.Add(l);
                }
            }
            dataGridView1.DataSource = lc;
        }

    }
}

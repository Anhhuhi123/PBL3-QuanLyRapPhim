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
            refreshDGV();
        }

        private void refreshDGV()
        {

        }

    }
}

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
        public LichChieu()
        {
            controller =new LichChieuBLL();
            InitializeComponent();
            controller.SetCbb(ccbTenPhim);
            controller.SetDGV(dataGridView1,ccbTenPhim);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

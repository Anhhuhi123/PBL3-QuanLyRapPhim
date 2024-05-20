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
    public partial class PhongChieu : Form
    {
        PhongChieuBLL controller;
        public PhongChieu()
        {
            controller =new PhongChieuBLL();
            InitializeComponent();
            controller.setDGV(dataGridView1);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            controller.xuLySuKien((Button)sender, txtid, txtname, txtsize, txtmota);
            controller.setDGV(dataGridView1);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

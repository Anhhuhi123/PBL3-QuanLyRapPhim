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
    public partial class ChiTietHoaDonForm : Form
    {
        ChiTietHoaDonBLL controller;
        public ChiTietHoaDonForm(int idhoadon)
        {
            InitializeComponent();
            controller = new ChiTietHoaDonBLL(idhoadon);
            controller.SetDGV(dataGridView1);
            controller.SetLabel(label2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

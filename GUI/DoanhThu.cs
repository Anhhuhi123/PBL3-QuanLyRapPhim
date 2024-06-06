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
    public partial class DoanhThu : Form
    {
        DoanhThuBLL controller;
        public DoanhThu()
        {
            controller = new DoanhThuBLL();
            InitializeComponent();
            controller.SetCbb(comboBox1);
            controller.SetDGV(dataGridView1,comboBox1,label6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.SetDGV(dataGridView1, comboBox1, label6);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idhoadon = controller.GetId(dataGridView1);
            if(idhoadon!=-1)
            {
                ChiTietHoaDonForm form = new ChiTietHoaDonForm(idhoadon);
                form.ShowDialog();
            }
        }
    }
}

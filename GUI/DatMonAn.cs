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
    public partial class DatMonAn : Form
    {
        readonly DatMonAnBLL controller;
        public delegate void DatMonDel(DataGridView dgv);
        public DatMonAn(int idhoadon)
        {
            InitializeComponent();
            controller = new DatMonAnBLL(idhoadon);
            controller.SetBangGia(dataGridView2);
            controller.SetMonAnHoaDon(dataGridView1);
        }
        public void Them_Mon_An_Click(object sender, EventArgs e)
        {
            controller.ThemMonAn((Button)sender, dataGridView1, dataGridView2,label3);
        }
        private void deleterRowButton_Click(object sender, EventArgs e)
        {
            controller.DeleteARow(dataGridView1,label3);
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            controller.DeleteAll(dataGridView1, label3);
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            controller.XacNhanMon(dataGridView1);
            this.Close();
        }
    }
}

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
    public partial class ThongTinNhanVien : Form
    {
        NguoiDungBLL controller;
        public ThongTinNhanVien()
        {
            controller = new NguoiDungBLL();
            InitializeComponent();
            controller.SetCbb(rolecbb);
            controller.setDGV(dataGridView1, rolecbb);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            controller.xuLySuKien((Button)sender, txtId, txtFullname, rolecbb, txtNumber, txtemail, txtKPI, Activerdb);
            controller.setDGV(dataGridView1, rolecbb);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void rolecbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rolecbb.Text=="Khách hàng" || rolecbb.Text=="Người dùng")
            {
                Deletebtn.Enabled = false;
                Deletebtn.BackColor=Color.Gray;
            }
            else
            {
                Deletebtn.Enabled = true;
                Deletebtn.BackColor = Color.DarkRed;
            }
            controller.setDGV(dataGridView1, rolecbb);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.setInfo(txtId, txtFullname, rolecbb, txtNumber, txtemail, txtKPI, Activerdb,e.RowIndex,dataGridView1);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            controller.Delete(dataGridView1);
        }
    }
}

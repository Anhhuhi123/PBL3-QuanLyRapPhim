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
        public ThongTinNhanVien(string idnvql)
        {
            controller = new NguoiDungBLL();
            controller.idNVQL=idnvql;
            InitializeComponent();
            controller.SetCbb(rolecbb);
            controller.setDGV(dataGridView1, rolecbb);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            controller.xuLySuKien((Button)sender, txtId, txtFullname, rolecbb, txtNumber, txtemail, txtKPI, activeCB);
            controller.setDGV(dataGridView1, rolecbb);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void rolecbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rolecbb.Text=="Khách hàng" )
            {
                Addbtn.Enabled = true;
                Addbtn.BackColor = SystemColors.ActiveCaption;
                
                //ẩn các control không cần thiết
                txtKPI.Enabled = false;
                txtKPI.Visible = false;
                label7.Visible = false;
                activeCB.Enabled = false;
                activeCB.Visible = false;
            }
            else if (rolecbb.Text=="Nhân viên" || rolecbb.Text == "Người dùng")
            {
                Addbtn.Enabled = false;
                Addbtn.BackColor = Color.Gray;

                //hiện các control cần thiết
                txtKPI.Enabled = false;
                txtKPI.Visible = false;
                label7.Visible = false;
                activeCB.Enabled = true;
                activeCB.Visible = true;

            }
            else if(rolecbb.Text=="Nhân viên quản lý")
            {
                Addbtn.Enabled = true;
                Addbtn.BackColor = SystemColors.ActiveCaption;

                //hiện các control cần thiết
                txtKPI.Enabled = false;
                txtKPI.Visible = false;
                label7.Visible = false;
                activeCB.Enabled = true;
                activeCB.Visible = true;
            }
            else
            {
                Addbtn.Enabled = true;
                Addbtn.BackColor = SystemColors.ActiveCaption;

                txtKPI.Enabled = true;
                txtKPI.Visible = true;
                label7.Visible = true;
                activeCB.Enabled = true;
                activeCB.Visible = true;
            }
            controller.setDGV(dataGridView1, rolecbb);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.setInfo(txtId, txtFullname, rolecbb, txtNumber, txtemail, txtKPI, activeCB,e.RowIndex,dataGridView1);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            controller.Delete(dataGridView1);
            controller.setDGV(dataGridView1, rolecbb);
        }
    }
}

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
    public partial class DatVe : Form
    {
        string idnvbh;
        private readonly PhimBLL controllerPhim;
        public DatVe(string username)
        {
            controllerPhim = new PhimBLL();
            idnvbh = username;
            //label1.Text = "Xin chào " + idnvbh;
            InitializeComponent();
            setButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            BanVe bv = new BanVe(bt.Text);
            bv.Show();
        }

        private void setButton()
        {
            List<String> list = new List<String>();
            foreach(Phim phim in controllerPhim.GetAllPhim())
            {
                list.Add(phim.TenPhim);
            }

            button1.Text = list[0];
            button2.Text = list[1];
            button3.Text = list[2];
            button4.Text = list[3];
            button5.Text = list[4];
            button6.Text = list[5];
            button7.Text = list[6];
            button8.Text = list[7];

        }


    }
}

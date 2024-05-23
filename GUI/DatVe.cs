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
        private readonly string idnvbh;
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
            List<Button> buttons = new List<Button>
            {
                button1, button2, button3, button4,
                button5, button6, button7, button8
            };
            controllerPhim.setTenPhim(buttons);
        }


    }
}

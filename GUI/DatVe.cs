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
        private DatVeBLL datVeBLL;
        public DatVe(string username)
        {   
            controllerPhim = new PhimBLL();
            datVeBLL = new DatVeBLL();
            datVeBLL.mydel = new DatVeBLL.Mydel(button1_Click);
            idnvbh = username;
            InitializeComponent();
            label1.Text = "Xin chào " + idnvbh;// ngu ac
            datVeBLL.SetButton(flowLayoutPanel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            BanVe bv = new BanVe(bt.Text);
            bv.idnvbh = idnvbh;
            bv.Show();
        }
    }
}

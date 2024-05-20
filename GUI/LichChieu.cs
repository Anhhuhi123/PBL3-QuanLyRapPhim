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
        private LichiChieuBLL controller;
        public string idnvql;
        public LichChieu()
        {
            controller =new LichiChieuBLL();
            InitializeComponent();
            controller.setDGV(dataGridView1);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

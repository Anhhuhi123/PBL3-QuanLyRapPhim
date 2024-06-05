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
    public partial class DatMonAn : Form
    {
        DatMonAnBLL controller;
        public DatMonAn()
        {
            InitializeComponent();
        }
        private void Them_Mon_An_Click(object sender, EventArgs e)
        {
            controller.ThemMonAn(dataGridView1, (Button)sender);
        }
    }
}

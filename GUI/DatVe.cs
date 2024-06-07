using BLL;
using BLL.UnitOfWork;
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
using static BLL.DatVeBLL;

namespace GUI
{
    public partial class DatVe : Form
    {
        private readonly string idnvbh;
        private DatVeBLL datVeBLL;
        public DatVe(string username)
        {
            datVeBLL = new DatVeBLL();
            idnvbh = username;
            InitializeComponent();
            label1.Text = "Xin chào " + idnvbh;
            SetButton(datVeBLL.GetPhimDangChieu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            BanVe bv = new BanVe(bt.Text);
            bv.idnvbh = idnvbh;
            bv.Show();
        }
        public void SetButton(List<string> tenphim)
        {
            int count = 0;
            foreach (string ten in tenphim.Distinct())
            {
                Button temp = new Button();
                temp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                temp.Name = "button" + (++count).ToString();
                temp.Size = new System.Drawing.Size(100, 50);
                temp.TabIndex = count;
                temp.Text = ten;
                temp.UseVisualStyleBackColor = true;
                temp.Click += button1_Click;
                flowLayoutPanel1.Controls.Add(temp);
            }
        }
    }
}

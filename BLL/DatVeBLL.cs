using BLL.UnitOfWork;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DatVeBLL
    {
        CinemaUnitOfWork unitOfWork;
        public delegate void Mydel(object sender, EventArgs e);
        public Mydel mydel;
        public DatVeBLL()
        {
            unitOfWork = CinemaUnitOfWork.Instance;
        }
        public void SetButton(Panel panel)
        {
            int count = 0;
            List<string> tenphim= new List<string>();
            foreach (Phim phim in unitOfWork.GetAll<Phim>())
            {
                tenphim.Add(phim.TenPhim);
            }
            foreach (string ten in tenphim.Distinct())
            {
                Button temp = new Button();
                temp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                temp.Name = "button"+(++count).ToString();
                temp.Size = new System.Drawing.Size(100, 50);
                temp.TabIndex = count;
                temp.Text = ten;
                temp.UseVisualStyleBackColor = true;
                temp.Click += new System.EventHandler(mydel);
                panel.Controls.Add(temp);
            }
        }
    }
}

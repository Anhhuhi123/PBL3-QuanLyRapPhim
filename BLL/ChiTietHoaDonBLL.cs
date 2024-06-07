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
    public class ChiTietHoaDonBLL
    {
        CinemaUnitOfWork unitOfWork;
        private int idhoadon;
        public ChiTietHoaDonBLL(int id)
        {
            idhoadon = id;
            unitOfWork = CinemaUnitOfWork.Instance;
        }
        public void SetDGV(DataGridView dgv)
        {
            dgv.DataSource = unitOfWork.GetChiTietHoaDon(idhoadon);
            dgv.Columns["Id"].HeaderText = "Thứ tự";
            dgv.Columns["TenMonAn"].HeaderText = "Tên món";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dgv.Columns["GiaTien"].HeaderText = "Giá";
            dgv.Columns["SoLuong"].DisplayIndex = 3;
        }

        public void SetLabel(Label label2)
        {
            label2.Text = "";
            List<GheNgoi> list = unitOfWork.GetAllGhe(new HoaDon { Id = idhoadon });
            if(list.Count == 0)
            {
                label2.Text = "Suất chiếu của hóa đơn đã bị xóa nên sẽ không hiện ghế!";
                return;
            }
            foreach(GheNgoi ghe in list)
            {
                label2.Text += ghe.ToString() + ", ";
            }
        }
    }
}

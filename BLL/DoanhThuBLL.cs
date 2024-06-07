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
    public class DoanhThuBLL
    {
        CinemaUnitOfWork unitOfWork = CinemaUnitOfWork.Instance;
        public DoanhThuBLL()
        {
            unitOfWork = CinemaUnitOfWork.Instance;
        }

        public int GetId(DataGridView dataGridView1)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 dòng để xem chi tiết");
                return -1;
            }
            return int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
        }

        public void SetCbb(ComboBox cbb)
        {
            List<string> tenphim= new List<string>();
            foreach (Phim phim in unitOfWork.GetAll<Phim>())
            {
                tenphim.Add(phim.TenPhim);
            }
            cbb.Items.Add("Tất cả");
            cbb.Items.AddRange(tenphim.ToArray());
            cbb.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb.SelectedIndex = 0;
        }
        public void SetDGV(DataGridView dgv,ComboBox cbb,Label tongtien)
        {
            tongtien.Text = "0";
            List<HoaDon> hoadon = new List<HoaDon>();
            if(cbb.SelectedIndex==0)
            {
                dgv.DataSource = unitOfWork.GetAll<HoaDon>();
            }
            else
            {
                foreach(HoaDon hd in unitOfWork.GetAll<HoaDon>())
                {
                    if(hd.TenPhim==cbb.SelectedItem.ToString())
                    {
                        hoadon.Add(hd);
                    }
                }
                dgv.DataSource = hoadon;
            }
            dgv.Columns["Id"].HeaderText="Mã Hóa Đơn";
            dgv.Columns["TenPhim"].HeaderText="Tên Phim";
            dgv.Columns["TongTien"].HeaderText="Tổng Tiền";
            dgv.Columns["TenNVBH"].HeaderText="Nhân Viên Bán Hàng";
            dgv.Columns["TenKhach"].HeaderText="Tên Khách Hàng";
            dgv.Columns["GhiChu"].HeaderText="Ghi Chú";
            dgv.Columns["GhiChu"].DisplayIndex=5;
            foreach(DataGridViewRow dr in dgv.Rows)
            {
                dr.Cells["TongTien"].Value = double.Parse(dr.Cells["TongTien"].Value.ToString()) * 1000;
                tongtien.Text = (double.Parse(tongtien.Text) + (double.Parse(dr.Cells[2].Value.ToString()))).ToString();
            }
        }
    }
}

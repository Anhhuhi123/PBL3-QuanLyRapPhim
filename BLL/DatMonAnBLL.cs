using BLL.UnitOfWork;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DatMonAnBLL
    {
        readonly CinemaUnitOfWork unitOfWork;
        readonly DataTable dt;
        int idhoadon;
        public DatMonAnBLL(int id)
        {
            idhoadon=id;
            unitOfWork = CinemaUnitOfWork.Instance;
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("Id"),
                new DataColumn("TenMonAn"),
                new DataColumn("GiaTien"),
                new DataColumn("SoLuong") });
        }
        public void DeleteARow(DataGridView dataGridView1,Label total)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    total.Text=Convert.ToString(Convert.ToDouble(total.Text)-Convert.ToDouble(row.Cells["GiaTien"].Value));
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
                MessageBox.Show("Chọn một hàng để xóa");
        }
        public void DeleteAll(DataGridView dataGridView1,Label total)
        {
            dt.Rows.Clear();
            total.Text="0";
        }

        public void SetBangGia(DataGridView dataGridView2)
        {
            dataGridView2.DataSource=unitOfWork.GetAll<MonAn>();
            dataGridView2.Columns["Id"].HeaderText="Mã món ăn";
            dataGridView2.Columns["TenMonAn"].HeaderText="Tên món ăn";
            dataGridView2.Columns["GiaTien"].HeaderText="Giá tiền";
        }
        public int KiemTraMonAn(DataGridView dataGridView1, string tenMonAn)
        {
            if(dataGridView1.Rows.Count==0)
            {
                return 0;
            }
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TenMonAn"].Value.ToString()==tenMonAn)
                {
                    return Convert.ToInt32(row.Cells["Id"].Value);
                }
            }
            return 0;
        }
        public void SetMonAnHoaDon(DataGridView dgv)
        {
            dgv.DataSource=dt;
            dgv.AllowUserToAddRows=false;
            dgv.Columns["Id"].HeaderText="Thứ tự";
            dgv.Columns["TenMonAn"].HeaderText="Tên món ăn";
            dgv.Columns["GiaTien"].HeaderText="Giá tiền";
            dgv.Columns["SoLuong"].HeaderText="Số lượng";
            dgv.Columns["SoLuong"].DisplayIndex=3;
        }

        public void ThemMonAn(Button sender1, DataGridView dataGridView1, DataGridView datagridview2,Label total)
        {
            foreach(DataGridViewRow row in datagridview2.Rows)
            {
                if (row.Cells["TenMonAn"].Value.ToString()==sender1.Text)
                {
                    int vitri = KiemTraMonAn(dataGridView1,sender1.Text);
                    double giaTien = Convert.ToDouble(row.Cells["GiaTien"].Value.ToString());
                    int soLuong = 1;
                    if (vitri!=0)
                    {
                        soLuong = Convert.ToInt32(dataGridView1.Rows[vitri-1].Cells["SoLuong"].Value.ToString());
                        dataGridView1.Rows[vitri-1].Cells["SoLuong"].Value=soLuong+1;
                        dataGridView1.Rows[vitri-1].Cells["GiaTien"].Value=giaTien*(soLuong+1);
                    }
                    else
                    {
                        vitri = dataGridView1.Rows.Count + 1;
                        string tenmon = row.Cells["TenMonAn"].Value.ToString();
                        dt.Rows.Add(vitri,tenmon,giaTien,soLuong);
                    }
                    total.Text = Convert.ToString(Convert.ToDouble(total.Text) + giaTien);
                    return;
                }
            }
        }

        public void XacNhanMon(DataGridView dataGridView1)
        {
            double tong = 0;
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                string tenmon=dr.Cells["TenMonAn"].Value.ToString();
                int idMon = unitOfWork.GetMonByName(tenmon).Id;
                int soLuong = Convert.ToInt32(dr.Cells["SoLuong"].Value);
                double giaTien = Convert.ToDouble(dr.Cells["GiaTien"].Value);
                MonDuocDat mon = new MonDuocDat(idMon,tenmon,giaTien,soLuong);
                unitOfWork.ThemMonAnVaoHoaDon(mon.Id,idhoadon,mon.SoLuong);
                tong+=giaTien/1000;
            }
            unitOfWork.UpdateHoaDon(idhoadon, tong);
        }
    }
}

using DAO;
using BLL.UnitOfWork;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BLL
{
    public class VeDuocDatEventArgs : EventArgs
    {
        public VeDuocDat VeDuocDat { get; set; }
        public VeDuocDatEventArgs(VeDuocDat veDuocDat)
        {
            VeDuocDat = veDuocDat;
        }
    }
    public class BanVeBLL
    {
        CinemaUnitOfWork unitOfWork;
        NguoiDungBLL nguoiDungBLL;
        public List<MonDuocDat> monDuocDatList;
        public delegate void VeDatThanhCongEventHandler(object sender, VeDuocDatEventArgs e);
        public VeDatThanhCongEventHandler eventHandler;
        public BanVeBLL()
        {
            unitOfWork = CinemaUnitOfWork.Instance;
            nguoiDungBLL = new NguoiDungBLL();
            monDuocDatList= new List<MonDuocDat>();
        }

        public List<GheNgoi> Search(TextBox textbox,DateTimePicker dtpicker, CheckBox dTSearch, ComboBox cbb, DataGridView dataGridView1,Panel panel)
        { 
            DateTime value = dtpicker.Value;
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn lịch chiếu");
                return null;
            }
            else if(dataGridView1.SelectedRows.Count>1)
            {
                MessageBox.Show("Chỉ được chọn 1 lịch chiếu");
                return null;
            }
            DataGridViewRow selectedrow= dataGridView1.SelectedRows[0];
            int idLich = Convert.ToInt32(selectedrow.Cells["Id"].Value);
            int idPhong= unitOfWork.GetPhongByName(cbb.Text).Id;
            List<GheNgoi> list = unitOfWork.GetAllGhe(idLich, idPhong);
            return list;
        }

        public void SetDGV(TextBox textbox, DataGridView dgv, DateTimePicker dtpicker, CheckBox dTsearch, ComboBox cbb)
        {
            int idPhong = unitOfWork.GetPhongByName(cbb.Text).Id;
            List<LichChieu> list = new List<LichChieu>();
            DateTime value = dtpicker.Value.Date;
            if (dTsearch.Checked)
            {
                MessageBox.Show(value.ToString());
                foreach (LichChieu lc in unitOfWork.GetLichDangChieu(idPhong))
                {
                    if (lc.NgayChieu == value && lc.TenPhim == textbox.Text)
                    {
                        list.Add(lc);
                    }
                }
            }
            else
            {
                foreach (LichChieu lc in unitOfWork.GetLichDangChieu(idPhong))
                {
                    if (lc.TenPhim == textbox.Text)
                        list.Add(lc);
                }
            }
            dgv.DataSource = list;
            LichChieuBLL.setDGVHeader(dgv);
        }

        public void SetCbb(ComboBox cbb)
        {
            List<string> list = new List<string>();
            foreach (PhongChieu phongChieu in unitOfWork.GetAll<PhongChieu>())
            {
                list.Add(phongChieu.Name);
            }
            cbb.Items.AddRange(list.ToArray());
            cbb.SelectedIndex= 0;   
            cbb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void HuyVe(FlowLayoutPanel flowLayoutPanel1,Label lbl)
        {
            foreach(Button button in flowLayoutPanel1.Controls)
            {
                if(button.BackColor == System.Drawing.Color.Green)
                {
                    button.BackColor = System.Drawing.Color.Red;
                }
            }
            lbl.Text = "0";
        }
        public void GheButton_Click(Button button, Label totallbl)
        {
            switch (button.BackColor.Name)
            {
                case "Red":
                    button.BackColor = System.Drawing.Color.Green;
                    setPrice(totallbl, true);
                    break;
                case "Green":
                    button.BackColor = System.Drawing.Color.Red;
                    setPrice(totallbl, false);
                    break;
                case "Gray":
                    MessageBox.Show("Ghế đã có người đặt");
                    break;
            }
        }

        public void DatVe(DataGridView dataGridView1,ComboBox comboBox1, FlowLayoutPanel flowLayoutPanel1,Label lbl)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn lịch chiếu");
                return;
            }
            else if(dataGridView1.SelectedRows.Count>1)
            {
                MessageBox.Show("Chỉ được chọn 1 lịch chiếu");
                return;
            }
            List<GheNgoi> listGheNgoi = new List<GheNgoi>();
            try
            {
                int idphong = unitOfWork.GetPhongByName(comboBox1.Text).Id;
                int idLich = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                foreach (Button btn in flowLayoutPanel1.Controls)
                {
                    if (btn.BackColor == System.Drawing.Color.Green)
                    {
                        int idGhe = Convert.ToInt32(btn.Name);
                        GheNgoi gheNgoi = unitOfWork.GetGheNgoi(idGhe, idLich, idphong);
                        gheNgoi.TrangThai = false;
                        listGheNgoi.Add(gheNgoi);
                    }
                }
                if(listGheNgoi.Count == 0)
                {
                    MessageBox.Show("Chưa chọn ghế");
                    return;
                }
                else
                {
                    int idVeDuocDat = 1;
                    if (unitOfWork.GetAll<VeDuocDat>() != null)
                    {
                        idVeDuocDat= unitOfWork.GetAll<VeDuocDat>().Count+1;
                    }
                    VeDuocDat vdd = new VeDuocDat(idVeDuocDat,listGheNgoi.Count, Convert.ToDouble(lbl.Text));
                    unitOfWork.InsertVeDuocDat(vdd, idLich);
                    foreach (GheNgoi gheNgoi in listGheNgoi)
                    {
                        unitOfWork.UpdateGheNgoi(gheNgoi, idLich, idphong, vdd.Id);
                    }
                    eventHandler.Invoke(this,new VeDuocDatEventArgs(vdd));
                    foreach(Button btn in flowLayoutPanel1.Controls)
                    {
                        if(btn.BackColor == System.Drawing.Color.Green)
                        {
                            btn.BackColor = System.Drawing.Color.Gray;
                        }
                    }
                    lbl.Text = "0";
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi "+e.Message);
            }
        }

        public void setPrice(Label totallbl,bool isIncrease)
        {
            double price;
            if (isIncrease)
                price = Convert.ToDouble(totallbl.Text) + 100;
            else price = Convert.ToDouble(totallbl.Text) - 100;
            if (price == 0)
            {
                totallbl.Text = "0";
                return;
            }
            totallbl.Text = price.ToString(".000");
        }

        public HoaDon XuLyDatVeThanhCong(KhachHang khachHang,VeDuocDat vdd,string tenphim ,string idnvbh,string ghichu)
        {
            NguoiDung nVBH = nguoiDungBLL.GetNguoiDung(idnvbh);
            int idHoaDon= 1;
            if(unitOfWork.GetAll<HoaDon>()!=null)
            {
                idHoaDon = unitOfWork.GetAll<HoaDon>().Count+1;
            }
            HoaDon hoaDon = new HoaDon(idHoaDon,tenphim,vdd.TongTien,ghichu,khachHang.FullName,nVBH.FullName);
            unitOfWork.InsertHoaDon(hoaDon,nVBH.Id,khachHang.Id,vdd.Id);
            return hoaDon;
        }

        public void GetMonAn(DataGridView dgv)
        {
            foreach(DataGridViewRow dr in dgv.Rows)
            {
                string tenmon=dr.Cells["TenMonAn"].Value.ToString();
                int idMon = unitOfWork.GetMonByName(tenmon).Id;
                int soLuong = Convert.ToInt32(dr.Cells["SoLuong"].Value);
                double giaTien = Convert.ToDouble(dr.Cells["GiaTien"].Value);
                MonDuocDat monDuocDat = new MonDuocDat(idMon,tenmon, giaTien, soLuong);
                monDuocDatList.Add(monDuocDat);
            }
        }

        public void XoaVe(VeDuocDat veDuocDat)
        {
            foreach(GheNgoi ghe in unitOfWork.GetAllGhe(veDuocDat))
            {
                ghe.TrangThai = true;
                unitOfWork.UpdateGheNgoi(ghe,veDuocDat.Id);
            }
            unitOfWork.Delete<VeDuocDat>(veDuocDat.Id);
        }
    }
}

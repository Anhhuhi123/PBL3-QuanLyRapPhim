using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BLL
{
    public class NguoiDungBLL
    {
        private void SetDGVHeader(DataGridView dgv,ComboBox cb)
        {
            dgv.Columns["Id"].HeaderText = "Mã số";
            dgv.Columns["FullName"].HeaderText = "Họ tên";
            dgv.Columns["SoDT"].HeaderText = "Số điện thoại";
            dgv.Columns["Email"].HeaderText = "Email";
            dgv.Columns["VaiTro"].HeaderText = "Vai trò";
            switch (cb.Text)
            {
                case "Nhân viên bán hàng":
                    dgv.Columns["KPI"].HeaderText = "KPI";
                    dgv.Columns["Active"].HeaderText = "Trạng thái";
                    break;
                case "Nhân viên quản lý":
                case " Nhân viên":
                    dgv.Columns["Active"].HeaderText = "Trạng thái";
                    break;
                default:
                    break;

            }
            return;
        }
        public void SetCbb(ComboBox rolecbb)
        {
            rolecbb.Items.Clear();
            rolecbb.Items.Add("Người dùng");
            rolecbb.Items.Add("Nhân viên");
            rolecbb.Items.Add("Nhân viên quản lý");
            rolecbb.Items.Add("Nhân viên bán hàng");
            rolecbb.Items.Add("Khách hàng");
            rolecbb.DropDownStyle = ComboBoxStyle.DropDownList;
            rolecbb.SelectedIndex = 0;
        }
        public void setDGV(DataGridView dgv, ComboBox cb)
        {
            switch (cb.Text)
            {
                case "Khách hàng":
                    dgv.DataSource = UnitofWork.Instance.KhachHangDAO.GetAll();
                    break;
                case "Nhân viên quản lý":
                    dgv.DataSource = UnitofWork.Instance.NhanVienQuanLyDAO.GetAll();
                    break;
                case "Nhân viên bán hàng":
                    dgv.DataSource = UnitofWork.Instance.NhanVienBanHangDAO.GetAll();
                    break;
                case "Nhân viên":
                    dgv.DataSource = UnitofWork.Instance.NhanVienDAO.GetAll();
                    break;
                case "Người dùng":
                    dgv.DataSource = UnitofWork.Instance.NguoiDungDAO.GetAll();
                    break;
                default:
                    throw new Exception("Không hợp lệ!");
            }
            SetDGVHeader(dgv,cb);
            return;
        }
        public void Insert(TextBox txtid, TextBox txtname, ComboBox role, TextBox sdt, TextBox email, TextBox kpi, RadioButton bt)
        {
            string id = txtid.Text;
            string name = txtname.Text;
            string vaitro = role.Text;
            string sodt = sdt.Text;
            string mail = email.Text;
            bool active = bt.Checked;
            int kpi1 = (kpi.Text == "") ? 0 : Convert.ToInt32(kpi.Text);
            try
            {
                switch (vaitro)
                {
                    case "Khách hàng":
                        KhachHang kh = new KhachHang(id, name, sodt, mail, vaitro);
                        UnitofWork.Instance.NguoiDungDAO.Insert(kh);
                        UnitofWork.Instance.KhachHangDAO.Insert(kh);
                        break;
                    case "Nhân viên quản lý":
                        NVQL nvql = new NVQL(id, name, sodt, mail, vaitro, active);
                        UnitofWork.Instance.NguoiDungDAO.Insert(nvql);
                        UnitofWork.Instance.NhanVienDAO.Insert(nvql);
                        UnitofWork.Instance.TaiKhoanDAO.Insert(new TaiKhoan(id, "123"));
                        UnitofWork.Instance.NhanVienQuanLyDAO.Insert(nvql);
                        break;
                    case "Nhân viên bán hàng":
                        NVBH nvbh = new NVBH(id, name, sodt, mail, vaitro, active, kpi1);
                        UnitofWork.Instance.NguoiDungDAO.Insert(nvbh);
                        UnitofWork.Instance.NhanVienDAO.Insert(nvbh);
                        UnitofWork.Instance.TaiKhoanDAO.Insert(new TaiKhoan(id, "123"));
                        UnitofWork.Instance.NhanVienBanHangDAO.Insert(nvbh);
                        break;
                    default:
                        throw new Exception("Vai trò không hợp lệ");
                }
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
        }
        public void Delete(TextBox txtid,ComboBox role)
        {
            string id = txtid.Text;
            string vaitro = role.Text;
            try
            {
                switch (vaitro)
                {
                    case "Khách hàng":
                        UnitofWork.Instance.KhachHangDAO.Delete(id);
                        UnitofWork.Instance.NguoiDungDAO.Delete(id);
                        break;
                    case "Nhân viên quản lý":
                        UnitofWork.Instance.NhanVienQuanLyDAO.Delete(id);
                        UnitofWork.Instance.TaiKhoanDAO.Delete(id);
                        UnitofWork.Instance.NhanVienDAO.Delete(id);
                        UnitofWork.Instance.NguoiDungDAO.Delete(id);
                        break;
                    case "Nhân viên bán hàng":
                        UnitofWork.Instance.NhanVienBanHangDAO.Delete(id);
                        UnitofWork.Instance.TaiKhoanDAO.Delete(id);
                        UnitofWork.Instance.NhanVienDAO.Delete(id);
                        UnitofWork.Instance.NguoiDungDAO.Delete(id);
                        break;
                    default:
                        throw new Exception("Vai trò không hợp lệ");
                }
                MessageBox.Show("Xóa thành công!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
        }
        public void Update(TextBox txtid, TextBox txtname, ComboBox role, TextBox sdt, TextBox email, TextBox kpi, RadioButton bt)
        {
            string id= txtid.Text;
            string name = txtname.Text;
            string vaitro = role.Text;
            string sodt = sdt.Text;
            string mail = email.Text;
            bool active = bt.Checked;
            int kpi1 = (kpi.Text == "") ? 0 : Convert.ToInt32(kpi.Text);
            switch (vaitro)
            {
                case "Khách hàng":
                    KhachHang kh = new KhachHang(id, name, sodt, mail, vaitro);
                    UnitofWork.Instance.NguoiDungDAO.Update(kh);
                    break;
                case "Nhân viên quản lý":
                    NVQL nvql = new NVQL(id, name, sodt, mail, vaitro, active);
                    UnitofWork.Instance.NguoiDungDAO.Update(nvql);
                    UnitofWork.Instance.NhanVienDAO.Update(nvql);
                    break;
                case "Nhân viên bán hàng":
                    NVBH nvbh = new NVBH(id, name, sodt, mail, vaitro, active, kpi1);
                    UnitofWork.Instance.NguoiDungDAO.Update(nvbh);
                    UnitofWork.Instance.NhanVienDAO.Update(nvbh);
                    UnitofWork.Instance.NhanVienBanHangDAO.Update(nvbh);
                    break;
                default:
                    MessageBox.Show("Vai trò không hợp lệ");
                    break;
            }
            MessageBox.Show("Sửa thành công!");
        }
        public void setInfo(TextBox txtId, TextBox txtFullname, ComboBox rolecbb, TextBox txtNumber, TextBox txtemail, TextBox txtKPI, RadioButton activerdb, int index, DataGridView dgv)
        {
            if (index >= 0)
            {
                DataGridViewRow row = dgv.Rows[index];
                row.Selected = true;
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtFullname.Text = row.Cells["FullName"].Value.ToString();
                txtNumber.Text = row.Cells["SoDT"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                if (rolecbb.Text.Contains("Nhân viên"))
                {
                    activerdb.Checked = Convert.ToBoolean(row.Cells["Active"].Value);
                    if (rolecbb.Text.Contains("bán hàng"))
                    {
                        txtKPI.Text = row.Cells["KPI"].Value.ToString();
                    }
                }
                rolecbb.Text = row.Cells[4].Value.ToString();
            }
        }


        public void xuLySuKien(Button sender, TextBox txtid, TextBox txtname, ComboBox role, TextBox sdt, TextBox email, TextBox kpi, RadioButton bt)
        {
            try
            {
                switch (sender.Text)
                {
                    case "Thêm":
                        Insert(txtid, txtname, role, sdt, email, kpi, bt);
                        break;
                    case "Xóa":
                        Delete(txtid, role);
                        break;
                    case "Sửa":
                        Update(txtid, txtname, role, sdt, email, kpi, bt);
                        break;
                    default:
                        MessageBox.Show("Không hợp lệ!");
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
        }

        public NguoiDung GetNguoiDung(string idnvql)
        {
            foreach(NguoiDung nd in UnitofWork.Instance.NguoiDungDAO.GetAll())
            {
                if (nd.Id == idnvql)
                    return nd;
            }
            return null;
        }


    }
}

using DTO;
using BLL.UnitOfWork;
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
                    dgv.DataSource = UserUnitOfWork.Instance.GetAllKhachHang();
                    break;
                case "Nhân viên quản lý":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAllNhanVienQuanLy();
                    break;
                case "Nhân viên bán hàng":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAllNhanVienBanHang();
                    break;
                case "Nhân viên":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAllNhanVien();
                    break;
                case "Người dùng":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAllNguoiDung();
                    break;
                default:
                    throw new Exception("Không hợp lệ!");
            }
            SetDGVHeader(dgv,cb);
            return;
        }
        public bool CheckIdIsExist(string id)
        {
            foreach(NguoiDung nd in UserUnitOfWork.Instance.GetAllNguoiDung())
            {
                if (nd.Id == id)
                    return true;
            }
            return false;
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
                if(id=="")
                    throw new Exception("Chưa nhập mã số");
                if(sodt.Length>10)
                    throw new Exception("Số điện thoại không hợp lệ");
                switch (vaitro)
                {
                    case "Khách hàng":
                        KhachHang kh = new KhachHang(id, name, sodt, mail, vaitro);
                        UserUnitOfWork.Instance.InsertKhachHang(kh);
                        break;
                    case "Nhân viên quản lý":
                        NVQL nvql = new NVQL(id, name, sodt, mail, vaitro, active);
                        UserUnitOfWork.Instance.InsertNhanVienQuanLy(nvql);
                        break;
                    case "Nhân viên bán hàng":
                        NVBH nvbh = new NVBH(id, name, sodt, mail, vaitro, active, kpi1);
                        UserUnitOfWork.Instance.InsertNhanVienBanHang(nvbh);
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
        public void Delete(DataGridView dgv)
        {
            try
            {
                if(dgv.SelectedRows.Count==0)
                {
                    throw new Exception("Chưa chọn dòng nào!");
                }
                foreach (DataGridViewRow dr in dgv.SelectedRows)
                {
                    string id = dr.Cells["Id"].Value.ToString();
                    string vaitro = dr.Cells["VaiTro"].Value.ToString();
                    switch (vaitro)
                    {
                        case "Khách hàng":
                            throw new Exception("Không thể xóa khách hàng!");
                        case "Nhân viên quản lý":
                            UserUnitOfWork.Instance.DeleteNhanVienQuanLy(id);
                            break;
                        case "Nhân viên bán hàng":
                            UserUnitOfWork.Instance.DeleteNhanVienBanHang(id);
                            break;
                        default:
                            throw new Exception("Vai trò không hợp lệ");
                    }
                }
                MessageBox.Show("Xóa thành công!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
        }
        public void Update(TextBox txtid, TextBox txtname,ComboBox role, TextBox sdt, TextBox email, TextBox kpi, RadioButton bt)
        {
            try
            {
                string id = txtid.Text;
                string name = txtname.Text;
                string vaitro = role.Text;
                string sodt = sdt.Text;
                string mail = email.Text;
                bool active = bt.Checked;
                int kpi1 = (kpi.Text == "") ? 0 : Convert.ToInt32(kpi.Text);
                if (sodt.Length > 10)
                    throw new Exception("Số điện thoại không hợp lệ");
                switch (vaitro)
                {
                    case "Khách hàng":
                        KhachHang kh = new KhachHang(id, name, sodt, mail, vaitro);
                        UserUnitOfWork.Instance.UpdateKhachHang(kh);
                        break;
                    case "Nhân viên quản lý":
                        NVQL nvql = new NVQL(id, name, sodt, mail, vaitro, active);
                        UserUnitOfWork.Instance.UpdateNhanVienQuanLy(nvql);
                        break;
                    case "Nhân viên bán hàng":
                        NVBH nvbh = new NVBH(id, name, sodt, mail, vaitro, active, kpi1);
                        UserUnitOfWork.Instance.UpdateNhanVienBanHang(nvbh);
                        break;
                    default:
                        MessageBox.Show("Vai trò không hợp lệ");
                        break;
                }
                MessageBox.Show("Sửa thành công!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
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
                    case "Sửa":
                        Update(txtid, txtname, role,sdt, email, kpi, bt);
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

        public NguoiDung GetNguoiDung(string idnd)
        {
            foreach(NguoiDung nd in UserUnitOfWork.Instance.GetAllNguoiDung())
            {
                if (nd.Id == idnd)
                    return nd;
            }
            return null;
        }
        public KhachHang AddOrUpdateKH(TextBox id,TextBox name,TextBox Phone,TextBox email)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Chưa nhập mã số");
                return null;
            }
            KhachHang temp = new KhachHang(id.Text, name.Text, Phone.Text, email.Text, "Khách hàng");
            try
            {
                if(temp.SoDt.Length>10)
                    throw new Exception("Số điện thoại không hợp lệ");
                if (CheckIdIsExist(temp.Id))
                {
                    UserUnitOfWork.Instance.UpdateKhachHang(temp);
                }
                else
                {
                    UserUnitOfWork.Instance.InsertKhachHang(temp);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                return null;
            }
            return temp;
        }
    }
}

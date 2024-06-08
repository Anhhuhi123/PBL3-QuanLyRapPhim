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
        public string idNVQL;
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
                    dgv.DataSource = UserUnitOfWork.Instance.GetAll<KhachHang>();
                    break;
                case "Nhân viên quản lý":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAll<NVQL>();
                    break;
                case "Nhân viên bán hàng":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAll<NVBH>();
                    break;
                case "Nhân viên":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAll<NhanVien>();
                    break;
                case "Người dùng":
                    dgv.DataSource = UserUnitOfWork.Instance.GetAll<NguoiDung>();
                    break;
                default:
                    throw new Exception("Không hợp lệ!");
            }
            SetDGVHeader(dgv,cb);
            return;
        }

        public void Insert(TextBox txtid, TextBox txtname, ComboBox role, TextBox sdt, TextBox email, TextBox kpi, CheckBox bt)
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
                if (id == "" || name =="" || sodt=="")
                    throw new Exception("Chưa nhập đầy đủ thông tin");
                if(UserUnitOfWork.Instance.GetById<NguoiDung>(id)!=null)
                    throw new Exception("Mã số đã tồn tại");
                if(id.Length!=10)
                    throw new Exception("Mã số không hợp lệ");
                if(sodt.Length>10)
                    throw new Exception("Số điện thoại không hợp lệ");
                switch (vaitro)
                {
                    case "Khách hàng":
                        KhachHang kh = new KhachHang(id, name, sodt, mail, vaitro);
                        UserUnitOfWork.Instance.Insert(kh);
                        break;
                    case "Nhân viên quản lý":
                        NVQL nvql = new NVQL(id, name, sodt, mail, vaitro, active);
                        UserUnitOfWork.Instance.Insert(nvql);
                        break;
                    case "Nhân viên bán hàng":
                        NVBH nvbh = new NVBH(id, name, sodt, mail, vaitro, active, kpi1);
                        UserUnitOfWork.Instance.Insert(nvbh);
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
                    if(id==idNVQL)
                    {
                        throw new Exception("Không thể xóa chính mình!");
                    }
                    string vaitro = dr.Cells["VaiTro"].Value.ToString();
                    switch (vaitro)
                    {
                        case "Khách hàng":
                           UserUnitOfWork.Instance.Delete<KhachHang>(id);
                            break;
                        case "Nhân viên quản lý":
                            UserUnitOfWork.Instance.Delete<NVQL>(id);
                            break;
                        case "Nhân viên bán hàng":
                            UserUnitOfWork.Instance.Delete<NVBH>(id);
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
        public void Update(TextBox txtid, TextBox txtname,ComboBox role, TextBox sdt, TextBox email, TextBox kpi, CheckBox bt)
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
                if (id == "" || name == "" || sodt == "")
                    throw new Exception("Chưa nhập đầy đủ thông tin");
                if (UserUnitOfWork.Instance.GetById<NguoiDung>(id) == null)
                    throw new Exception("Mã số không tồn tại");
                if (sodt.Length > 10)
                    throw new Exception("Số điện thoại không hợp lệ");
                switch (vaitro)
                {
                    case "Khách hàng":
                        KhachHang kh = new KhachHang(id, name, sodt, mail, vaitro);
                        UserUnitOfWork.Instance.Update(kh);
                        break;
                    case "Nhân viên quản lý":
                        NVQL nvql = new NVQL(id, name, sodt, mail, vaitro, active);
                        UserUnitOfWork.Instance.Update(nvql);
                        break;
                    case "Nhân viên bán hàng":
                        NVBH nvbh = new NVBH(id, name, sodt, mail, vaitro, active, kpi1);
                        UserUnitOfWork.Instance.Update(nvbh);
                        break;
                    default:
                        throw new Exception("Vai trò không hợp lệ");
                }
                MessageBox.Show("Sửa thành công!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
        }
        public void setInfo(TextBox txtId, TextBox txtFullname, ComboBox rolecbb, TextBox txtNumber, TextBox txtemail, TextBox txtKPI, CheckBox activerdb, int index, DataGridView dgv)
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


        public void xuLySuKien(Button sender, TextBox txtid, TextBox txtname, ComboBox role, TextBox sdt, TextBox email, TextBox kpi, CheckBox bt)
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
        public KhachHang AddOrUpdateKH(TextBox id,TextBox name,TextBox Phone,TextBox email)
        {
            try
            {
                if (id.Text == "")
                {
                    throw new Exception("Chưa nhập mã số khách hàng");
                }
                KhachHang kh = UserUnitOfWork.Instance.GetById<KhachHang>(id.Text);
                if (kh != null)
                {
                    if (name.Text == "" && Phone.Text == "" && email.Text == "")
                    {
                        return kh;
                    }
                    kh.FullName = name.Text;
                    kh.SoDt = Phone.Text;
                    kh.Email = email.Text;
                    UserUnitOfWork.Instance.Update(kh);
                    return kh;
                }
                else
                {
                    if(id.Text.Length!=10)
                    {
                        throw new Exception("Mã số không hợp lệ");
                    }
                    if(name.Text==""||Phone.Text=="")
                    {
                        throw new Exception("Chưa nhập đầy đủ thông tin");
                    }
                    kh = new KhachHang(id.Text, name.Text, Phone.Text, email.Text, "Khách hàng");
                    UserUnitOfWork.Instance.Insert(kh);
                    return kh;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                return null;
            }
        }
    }
}

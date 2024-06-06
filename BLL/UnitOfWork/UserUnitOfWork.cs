using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL.UnitOfWork
{
    public class UserUnitOfWork : IDisposable
    {
        private static UserUnitOfWork _intance;
        public static UserUnitOfWork Instance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new UserUnitOfWork();
                }
                return _intance;
            }
            private set { }
        }
        public NhanVienBanHangDAO NhanVienBanHangDAO { get; private set; }
        public NhanVienQuanLyDAO NhanVienQuanLyDAO { get; private set; }
        public TaiKhoanDAO TaiKhoanDAO { get; private set; }
        public NhanVienDAO NhanVienDAO { get; private set; }
        public KhachHangDAO KhachHangDAO { get; private set; }
        public NguoiDungDAO NguoiDungDAO { get; private set; }

        private UserUnitOfWork() {
            NhanVienBanHangDAO = new NhanVienBanHangDAO();
            NhanVienQuanLyDAO = new NhanVienQuanLyDAO();
            TaiKhoanDAO = new TaiKhoanDAO();
            NhanVienDAO = new NhanVienDAO();
            NguoiDungDAO = new NguoiDungDAO();
            KhachHangDAO = new KhachHangDAO();
        }
        public List<KhachHang> GetAllKhachHang()
        {
            return KhachHangDAO.GetAll();
        }
        public List<NhanVien> GetAllNhanVien()
        {
            return NhanVienDAO.GetAll();
        }
        public List<NguoiDung> GetAllNguoiDung()
        {
            return NguoiDungDAO.GetAll();
        }
        public List<NVBH> GetAllNhanVienBanHang()
        {
            return NhanVienBanHangDAO.GetAll();
        }
        public List<NVQL> GetAllNhanVienQuanLy()
        {
            return NhanVienQuanLyDAO.GetAll();
        }
        public void InsertKhachHang(KhachHang khachHang)
        {
            NguoiDungDAO.Insert(khachHang);
            KhachHangDAO.Insert(khachHang);
        }
        private void InsertNhanVien(NhanVien nhanVien)
        {
            NguoiDungDAO.Insert(nhanVien);
            NhanVienDAO.Insert(nhanVien);
            TaiKhoanDAO.Insert(new TaiKhoan(nhanVien.Id,"123"));
        }
        public void InsertNhanVienBanHang(NVBH nvbh)
        {
            InsertNhanVien(nvbh);
            NhanVienBanHangDAO.Insert(nvbh);
        }
        public void InsertNhanVienQuanLy(NVQL nvql)
        {
            InsertNhanVien(nvql);
            NhanVienQuanLyDAO.Insert(nvql);
        }
        public void DeleteKhachHang(string id)
        {
            KhachHangDAO.Delete(id);
            NguoiDungDAO.Delete(id);
        }
        private void DeleteNhanVien(string id)
        {
            TaiKhoanDAO.Delete(id);
            NhanVienDAO.Delete(id);
            NguoiDungDAO.Delete(id);
        }
        public void DeleteNhanVienQuanLy(string id)
        {
            NhanVienQuanLyDAO.Delete(id);
            DeleteNhanVien(id);
        }
        public void DeleteNhanVienBanHang(string id)
        {
            NhanVienBanHangDAO.Delete(id);
            DeleteNhanVien(id);
        }
        public void UpdateKhachHang(KhachHang khachHang)
        {
            KhachHangDAO.Update(khachHang);
            NguoiDungDAO.Update(khachHang);
        }
        private void UpdateNhanVien(NhanVien nhanVien)
        {
            NhanVienDAO.Update(nhanVien);
            NguoiDungDAO.Update(nhanVien);
        }
        public void UpdateNhanVienBanHang(NVBH nvbh)
        {
            UpdateNhanVien(nvbh);
            NhanVienBanHangDAO.Update(nvbh);
        }
        public void UpdateNhanVienQuanLy(NVQL nvql)
        {
            UpdateNhanVien(nvql);
            NhanVienQuanLyDAO.Update(nvql);
        }
        public void Dispose()
        {
            NhanVienBanHangDAO = null;
            NhanVienQuanLyDAO = null;
            TaiKhoanDAO = null;
            NhanVienDAO = null;
            NguoiDungDAO = null;
            KhachHangDAO = null;
            NguoiDungDAO = null;
        }
    }
}

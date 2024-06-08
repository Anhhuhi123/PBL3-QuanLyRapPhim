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
        public T GetById<T>(string id) where T : class
        {
            switch(typeof(T).Name)
            {
                case "KhachHang":
                    return KhachHangDAO.GetById(id) as T;
                case "NhanVien":
                    return NhanVienDAO.GetById(id) as T;
                case "NguoiDung":
                    return NguoiDungDAO.GetById(id) as T;
                case "NVBH":
                    return NhanVienBanHangDAO.GetById(id) as T;
                case "NVQL":
                    return NhanVienQuanLyDAO.GetById(id) as T;
                default:
                    return null;    
            }
        }
        public List<T> GetAll<T>()
        {
            switch(typeof(T).Name)
            {
                case "KhachHang":
                    return KhachHangDAO.GetAll() as List<T>;
                case "NhanVien":
                    return NhanVienDAO.GetAll() as List<T>;
                case "NguoiDung":
                    return NguoiDungDAO.GetAll() as List<T>;
                case "NVBH":
                    return NhanVienBanHangDAO.GetAll() as List<T>;
                case "NVQL":
                    return NhanVienQuanLyDAO.GetAll() as List<T>;
                default:
                    return null;
            }
        }
        public void Insert<T>(T obj) 
        {
            switch(typeof(T).Name)
            {
                case "KhachHang":
                    NguoiDungDAO.Insert(obj as NguoiDung);
                    KhachHangDAO.Insert(obj as KhachHang);
                    break;
                case "NhanVien":
                    NguoiDungDAO.Insert(obj as NguoiDung);
                    NhanVienDAO.Insert(obj as NhanVien);
                    TaiKhoanDAO.Insert(new TaiKhoan((obj as NhanVien).Id));
                    break;
                case "NVBH":
                    Insert(obj as NhanVien);
                    NhanVienBanHangDAO.Insert(obj as NVBH);
                    break;
                case "NVQL":
                    Insert(obj as NhanVien);
                    NhanVienQuanLyDAO.Insert(obj as NVQL);
                    break;
                default:
                    break;
            }

        }
        public void Delete<T>(string id)
        {
            switch (typeof(T).Name)
            {
                case "KhachHang":
                    CinemaUnitOfWork.Instance.SetHoaDon(GetById<KhachHang>(id));
                    KhachHangDAO.Delete(id);
                    NguoiDungDAO.Delete(id);
                    break;
                case "NhanVien":
                    TaiKhoanDAO.Delete(id);
                    NhanVienDAO.Delete(id);
                    NguoiDungDAO.Delete(id);
                    break;
                case "NVBH":
                    CinemaUnitOfWork.Instance.SetHoaDon(GetById<NVBH>(id));
                    NhanVienBanHangDAO.Delete(id);
                    Delete<NhanVien>(id);
                    break;
                case "NVQL":
                    CinemaUnitOfWork.Instance.SetLichChieu(GetById<NVQL>(id));
                    NhanVienQuanLyDAO.Delete(id);
                    Delete<NhanVien>(id);
                    break;
                default:
                    break;
            }
        }
        public void Update<T>(T obj)
        {
            switch (typeof(T).Name)
            {
                case "KhachHang":
                    NguoiDungDAO.Update(obj as NguoiDung);
                    break;
                case "NhanVien":
                    NhanVienDAO.Update(obj as NhanVien);
                    NguoiDungDAO.Update(obj as NguoiDung);
                    break;
                case "NVBH":
                    Update(obj as NhanVien);
                    NhanVienBanHangDAO.Update(obj as NVBH);
                    break;
                case "NVQL":
                    Update(obj as NhanVien);
                    NhanVienQuanLyDAO.Update(obj as NVQL);
                    break;
                default:
                    break;
            }
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

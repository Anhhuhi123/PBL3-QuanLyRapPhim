using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UnitofWork : IDisposable
    {
        private static UnitofWork _intance;
        public static UnitofWork Instance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new UnitofWork();
                }
                return _intance;
            }
            private set { }
        }
        public NhanVienBanHangDAO NhanVienBanHangDAO { get; }
        public NhanVienQuanLyDAO NhanVienQuanLyDAO { get; }
        public TaiKhoanDAO TaiKhoanDAO { get; }
        public NhanVienDAO NhanVienDAO { get; }
        public KhachHangDAO KhachHangDAO { get; }
        public NguoiDungDAO NguoiDungDAO { get;}

        public UnitofWork() {
            NhanVienBanHangDAO = new NhanVienBanHangDAO();
            NhanVienQuanLyDAO = new NhanVienQuanLyDAO();
            TaiKhoanDAO = new TaiKhoanDAO();
            NhanVienDAO = new NhanVienDAO();
            NguoiDungDAO = new NguoiDungDAO();
            KhachHangDAO = new KhachHangDAO();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

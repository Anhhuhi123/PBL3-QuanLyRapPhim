using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;

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
        public NhanVienBanHangDAO NhanVienBanHangDAO { get; private set; }
        public NhanVienQuanLyDAO NhanVienQuanLyDAO { get; private set; }
        public TaiKhoanDAO TaiKhoanDAO { get; private set; }
        public NhanVienDAO NhanVienDAO { get; private set; }
        public KhachHangDAO KhachHangDAO { get; private set; }
        public NguoiDungDAO NguoiDungDAO { get; private set; }

        private UnitofWork() {
            NhanVienBanHangDAO = new NhanVienBanHangDAO();
            NhanVienQuanLyDAO = new NhanVienQuanLyDAO();
            TaiKhoanDAO = new TaiKhoanDAO();
            NhanVienDAO = new NhanVienDAO();
            NguoiDungDAO = new NguoiDungDAO();
            KhachHangDAO = new KhachHangDAO();
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

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UnitOfWork
{
    public class CinemaUnitOfWork
    {
        PhongChieuDAO phongChieuDAO;
        PhimDAO phimDAO;
        LichChieuDAO lichChieuDAO;
        VeDuocDatDAO veDuocDatDAO;
        HoaDonDAO hoaDonDAO;
        MonAnDAO monAnDAO;
        private static CinemaUnitOfWork instance;
        public static CinemaUnitOfWork Instance
        {
            get
            {
                if (instance == null)
                    instance = new CinemaUnitOfWork();
                return instance;
            }
            private set { }
        }
        public CinemaUnitOfWork()
        {
            phongChieuDAO = new PhongChieuDAO();
            lichChieuDAO = new LichChieuDAO();
            phimDAO = new PhimDAO();
            veDuocDatDAO = new VeDuocDatDAO();
            hoaDonDAO = new HoaDonDAO();
        }
        public T GetById<T>(int id) where T:class
        {
            switch (typeof(T).Name)
            {
                case "PhongChieu":
                    return phongChieuDAO.GetById(id) as T;
                case "LichChieu":
                    return lichChieuDAO.GetById(id) as T;
                case "Phim":
                    return phimDAO.GetById(id) as T;
                case "MonAn":
                    return monAnDAO.GetById(id) as T;
                default:
                    return null;
            }
        }
        public List<T> GetAll<T>()
        {
            switch (typeof(T).Name)
            {
                case "PhongChieu":
                    return phongChieuDAO.GetAll() as List<T>;
                case "LichChieu":
                    return lichChieuDAO.GetAll() as List<T>;
                case "Phim":
                    return phimDAO.GetAll() as List<T>;
                case "VeDuocDat":
                    return veDuocDatDAO.GetAll() as List<T>;
                case "HoaDon":
                    return hoaDonDAO.GetAll() as List<T>;
                case "MonAn":
                    return monAnDAO.GetAll() as List<T>;
                default:
                    return null;
            }
        }
        //Ham insert cho LichChieu
        public void InsertLichChieu(LichChieu lichChieu, int idphim, string idnvql)
        {
            lichChieuDAO.Insert(lichChieu, idphim, idnvql);
        }
        public void InsertVeDuocDat(VeDuocDat vdd, int idLich)
        {
            veDuocDatDAO.Insert(vdd, idLich);
        }
        public void InsertHoaDon(HoaDon hoaDon, string idNVBH, string idKhachHang, int idVeDuocDat)
        {
            hoaDonDAO.Insert(hoaDon, idNVBH, idKhachHang, idVeDuocDat);
        }
        public void Insert<T>(T obj)
        {
            switch (typeof(T).Name)
            {
                case "PhongChieu":
                    phongChieuDAO.Insert(obj as PhongChieu);
                    break;
                case "Phim":
                    phimDAO.Insert(obj as Phim);
                    break;
                default:
                    break;
            }
        }

        public void Delete<T>(int id)
        {
            switch (typeof(T).Name)
            {
                case "PhongChieu":
                    phongChieuDAO.Delete(id);
                    break;
                case "LichChieu":
                    lichChieuDAO.Delete(id);
                    break;
                case "Phim":
                    phimDAO.Delete(id);
                    break;
                default:
                    break;
            }
        }
        public void Update<T>(T obj)
        {
            switch (typeof(T).Name)
            {
                case "PhongChieu":
                    phongChieuDAO.Update(obj as PhongChieu);
                    break;
                case "LichChieu":
                    lichChieuDAO.Update(obj as LichChieu);
                    break;
                case "Phim":
                    phimDAO.Update(obj as Phim);
                    break;
                default:
                    break;
            }
        }
        //Khu vuc danh cho PhongChieu_LichChieu
        public bool CheckPhimDangChieu(int idlc, int idPhong)
        {
            foreach (LichChieu lc in GetLichDangChieu(idPhong))
            {
                if (lc.Id == idlc)
                    return true;
            }
            return false;
        }
        public void ThemSuatChieu(int idlc, int idPhong)
        {
            if (CheckPhimDangChieu(idlc, idPhong))
            {
                throw new Exception("Lịch chiếu đã có trong phòng chiếu");
            }
            lichChieuDAO.ThemPhimDangChieu(idlc, idPhong);
        }
        public void XoaSuatChieu(int idlc, int idphong)
        {
            lichChieuDAO.XoaPhimDangChieu(idlc, idphong);
        }

        //Lay danh sach suat chieu.
        public List<LichChieu> GetLichDangChieu(int id)
        {
            return lichChieuDAO.GetLichDangChieu(id);
        }
        public List<PhongChieu> GetAllPhongDangChieuPhim(int id)
        {
            return phongChieuDAO.GetAllPhongDangChieuPhim(id);
        }

        //tim kiem theo ten cho phim
        public int SearchPhimByName(string name)
        {
            foreach (Phim phim in GetAll<Phim>())
            {
                if (phim.TenPhim == name)
                    return phim.Id;
            }
            return 0;
        }
        //danh cho phong chieu
        public PhongChieu GetPhongByName(string name)
        {
            foreach (PhongChieu phongChieu in GetAll<PhongChieu>())
            {
                if (phongChieu.Name == name)
                    return phongChieu;
            }
            return null;
        }
    }
}

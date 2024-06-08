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
        readonly PhongChieuDAO phongChieuDAO;
        readonly PhimDAO phimDAO;
        readonly LichChieuDAO lichChieuDAO;
        readonly GheNgoiDAO ghengoidao;
        readonly VeDuocDatDAO veDuocDatDAO;
        readonly HoaDonDAO hoaDonDAO;
        readonly MonAnDAO monAnDAO;
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
        private CinemaUnitOfWork()
        {
            ghengoidao = new GheNgoiDAO();
            phongChieuDAO = new PhongChieuDAO();
            lichChieuDAO = new LichChieuDAO();
            phimDAO = new PhimDAO();
            veDuocDatDAO = new VeDuocDatDAO();
            hoaDonDAO = new HoaDonDAO();
            monAnDAO = new MonAnDAO();
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
        public GheNgoi GetGheNgoi(int id , int idlich, int idphong)
        {
            foreach (GheNgoi gheNgoi in GetAllGhe(idlich, idphong))
            {
                if (gheNgoi.Id == id)
                {
                    return gheNgoi;
                }
            }
            return null;
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
        public List<GheNgoi> GetAllGhe(int idLich, int idPhong)
        {
            return ghengoidao.GetAll(idLich, idPhong);
        }
        public List<LichChieu>GetAllLichChieuTheoPhim(int idphim)
        {
            return lichChieuDAO.GetAllLichChieuTheoPhim(idphim);
        }
        public void Insert(LichChieu lichChieu, int idphim, string idnvql)
        {
            lichChieuDAO.Insert(lichChieu, idphim, idnvql);
        }
        public void Insert(VeDuocDat vdd, int idLich)
        {
            veDuocDatDAO.Insert(vdd, idLich);
        }
        public void Insert(HoaDon hoaDon, string idNVBH, string idKhachHang, int idVeDuocDat)
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
                    if (GetAllLichChieuTheoPhim(id).Count > 0)
                    {
                        foreach (LichChieu lichChieu in GetAllLichChieuTheoPhim(id))
                        {
                            lichChieuDAO.Delete(lichChieu.Id);
                        }
                    }
                    phimDAO.Delete(id);
                    break;
                case "GheNgoi":
                    ghengoidao.Delete(id);
                    break;
                case"VeDuocDat":
                    veDuocDatDAO.Delete(id);
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
                case "Phim":
                    phimDAO.Update(obj as Phim);
                    break;
                default:
                    break;
            }
        }
        public void Update(LichChieu lichChieu, int idphim, string idnvql)
        {
            lichChieuDAO.Update(lichChieu, idphim, idnvql);
        }
        //gan ghe ngoi voi ghe duoc dat
        public void Update(GheNgoi obj, int idlich, int idphong, int idVeDuocDat)
        {
            ghengoidao.Update(obj, idlich, idphong, idVeDuocDat);
        }
        //khi huy ve duoc dat thi cap nhat lai trang thai ghe
        public void Update(GheNgoi obj,int idVeDuocDat)
        {
            ghengoidao.Update(obj,idVeDuocDat);
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
        public List<LichChieu> GetLichDangChieu(int idphong)
        {
            return lichChieuDAO.GetLichDangChieu(idphong);
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
        //lay danh sach phong chieu dang chieu phim
        public List<PhongChieu> GetAllPhongDangChieuPhim(int idlich)
        {
            return phongChieuDAO.GetAllPhongDangChieuPhim(idlich);
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
        //Mon An
        public MonAn GetMonByName(string name)
        {
            foreach (MonAn monAn in GetAll<MonAn>())
            {
                if (monAn.TenMonAn == name)
                    return monAn;
            }
            return null;
        }

        //Mon An va Hoa Don
        public void ThemMonAnVaoHoaDon(int idmon,int idhoadon,int soluong)
        {
            monAnDAO.ThemMonAnVaoHoaDon(idmon,idhoadon,soluong);
        }
        public void UpdateHoaDon(int idHoaDon, double gia)
        {
            hoaDonDAO.UpdateHoaDon(idHoaDon, gia);
        }
        public List<MonDuocDat> GetChiTietHoaDon(int id)
        {
            return hoaDonDAO.GetChiTietHoaDon(id);
        }

        //Lay Ghe ngoi
        public List<GheNgoi> GetAllGhe(HoaDon hoaDon)
        {
            return ghengoidao.GetGheNgoi(hoaDon);
        }
        public List<GheNgoi> GetAllGhe(VeDuocDat vdd)
        {
            return ghengoidao.GetGheNgoi(vdd);
        }

        //Xoa thong tin cua Khach hang va nhan vien ban hang khi bi xoa trong csdl
        public void SetHoaDon(KhachHang khachHang)
        {
            hoaDonDAO.SetHoaDon(khachHang);
        }
        public void SetHoaDon(NVBH nVBH)
        {
            hoaDonDAO.SetHoaDon(nVBH);
        }
        //xoa thong tin cua nhan vien quan ly khi bi xoa trong csdl
        public void SetLichChieu(NVQL nVQL)
        {
            lichChieuDAO.SetLichChieu(nVQL);
        }
    }
}

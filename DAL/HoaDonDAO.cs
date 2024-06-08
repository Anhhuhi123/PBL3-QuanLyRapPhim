using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        public void Insert(HoaDon hoaDon,string idNVBH, string idKhachHang,int idVeDuocDat)
        {
            string query =@"Insert into HoaDon(Id,TongTien,GhiChu,IdNVBH,IdKhachHang,IdVeDuocDat)
                            values(@Id,@TongTien,@GhiChu,@IdNVBH,@IdKhachHang,@IdVeDuocDat)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@Id", hoaDon.Id);
            sqlParameters[1] = new SqlParameter("@TongTien", hoaDon.TongTien);
            sqlParameters[2] = new SqlParameter("@GhiChu", hoaDon.GhiChu);
            sqlParameters[3] = new SqlParameter("@IdNVBH", idNVBH);
            sqlParameters[4] = new SqlParameter("@IdKhachHang", idKhachHang);
            sqlParameters[5] = new SqlParameter("@IdVeDuocDat", idVeDuocDat);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public List<HoaDon> GetAll()
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = @"SELECT HoaDon.Id,Phim.TenPhim, HoaDon.TongTien, HoaDon.GhiChu, 
            NguoiDungKhachHang.Fullname AS TenKhachHang, 
            NguoiDungNhanVien.Fullname AS TenNVBH
            FROM HoaDon
            LEFT JOIN NguoiDung AS NguoiDungKhachHang ON HoaDon.IdKhachHang = NguoiDungKhachHang.Id
            LEFT JOIN NguoiDung AS NguoiDungNhanVien ON HoaDon.IdNVBH = NguoiDungNhanVien.Id
			INNER JOIN VeDuocDat ON VeDuocDat.Id=HoaDon.Id
			LEFT JOIN LichChieu ON LichChieu.Id=VeDuocDat.IdLichChieu
			LEFT JOIN Phim ON Phim.Id=LichChieu.IdPhim";
            DataTable reader = DatabaseHelper.Instance.GetRecords(query);
            foreach (DataRow dr in reader.Rows)
            {
                int id = Convert.ToInt32(dr["Id"]);
                int tongtien = Convert.ToInt32(dr["TongTien"]);
                string tenphim= (dr["TenPhim"].ToString()=="")?"Đã bị xóa":dr["TenPhim"].ToString();
                string ghichu = dr["GhiChu"].ToString();
                string tenKhachHang = (dr["TenKhachHang"].ToString()=="")?"Đã bị xóa" : dr["TenKhachHang"].ToString();
                string tenNVBH = (dr["TenNVBH"].ToString()=="")?"Đã bị xóa":dr["TenNVBH"].ToString();
                HoaDon hoaDon = new HoaDon(id, tenphim, tongtien, ghichu,tenKhachHang,tenNVBH);
                list.Add(hoaDon);
            }
            return list;
        }

        public void UpdateHoaDon(int idHoaDon, double gia)
        {
            string query=@"Update HoaDon 
                            set TongTien=TongTien+@TongTien
                            where Id=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TongTien", gia);
            sqlParameters[1] = new SqlParameter("@Id", idHoaDon);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void Delete(int id)
        {
            string query = @"Delete From ChiTietHoaDon WHERE IdHoaDon=@Id";
            SqlParameter para= new SqlParameter("@Id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, para);
            query = @"DELETE FROM HoaDon WHERE Id=@Id";
            SqlParameter sqlParameters = new SqlParameter("@Id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public List<MonDuocDat>GetChiTietHoaDon(int idHoaDon)
        {
            List<MonDuocDat> list = new List<MonDuocDat>();
            string query = @"SELECT MonAn.TenMon,MonAn.GiaTien,ChiTietHoaDon.SoLuongMonAn
                            FROM ChiTietHoaDon
                            INNER JOIN MonAn ON MonAn.Id=ChiTietHoaDon.IdMonAn
							INNER JOIN HoaDon On HoaDon.Id=ChiTietHoaDon.IdHoaDon
                            WHERE IdHoaDon=@id";
            SqlParameter sqlParameters = new SqlParameter("@id", idHoaDon);
            DataTable reader = DatabaseHelper.Instance.GetRecords(query, sqlParameters);
            foreach (DataRow dr in reader.Rows)
            {
                int thutu=(list.Count==0)?1:list.Count+1;
                string tenMon = dr["TenMon"].ToString();
                int soLuong = Convert.ToInt32(dr["SoLuongMonAn"]);
                double gia = Convert.ToDouble(dr["GiaTien"])*soLuong;
                MonDuocDat mon = new MonDuocDat(thutu,tenMon, gia,soLuong);
                list.Add(mon);
            }
            return list;
        }

        public void SetHoaDon(KhachHang khachHang)
        {
            string query =@"Update HoaDon
                            set IdKhachHang=null
                            where IdKhachHang=@id";
            SqlParameter sqlParameters = new SqlParameter("@id", khachHang.Id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void SetHoaDon(NVBH nvbh)
        {
            string query = @"Update HoaDon
                            set IdNVBH=null
                            where IdNVBH=@id";
            SqlParameter sqlParameters = new SqlParameter("@id", nvbh.Id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
    }
}

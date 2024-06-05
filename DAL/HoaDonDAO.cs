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
            string query = @"SELECT HoaDon.Id, HoaDon.TongTien, HoaDon.GhiChu, 
            NguoiDungKhachHang.Fullname AS TenKhachHang, 
            NguoiDungNhanVien.Fullname AS TenNVBH
            FROM HoaDon
            INNER JOIN NguoiDung AS NguoiDungKhachHang ON HoaDon.IdKhachHang = NguoiDungKhachHang.Id
            INNER JOIN NguoiDung AS NguoiDungNhanVien ON HoaDon.IdNVBH = NguoiDungNhanVien.Id;";
            DataTable reader = DatabaseHelper.Instance.GetRecords(query);
            foreach (DataRow dr in reader.Rows)
            {
                int id = Convert.ToInt32(dr["Id"]);
                int tongtien = Convert.ToInt32(dr["TongTien"]);
                string ghichu = dr["GhiChu"].ToString();
                string tenKhachHang = dr["TenKhachHang"].ToString();
                string tenNVBH = dr["TenNVBH"].ToString();
                HoaDon hoaDon = new HoaDon(id, tongtien, ghichu,tenKhachHang,tenNVBH);
                list.Add(hoaDon);
            }
            return list;
        }
    }
}

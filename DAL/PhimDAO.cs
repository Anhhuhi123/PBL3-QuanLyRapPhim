using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;

namespace DAO
{
    public class PhimDAO 
    {
        LichChieuDAO lichChieuDAO;
        public PhimDAO(){
            lichChieuDAO = new LichChieuDAO();
        }
        public void Delete(int id)
        {
            string query = @"Delete FROM LichChieu where IdPhim = @id";
            DatabaseHelper.Instance.ExecuteNonQuery(query, new SqlParameter("@id", id));
            query = @"Delete FROM  Phim where Id=@id";
            SqlParameter sqlParameter = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameter);
        }

        public List<Phim> GetAll()
        {
            string query = "SELECT * FROM Phim";
            List<Phim> list = new List<Phim>();
            DataTable dt = DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow row in dt.Rows)
            {
                int id= Convert.ToInt32(row["Id"]);
                string tenphim = row["TenPhim"].ToString();
                string theloai = row["LoaiPhim"].ToString();
                int thoiluong = Convert.ToInt32(row["ThoiLuong"]);
                string mota = row["MoTa"].ToString();
                list.Add(new Phim(id, tenphim, theloai, thoiluong, mota));
            }
            return list;
        }
        public Phim GetById(int id)
        {
            string query = "SELECT * FROM Phim WHERE Id = @id";
            SqlParameter sqlParameter = new SqlParameter("@id", id);
            DataTable dt = DatabaseHelper.Instance.GetRecords(query, sqlParameter);
            if(dt.Rows.Count==0)
            {
                return null;
            }
            DataRow row = dt.Rows[0];
            string tenphim = row["TenPhim"].ToString();
            string theloai = row["LoaiPhim"].ToString();
            int thoiluong = Convert.ToInt32(row["ThoiLuong"]);
            string mota = row["MoTa"].ToString();
            return new Phim(id, tenphim, theloai, thoiluong, mota);
        }
        public void Insert(Phim obj)
        {
            string query = @"INSERT INTO Phim (Id,Tenphim, LoaiPhim, Thoiluong, Mota) 
                    VALUES (@id,@name, @loai, @thoiluong, @mota)";
            SqlParameter[] sqlParameter = new SqlParameter[5];
            sqlParameter[0] = new SqlParameter("@id", obj.Id);
            sqlParameter[1]=new SqlParameter("@name",obj.TenPhim);
            sqlParameter[2] = new SqlParameter("@loai", obj.TheLoai);
            sqlParameter[3] = new SqlParameter("@thoiluong", obj.ThoiLuong);
            sqlParameter[4] = new SqlParameter("@mota",obj.Mota);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameter);
        }

        public void Update(Phim obj)
        {
            string query = @"UPDATE Phim 
                            SET Tenphim = @name, LoaiPhim = @loai, Thoiluong = @thoiluong, Mota = @mota 
                            WHERE Id = @id";
            SqlParameter[] sqlParameters=new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@name", obj.TenPhim);
            sqlParameters[2] = new SqlParameter("@loai", obj.TheLoai);
            sqlParameters[3] = new SqlParameter("@thoiluong", obj.ThoiLuong);
            sqlParameters[4] = new SqlParameter("@mota", obj.Mota);
            DatabaseHelper.Instance.ExecuteNonQuery (query, sqlParameters);
        }
    }
}

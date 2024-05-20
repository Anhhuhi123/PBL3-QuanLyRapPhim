using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAO
{
    public class LichChieuDAO
    {
        public void Delete(int id)
        {
            string query = @"Delete from LichChieu_PhongChieu where IdLichChieu =@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            query = @"Delete from GheNgoi where IdLichChieu =@id";
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            query= @"DELETE FROM LichChieu WHERE Id = @id";
            sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public List<LichChieu> GetAll()
        {
            string query = @"SELECT lc.Id,p.TenPhim,nd.Fullname,lc.NgayChieu,lc.GioChieu,p.thoiluong 
                    FROM LichChieu lc 
                    INNER JOIN Phim p on lc.IdPhim=p.Id 
                    LEFT JOIN NguoiDung nd on nd.Id=lc.IdNVQL";
            DataTable reader = DatabaseHelper.Instance.GetRecords(query);
            List<LichChieu> list = new List<LichChieu>();
            foreach(DataRow row in reader.Rows)
            {
                int id = Convert.ToInt32(row["Id"].ToString());
                string tenphim = row["TenPhim"].ToString();
                string tennvql = row["Fullname"].ToString();
                DateTime ngaychieu = Convert.ToDateTime(row["NgayChieu"]);
                int giochieu = Convert.ToInt32(row["GioChieu"]);
                double time = Convert.ToDouble(row["thoiluong"])/60;
                int gioketthuc = giochieu +(int) Math.Ceiling(time);
                list.Add(new LichChieu(id,tenphim, tennvql, ngaychieu, giochieu, gioketthuc));
            }
            return list;
        }

        public LichChieu GetById(int id)
        {
            string query = @"SELECT lc.Id,p.TenPhim,nv.Fullname,lc.NgayChieu,lc.GioChieu,p.thoiluong 
                    FROM LichChieu lc 
                    LEFT JOIN Phim p on lc.IdPhim=p.Id 
                    LEFT JOIN NhanVienQuanLy nv on nv.Id=lc.IdNVQL
                    WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DataTable reader = DatabaseHelper.Instance.GetRecords(query, sqlParameters);
            DataRow row = reader.Rows[0];
            string tenphim = row["TenPhim"].ToString();
            string tennvql = row["Fullname"].ToString();
            DateTime ngaychieu = Convert.ToDateTime(row["NgayChieu"]);
            int giochieu = Convert.ToInt32(row["GioChieu"]);
            double time = Convert.ToDouble(row["thoiluong"]) / 60;
            int gioketthuc = giochieu + (int)Math.Ceiling(time);
            return new LichChieu(id, tenphim, tennvql, ngaychieu, giochieu, gioketthuc);
        }

        public void Insert(LichChieu obj,int Idphim, int idnvql)
        {
            string query = @"INSERT INTO LichChieu (Id, IdPhim, NgayChieu, GioChieu, IdNVQL) 
                    VALUES (@id, @idphim, @ngaychieu, @giochieu, @nvql)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@idphim", Idphim);
            sqlParameters[2] = new SqlParameter("@ngaychieu", obj.NgayChieu);
            sqlParameters[3] = new SqlParameter("@giochieu", obj.GioChieu);
            sqlParameters[4] = new SqlParameter("@nvql", idnvql);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void Update(LichChieu obj)
        {
            string query = @"UPDATE LichChieu 
                            SET NgayChieu = @ngaychieu, GioChieu = @giochieu 
                            WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@ngaychieu", obj.NgayChieu);
            sqlParameters[2] = new SqlParameter("@giochieu", obj.GioChieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
    }
}

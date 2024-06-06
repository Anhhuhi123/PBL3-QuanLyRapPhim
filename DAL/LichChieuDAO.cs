using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class LichChieuDAO
    {
        PhongChieuDAO phongChieuDAO;
        GheNgoiDAO gheNgoiDAO;
        public LichChieuDAO()
        {
            phongChieuDAO = new PhongChieuDAO();
            gheNgoiDAO = new GheNgoiDAO();
        }
        public void Delete(int id)
        {
            string query = @"Delete from LichChieu_PhongChieu where IdLichChieu =@id";
            SqlParameter parapclc = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, parapclc);
            query = @"Delete from GheNgoi where IdLichChieu =@id";
            SqlParameter paraghengoi = new SqlParameter("@id",id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, paraghengoi);
            query= @"DELETE FROM LichChieu WHERE Id = @id";
            SqlParameter paralichchieu = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, paralichchieu);
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
            string query = @"SELECT lc.Id,p.TenPhim,nd.Fullname,lc.NgayChieu,lc.GioChieu,p.thoiluong 
                    FROM LichChieu lc 
                    LEFT JOIN Phim p on lc.IdPhim=p.Id 
                    LEFT JOIN NguoiDung nd on nd.Id=lc.IdNVQL
                    WHERE lc.Id = @id";
            SqlParameter sqlParameters = new SqlParameter("@id", id);
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

        public void Insert(LichChieu obj,int Idphim, string idnvql)
        {
            try
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
            catch(Exception e)
            {
                throw new Exception("SQL Error " + e.Message);
            }
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

        public List<LichChieu> GetLichDangChieu(int idPhongChieu)
        {
            List<LichChieu> list =new List<LichChieu>();
            string query = @"SELECT lc.Id, p.TenPhim, lc.NgayChieu, lc.GioChieu, nd.Fullname,p.ThoiLuong
                FROM LichChieu lc
                Inner JOIN Phim p ON p.Id=lc.IdPhim
                INNER JOIN LichChieu_PhongChieu lcpp ON lc.Id = lcpp.IdLichChieu
                INNER JOIN PhongChieu pc ON lcpp.IdPhongChieu = pc.Id
                INNER JOIN NguoiDung nd ON lc.IdNVQL = nd.Id
                WHERE pc.Id = @id";
            SqlParameter sqlParameters = new SqlParameter("@id",idPhongChieu);
            DataTable reader = DatabaseHelper.Instance.GetRecords(query, sqlParameters);
            foreach(DataRow dr in reader.Rows)
            {
                int IdLichChieu = Convert.ToInt32(dr["Id"].ToString());
                string tenphim = dr["TenPhim"].ToString();
                DateTime ngaychieu = Convert.ToDateTime(dr["NgayChieu"]);
                int giochieu = Convert.ToInt32(dr["GioChieu"]);
                double time = Convert.ToDouble(dr["ThoiLuong"]) / 60;
                int gioketthuc = giochieu + (int)Math.Ceiling(time);
                string tennvql = dr["Fullname"].ToString();
                list.Add(new LichChieu(IdLichChieu, tenphim, tennvql, ngaychieu, giochieu, gioketthuc));
            }
            return list;
        }
        public void ThemPhimDangChieu(int idLichChieu, int idPhongChieu)
        {
            string query = @"INSERT INTO LichChieu_PhongChieu (IdLichChieu, IdPhongChieu) 
                            VALUES (@idlichchieu, @idphongchieu)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idlichchieu", idLichChieu);
            sqlParameters[1] = new SqlParameter("@idphongchieu", idPhongChieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            PhongChieu temp = phongChieuDAO.GetById(idPhongChieu);
            for(int i=0;i<temp.Succhua;i++)
            {
                gheNgoiDAO.Insert(new GheNgoi(i+1,true),idLichChieu,idPhongChieu);
            }
        }
        public void XoaPhimDangChieu(int idLichChieu, int idPhongChieu)
        {
            string query = @"DELETE FROM LichChieu_PhongChieu 
                            WHERE IdLichChieu = @idlichchieu AND IdPhongChieu = @idphongchieu";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idlichchieu", idLichChieu);
            sqlParameters[1] = new SqlParameter("@idphongchieu", idPhongChieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            gheNgoiDAO.Delete(idPhongChieu,idLichChieu);
        }
    }
}

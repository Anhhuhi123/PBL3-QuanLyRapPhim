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
    public class PhongChieuDAO 
    {
        private GheNgoiDAO gheNgoiDAO;
        public PhongChieuDAO()
        {
            gheNgoiDAO = new GheNgoiDAO();
        }
        public void Delete(int id)
        {
            string query = @"DELETE FROM LichChieu_PhongChieu WHERE IdPhongChieu = @id";
            SqlParameter sqlparameterlk = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlparameterlk);
            query =@"DELETE FROM GheNgoi WHERE IdPhong = @id";
            SqlParameter sqlparameterGhe =new SqlParameter("@id",id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlparameterGhe);
            query = @"DELETE FROM PhongChieu WHERE Id = @id";
            SqlParameter sqlParameters = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public List<PhongChieu> GetAll()
        {
            string query =@"SELECT * FROM PhongChieu";
            List<PhongChieu> list = new List<PhongChieu>();
            DataTable dt = DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["Id"]);
                string name = dr["Name"].ToString();
                int succhua = Convert.ToInt32(dr["Succhua"]);
                string mota = dr["MoTa"].ToString();
                list.Add(new PhongChieu(id, name, succhua, mota));
            }
            return list;
        }
        public void Insert(PhongChieu obj)
        {
            string query =@"INSERT INTO PhongChieu(Id,Name,SucChua,MoTa) 
                            VALUES(@id,@name,@succhua,@mota)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@name", obj.Name);
            sqlParameters[2] = new SqlParameter("@succhua", obj.Succhua);
            sqlParameters[3] = new SqlParameter("@mota", obj.MoTa);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(PhongChieu obj)
        {
            string query=@"UPDATE PhongChieu 
                        SET Name = @name, SucChua = @succhua, MoTa = @mota 
                        WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@name", obj.Name);
            sqlParameters[2] = new SqlParameter("@succhua", obj.Succhua);
            sqlParameters[3] = new SqlParameter("@mota", obj.MoTa);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public PhongChieu GetById(int id)
        {
            string query = @"SELECT * FROM PhongChieu WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DataTable dt = DatabaseHelper.Instance.GetRecords(query, sqlParameters);
            DataRow dr = dt.Rows[0];
            int idphong = Convert.ToInt32(dr["Id"]);
            string name = dr["Name"].ToString();
            int succhua = Convert.ToInt32(dr["Succhua"]);
            string mota = dr["MoTa"].ToString();
            return new PhongChieu(idphong, name, succhua, mota);
        }
        public List<PhongChieu> GetAllPhongDangChieuPhim(int id)
        {
            string query = @"select  PhongChieu.Id,PhongChieu.Name,PhongChieu.Succhua,PhongChieu.Mota
                    from PhongChieu 
                    INNER JOIN LichChieu_PhongChieu ON LichChieu_PhongChieu.IdPhongChieu=PhongChieu.Id
                    INNER JOIN LichChieu ON LichChieu_PhongChieu.IdLichChieu=LichChieu.Id
                    Where LichChieu.Id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", 1);
            List<PhongChieu> list = new List<PhongChieu>();
            DataTable dt = DatabaseHelper.Instance.GetRecords(query, sqlParameters);
            foreach (DataRow dr in dt.Rows)
            {
                int idphong = Convert.ToInt32(dr["Id"]);
                string name = dr["Name"].ToString();
                int succhua = Convert.ToInt32(dr["Succhua"]);
                string mota = dr["MoTa"].ToString();
                list.Add(new PhongChieu(idphong, name, succhua, mota));
            }
            return list;
        }
        public void InsertPhongChieuPhim(int idPhong, int idLichChieu)
        {
            string query = @"INSERT INTO LichChieu_PhongChieu(IdPhongChieu,IdLichChieu) 
                            VALUES(@idPhong,@idLichChieu)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idPhong", idPhong);
            sqlParameters[1] = new SqlParameter("@idLichChieu", idLichChieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            PhongChieu temp =GetById(idPhong);
            for(int i=0;i<temp.Succhua;i++)
            {
                gheNgoiDAO.Insert(new GheNgoi(i + 1, true), idLichChieu, idPhong);
            }
        }
        public void DeletePhongChieu(int idPhong,int idLichChieu)
        {
            string query = @"DELETE FROM LichChieu_PhongChieu WHERE IdPhongChieu = @idPhong 
                            AND IdLichChieu = @idLichChieu";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idPhong", idPhong);
            sqlParameters[1] = new SqlParameter("@idLichChieu", idLichChieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            PhongChieu temp = GetById(idPhong);
            for(int i=0;i<temp.Succhua;i++)
            {
                gheNgoiDAO.Delete(idPhong, idLichChieu);
            }
        }
    }
}

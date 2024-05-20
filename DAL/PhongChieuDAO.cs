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
        public void Delete(int id)
        {
            string query =@"DELETE FROM LichChieu_PhongChieu WHERE IdPhongChieu = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            query =@"DELETE FROM GheNgoi WHERE IdPhongChieu = @id";
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            query = @"DELETE FROM PhongChieu WHERE Id = @id";
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
    }
}

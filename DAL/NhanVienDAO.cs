using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO 
    {
        public void Delete(string id)
        {
            string query = @"Delete from NhanVien where id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);   
        }
        public void Insert(NhanVien obj)
        {
            string query = @"INSERT INTO NhanVien (Id,Active)
                            VALUES(@id,@active)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@active", obj.Active);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void Update(NhanVien obj)
        {
            string query = @"UPDATE NhanVien 
                            SET active = @active
                            WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@active", obj.Active);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public NhanVien GetById(string id)
        {
            string query =@"SELECT nv.Id,nd.Fullname,nd.SoDt,nd.Email,nd.Vaitro,nv.Active 
                            FROM NhanVien nv
                            INNER JOIN  NguoiDung nd on nv.Id=nd.Id
                            WHERE nv.Id = @id";
            SqlParameter sqlParameter = new SqlParameter("@id", id);
            DataTable dt = DatabaseHelper.Instance.GetRecords(query, sqlParameter);
            if(dt.Rows.Count==0)
            {
                return null;
            }
            DataRow dr = dt.Rows[0];
            string name = dr["Fullname"].ToString();
            string Sodt = dr["SoDt"].ToString();
            string email = dr["Email"].ToString();
            string vaitro = dr["Vaitro"].ToString();
            bool active = Convert.ToBoolean(dr["Active"]);
            return new NhanVien(id, name, Sodt, email, vaitro, active);
        }
        public List<NhanVien> GetAll()
        {
            string query = @"SELECT nv.Id,nd.Fullname,nd.SoDt,nd.Email,nd.Vaitro,nv.Active 
                            FROM NhanVien nv
	                        INNER JOIN  NguoiDung nd on nv.Id=nd.Id";
            List<NhanVien> list = new List<NhanVien>();
            DataTable dt =DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow dr in dt.Rows)
            {
                string id = dr["Id"].ToString();
                string name = dr["Fullname"].ToString();
                string Sodt = dr["SoDt"].ToString();
                string email = dr["Email"].ToString();
                string vaitro = dr["Vaitro"].ToString();
                bool active = Convert.ToBoolean(dr["Active"]);
                list.Add(new NhanVien(id, name, Sodt, email, vaitro, active));
            }
            return list;
        }

    }
}

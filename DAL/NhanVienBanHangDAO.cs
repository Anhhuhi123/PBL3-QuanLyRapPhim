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
    public class NhanVienBanHangDAO 
    {
        public void Delete(string id)
        {
            string query = @"Delete from NhanVienBanHang where id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void Insert(NVBH obj)
        {
            string query = @"INSERT INTO NhanVienBanHang (Id,KPI) 
                    VALUES (@id, @kpi)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@kpi", obj.KPI);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(NVBH obj)
        {
            string query = @"UPDATE NhanVienBanHang 
                            SET KPI = @kpi WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@kpi", obj.KPI);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public NVBH GetById(string id)
        {
            string query = @"SELECT nvbh.Id,nd.Fullname,nd.SoDt,nd.Email,nd.Vaitro,nv.Active,nvbh.KPI 
							FROM NhanVienBanHang nvbh
                            INNER JOIN NhanVien nv ON nvbh.Id=nv.Id
                            INNER JOIN NguoiDung nd ON nd.Id = nvbh.Id
                            WHERE nvbh.Id = @id";
            SqlParameter sqlParameter= new SqlParameter("@id", id);
            DataTable dt = DatabaseHelper.Instance.GetRecords(query, sqlParameter);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string name = row["Fullname"].ToString();
                string Sodt = row["SoDt"].ToString();
                string email = row["Email"].ToString();
                string vaitro = row["Vaitro"].ToString();
                bool active = Convert.ToBoolean(row["Active"]);
                int kpi = Convert.ToInt32(row["KPI"]);
                return new NVBH(id, name, Sodt, email, vaitro, active, kpi);
            }
            return null;
        }
        public List<NVBH> GetAll()
        {
            List<NVBH> list = new List<NVBH>();
            string query = @"SELECT nvbh.Id,nd.Fullname,nd.SoDt,nd.Email,nd.Vaitro,nv.Active,nvbh.KPI 
							FROM NhanVienBanHang nvbh
                            INNER JOIN NhanVien nv ON nvbh.Id=nv.Id
                            INNER JOIN NguoiDung nd ON nd.Id = nvbh.Id";
            DataTable dt =DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow row in dt.Rows)
            {
                string Id = row["Id"].ToString();
                string name = row["Fullname"].ToString();
                string Sodt = row["SoDt"].ToString();
                string email = row["Email"].ToString();
                string vaitro = row["Vaitro"].ToString();
                bool active = Convert.ToBoolean(row["Active"]);
                int kpi = Convert.ToInt32(row["KPI"]);
                list.Add(new NVBH(Id, name, Sodt, email, vaitro, active, kpi));
            }
            return list;
        }
    }
}

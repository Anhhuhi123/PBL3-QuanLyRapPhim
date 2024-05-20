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
    public class NhanVienQuanLyDAO 
    {
        public void Delete(string id)
        {
            string query =@"DELETE FROM NhanVienQuanLy WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Insert(NVQL obj)
        {
            string query = @"INSERT INTO NhanVienQuanLy (Id)
                            VALUES (@id)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(NVQL obj)
        {
        }

        public List<NVQL> GetAll()
        {
            List<NVQL> list = new List<NVQL>();
            string query = @"SELECT nvql.Id,nd.Fullname,nd.SoDt,nd.Email,nd.Vaitro,nv.Active 
                            FROM NhanVienQuanLy nvql
                            INNER JOIN NhanVien nv ON nvql.Id = nv.Id
                            INNER JOIN NguoiDung nd ON nd.Id = nv.Id";
            DataTable dt = DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow dr in dt.Rows)
            {
                string id = dr["Id"].ToString();
                string name = dr["Fullname"].ToString();
                string Sodt = dr["SoDt"].ToString();
                string email = dr["Email"].ToString();
                string vaitro = dr["Vaitro"].ToString();
                bool active = Convert.ToBoolean(dr["Active"]);
                list.Add(new NVQL(id, name, Sodt, email, vaitro, active));
            }
            return list;
        }
    }
}

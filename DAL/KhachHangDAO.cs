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
    public class KhachHangDAO 
    {
        public void Delete(int id)
        {
            string query = @"DELETE FROM KhachHang WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public List<KhachHang> GetAll()
        {
            string queyr =@"SELECT kh.Id,nd.Fullname,nd.SoDt,nd.Email,nd.Vaitro
                            FROM KhachHang kh
                            INNER JOIN NguoiDung nd ON nd.Id = kh.Id";
            List<KhachHang> list = new List<KhachHang>();
            DataTable dt= DatabaseHelper.Instance.GetRecords(queyr);
            foreach(DataRow dr in dt.Rows)
            {
                string id = dr["Id"].ToString();
                string name = dr["Fullname"].ToString();
                string Sodt = dr["SoDt"].ToString();
                string email = dr["Email"].ToString();
                string vaitro = dr["Vaitro"].ToString();
                list.Add(new KhachHang(id, name, Sodt, email, vaitro));
            }
            return list;
        }

        public void Insert(KhachHang obj)
        {
            string query = @"INSERT INTO KhachHang (Id)
                            VALUES (@id)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(KhachHang obj)
        {
        }
    }
}

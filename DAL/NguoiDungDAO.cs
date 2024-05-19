using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NguoiDungDAO : InterfaceCRUD<NguoiDung>
    {
        public virtual void Delete(string id)
        {
            string query = @"Delete from NguoiDung where id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Delete(int id)
        {
            throw new Exception("Không có Id theo loại dữ liệu này!");
        }

        public List<NguoiDung> GetAll()
        {
            List<NguoiDung> list = new List<NguoiDung> ();
            string query = "SELECT * FROM NguoiDung";
            DataTable dt =DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow dr in dt.Rows)
            {
                string id = dr["ID"].ToString();
                string name = dr["Fullname"].ToString();
                string Sodt = dr["SoDt"].ToString();
                string email = dr["Email"].ToString();
                string vaitro = dr["Vaitro"].ToString();
                list.Add(new NguoiDung(id, name, Sodt, email, vaitro));
            }
            return list;
        }
        public void Insert(NguoiDung obj)
        {
            string query = @"Insert into NguoiDung(Id,Fullname,SoDt,Email,Vaitro)
                            VALUES (@id,@name,@sodt,@email,@vaitro)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@name", obj.FullName);
            sqlParameters[2] = new SqlParameter("@sodt", obj.SoDt);
            sqlParameters[3] = new SqlParameter("@email", obj.Email);
            sqlParameters[4] = new SqlParameter("@vaitro", obj.Vaitro);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(NguoiDung obj)
        {
            string query =@"Update NguoiDung 
                        SET Fullname = @name, SoDt = @sodt, Email = @email, Vaitro = @vaitro
                        where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@name", obj.FullName);
            sqlParameters[2] = new SqlParameter("@sodt", obj.SoDt);
            sqlParameters[3] = new SqlParameter("@email", obj.Email);
            sqlParameters[4] = new SqlParameter("@vaitro", obj.Vaitro);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
    }
}

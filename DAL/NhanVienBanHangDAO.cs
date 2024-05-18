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
    public class NhanVienBanHangDAO : NhanVienDAO, InterfaceCRUD<NVBH>
    {
        public override void Delete(string id)
        {
            string query = @"Delete from NhanVienBanHang where id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            base.Delete(id);
        }
        public void Insert(NVBH obj)
        {
            base.Insert(obj);
            string query = @"INSERT INTO NhanVienBanHang (Id,KPI) 
                    VALUES (@id, @kpi)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@kpi", obj.KPI);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(NVBH obj)
        {
            base.Update(obj);
            string query = @"UPDATE NhanVienBanHang 
                            SET KPI = @kpi WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@kpi", obj.KPI);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        List<NVBH> InterfaceCRUD<NVBH>.GetAll()
        {
            string query =@"select * from NhanVienBanHang nvbh
                            inner join NhanVien nv on nvbh.Id=nv.Id
                            inner join NguoiDung nd on nd.Id = nvbh.Id";
            List<NVBH> list = new List<NVBH>();
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

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
    public class NhanVienDAO : NguoiDungDAO, InterfaceCRUD<NhanVien>
    {
        public void Delete(string id,bool isNVQL)
        {
            string query;
            SqlParameter[] sqlParameters;
            if (isNVQL == true) query = @"Delete from NhanVienQuanLy where id=@id";
            else query=@"Delete from NhanVienBanHang where id=@id";
            sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);

            query = @"Delete from NhanVien where id=@id";
            sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
            base.Delete(id);    
        }
        public void Insert(NhanVien obj,bool isNVQL)
        {
            base.Insert(obj);
            string query = @"INSERT INTO NhanVien (Id,TenTK,Active)
                            VALUES(@id,@tentk,@active)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@active", obj.Active);
            if(isNVQL==true)
            {
                query = @"INSERT INTO NhanVienQuanLy (Id)
                            VALUES(@id)";
            }
            else
            {
                query = @"INSERT INTO NhanVienBanHang (Id,KPI)
                            VALUES(@id,0)";
            }
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Insert(NhanVien obj)
        {
            throw new NotImplementedException("Không thể xác định được là nhân viên quản lý hay nhân viên bán hàng");
        }

        public void Update(NhanVien obj,bool NVQL)
        {
            base.Update(obj);
            string query = @"UPDATE NhanVien 
                            SET active = @active
                            WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@active", obj.Active);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(NhanVien obj)
        {
            throw new Exception("Không thể cập nhật thông tin nhân viên này!");
        }

        List<NhanVien> InterfaceCRUD<NhanVien>.GetAll()
        {
            string query = @"select * from NhanVien nv
                            inner join  KhachHang kh on nv.Id=kh.Id";
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

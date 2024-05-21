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
    public class TaiKhoanDAO
    {
        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = @"Select * from TaiKhoan";
            DataTable dt =DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow row in dt.Rows)
            {
                string tentk = row["TenTK"].ToString();
                string matkhau = row["MatKhau"].ToString();
                list.Add(new TaiKhoan(tentk, matkhau));
            }
            return list;
        }
        public void Insert(TaiKhoan taikhoan)
        {
            string query =@"Insert into TaiKhoan (TenTK,MatKhau)
                            VALUES (@TenTK,@MatKhau)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TenTK", taikhoan.TenTK);
            sqlParameters[1] = new SqlParameter("@MatKhau", taikhoan.MatKhau);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void Del(string Id)
        {
            string query =@"Delete from TaiKhoan where TenTK = @TenTK";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TenTK", Id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void Update(TaiKhoan taikhoan)
        {
            string query =@"Update TaiKhoan
                            Set MatKhau = @MatKhau
                            where TenTK = @TenTK";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TenTK", taikhoan.TenTK);
            sqlParameters[1] = new SqlParameter("@MatKhau", taikhoan.MatKhau);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
    }
}

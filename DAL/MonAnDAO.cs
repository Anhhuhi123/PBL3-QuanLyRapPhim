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
    public class MonAnDAO
    {
        public List<MonAn> GetAll()
        {
            List<MonAn> list = new List<MonAn>();
            string query = "SELECT * FROM MonAn";
            System.Data.DataTable data = DatabaseHelper.Instance.GetRecords(query);
            foreach (System.Data.DataRow dr in data.Rows)
            {
                int id =Convert.ToInt32(dr["Id"].ToString());
                string tenMonAn = dr["TenMon"].ToString();
                double giaTien = Convert.ToInt32(dr["GiaTien"].ToString());
                MonAn temp = new MonAn(id, tenMonAn, giaTien);
                list.Add(temp);
            }
            return list;
        }
        public MonAn GetById(int id)
        {
            string query =@"SELECT * FROM MonAn WHERE Id = @id";
            SqlParameter para = new SqlParameter("@id", id);
            System.Data.DataTable data = DatabaseHelper.Instance.GetRecords(query, para);
            DataRow dr = data.Rows[0];
            int idMonAn = Convert.ToInt32(dr["Id"].ToString());
            string tenMonAn = dr["TenMon"].ToString();
            double giaTien = Convert.ToInt32(dr["GiaTien"].ToString());
            MonAn temp = new MonAn(idMonAn, tenMonAn, giaTien);
            return temp;
        }

        public void ThemMonAnVaoHoaDon(int idmon, int idhoadon, int soluong)
        {
            string query=@"Insert into ChiTietHoaDon(IdHoaDon,IdMonAn,SoLuongMonAn)
                            VALUES (@idhoadon,@idmon,@soluong)";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@idhoadon", idhoadon);
            para[1] = new SqlParameter("@idmon", idmon);
            para[2] = new SqlParameter("@soluong", soluong);
            DatabaseHelper.Instance.ExecuteNonQuery(query, para);
        }
    }
}

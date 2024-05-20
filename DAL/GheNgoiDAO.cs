﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class GheNgoiDAO 
    {
        public void Delete(int idphong,int idlichchieu)
        {
            string query = @"DELETE FROM GheNgoi WHERE IdPhong=@idphong and Idlichchieu=@idlich";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idphong", idphong);
            sqlParameters[1] = new SqlParameter("@idlich", idlichchieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public List<GheNgoi> GetAll()
        {
            List<GheNgoi> list = new List<GheNgoi>();
            string query=@"SELECT * FROM GheNgoi";
            DataTable dt = DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                int idphong = Convert.ToInt32(row["IdPhong"]);
                int idlich = Convert.ToInt32(row["IdLichChieu"]);
                bool trangthai= Convert.ToBoolean(row["TrangThai"]);
                GheNgoi gheNgoi = new GheNgoi(id, idphong,idlich, trangthai);
                list.Add(gheNgoi);
            }
            return list;
        }
        public void Insert(GheNgoi obj)
        {
            string query = @"INSERT INTO GheNgoi (Id, TrangThai, IdPhong,IdLichChieu) 
                            VALUES (@id,@trangthai,@idphong,@idlich)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@trangthai", obj.TrangThai);
            sqlParameters[2] = new SqlParameter("@idphong", obj.IdPhong);
            sqlParameters[3] = new SqlParameter("@idlich", obj.IdLichChieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(GheNgoi obj)
        {
            string query = @"UPDATE GheNgoi 
                            SET TrangThai=@trangthai ,IdPhong=@idphong,IdLichChieu=@idlich 
                            WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            sqlParameters[1] = new SqlParameter("@trangthai", obj.TrangThai);
            sqlParameters[2] = new SqlParameter("@idphong", obj.IdPhong);
            sqlParameters[3] = new SqlParameter("@idlich", obj.IdLichChieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
    }
}

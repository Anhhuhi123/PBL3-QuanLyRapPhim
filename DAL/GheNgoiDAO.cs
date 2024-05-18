using System;
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
    public class GheNgoiDAO : InterfaceCRUD<GheNgoi>
    {
        public void Delete(int id,int idphong,int idlichchieu)
        {
            string query = @"DELETE FROM GheNgoi WHERE Id = @id and IdPhong=@idphong and Idlichchieu=@idlich";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", id);
            sqlParameters[1] = new SqlParameter("@idphong", idphong);
            sqlParameters[2] = new SqlParameter("@idlich", idlichchieu);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Delete(int id)
        {
            throw new Exception("Không thể xóa ghế nếu không biết phòng chiếu và lịch chiếu");
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

        public GheNgoi GetById(int id,int idphong,int idlich)
        {
            string query = @"SELECT * FROM GheNgoi WHERE Id = @id
                             and IdPhong =@idphong and IdLichChieu=@idlich";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", id);
            sqlParameters[1] = new SqlParameter("@idphong", idphong);
            sqlParameters[2] = new SqlParameter("@idlich", idlich);
            DataTable dt = DatabaseHelper.Instance.GetRecords(query, sqlParameters);
            DataRow row = dt.Rows[0];
            bool trangthai = Convert.ToBoolean(row["TrangThai"]);
            return new GheNgoi(id, idphong,idlich, trangthai);
        }

        public GheNgoi GetById(int id)
        {
            throw new Exception("Không thể lấy ghế nếu không biết phòng chiếu và lịch chiếu");
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

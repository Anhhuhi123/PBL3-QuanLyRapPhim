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
    public class VeDuocDatDAO
    {
        public void Insert(VeDuocDat veDuocDat,int idLich)
        {
            string query=@"INSERT INTO 
                        VeDuocDat(Id,Tongtien,SoVe,IdLichChieu) 
                        VALUES(@Id,@tongtien,@sove,@idlichchieu)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Id", veDuocDat.Id);
            sqlParameters[1] = new SqlParameter("@tongtien", veDuocDat.TongTien);
            sqlParameters[2] = new SqlParameter("@sove", veDuocDat.SoVe);
            sqlParameters[3] = new SqlParameter("@idlichchieu", idLich);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }
        public void Delete(int id)
        {
            string query = @"DELETE FROM VeDuocDat WHERE Id=@Id";
            SqlParameter sqlParameter = new SqlParameter("@Id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameter);
        }
        public List<VeDuocDat> GetAll()
        {
            List<VeDuocDat> list =new List<VeDuocDat>();
            string query = @"SELECT Id,Tongtien,SoVe FROM VeDuocDat;";
            DataTable reader = DatabaseHelper.Instance.GetRecords(query);
            foreach(DataRow dr in reader.Rows)
            {
                int id=Convert.ToInt32(dr["Id"]);
                int tongtien = Convert.ToInt32(dr["Tongtien"]);
                int sove = Convert.ToInt32(dr["SoVe"]);
                VeDuocDat veDuocDat = new VeDuocDat(id, tongtien, sove);
                list.Add(veDuocDat);
            }
            return list;
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongChieuDAO : InterfaceCRUD<PhongChieu>
    {
        public void Delete(int id)
        {

            string query = @"DELETE FROM PhongChieu WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public List<PhongChieu> GetAll()
        {
            throw new NotImplementedException();
        }

        public PhongChieu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(PhongChieu obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PhongChieu obj)
        {
            throw new NotImplementedException();
        }
    }
}

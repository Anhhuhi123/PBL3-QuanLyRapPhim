using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienQuanLyDAO : NhanVienDAO, InterfaceCRUD<NVQL>
    {
        public void Insert(NVQL obj)
        {
            base.Insert(obj);
            string query = @"INSERT INTO NhanVienQuanLy (Id)
                            VALUES (@id)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", obj.Id);
            DatabaseHelper.Instance.ExecuteNonQuery(query, sqlParameters);
        }

        public void Update(NVQL obj)
        {
            throw new NotImplementedException();
        }

        List<NVQL> InterfaceCRUD<NVQL>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

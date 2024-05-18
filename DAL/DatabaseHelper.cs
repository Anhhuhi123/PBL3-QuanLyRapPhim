using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DatabaseHelper
    {
        private readonly string connectionString = @"Data Source=DESKTOP-1VJ4VUO\SQLEXPRESS;Initial Catalog=QuanLyRapChieuPhim;Integrated Security=True";
        private SqlConnection connection;
        private static DatabaseHelper instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatabaseHelper();
                return instance;
            }
        }
        private DatabaseHelper() {
            connection = new SqlConnection(connectionString);
        }
        public void ExecuteNonQuery(string query,params SqlParameter[] sqlParameters)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddRange(sqlParameters);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine("SQL Error "+e.Message);
                }
                connection.Close();
            }
            
            connection.Close();
        }
        public DataTable GetRecords(string query,params SqlParameter[] sqlParameters)
        {
            DataTable dt=new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            connection.Open();
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}

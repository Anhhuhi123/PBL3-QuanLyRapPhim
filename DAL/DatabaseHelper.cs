﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data;

namespace DAO
{
    public class DatabaseHelper
    {
        private readonly string connectionString = @"Data Source=MSI;Initial Catalog=rapphim;Integrated Security=True";
        //private readonly string connectionString = "Data Source=192.168.1.11;Initial Catalog=\"Rap phim full\";User ID=sa;Password=VeryStr0ngP@ssw0rd;";
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
                    string error = e.Message;
                    error += "\n" + query;
                    foreach(SqlParameter parameter in sqlParameters)
                    {
                        error = error.Replace(parameter.ParameterName, parameter.Value.ToString());
                    }
                    throw new Exception("ExecuteNonQuery Error "+ error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public DataTable GetRecords(string query,params SqlParameter[] sqlParameter)
        {
            DataTable dt=new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddRange(sqlParameter);
            try
            {
                connection.Open();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("Get Data Error "+ e.Message+" "+query);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

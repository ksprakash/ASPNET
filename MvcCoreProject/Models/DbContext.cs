using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.DependencyInjection;

namespace MvcCoreProject.Models
{
    public class DbContext
    {
        public string ConnectionString { get; set; }

        public DbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employeedb", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Employee()
                        {
                            employeeid = reader.GetInt32("employeeid"),
                            employeename = reader.GetString("employeename"),
                            role = reader.GetString("role"),
                            
                        });
                    }
                }
            }

            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;


namespace MvcCoreProject.Models
{
    public class Employee
    {
        private DbContext context;

        public int employeeid { get; set; }

        public string employeename { get; set; }

        public string role { get; set; }

        
    }
}

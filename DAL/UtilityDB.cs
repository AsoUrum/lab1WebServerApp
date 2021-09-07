using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;//add the reference system configuration

namespace Lab1_ASP.NetConnectedMode.DAL
{
    public class UtilityDB
    {

        public static SqlConnection ConnectDB()
        {
            SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString = @"server=DESKTOP-VQG4QI1;database=EmployeeDB;user=sa;password=Network2020";
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectEmployeesData"].ConnectionString;
            cnn.Open();
            return cnn;

        }

    }
}
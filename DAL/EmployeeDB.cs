using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab1_ASP.NetConnectedMode.BILL;
using Lab1_ASP.NetConnectedMode.DAL;
using System.Data.SqlClient;



namespace Lab1_ASP.NetConnectedMode.DAL
{
    public static class EmployeeDB
    {

        public static void SaveRecord (Employee emp)
        {
            SqlConnection cnnDB = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            //cmdInsert.CommandText = "INSERT INTO Employees " +
            //    "VALUES(" + emp.EmployeeId + ",'" +
            //                 emp.FirstName + "'," +
            //                 emp.LastName + "'," +
            //                 emp.JobTitle + "')";

            cmdInsert.CommandText = "INSERT INTO Employees (EmployeeId,FirstName,LastName,JobTitle)" +
                                        "VALUES(@EmployeeId,@FirstName,@LastName,@JobTitle)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdInsert.Parameters.AddWithValue("@JobTitle", emp.JobTitle);

            cmdInsert.Connection = cnnDB;
            cmdInsert.ExecuteNonQuery();
            cnnDB.Close();
            cnnDB.Dispose();



        }


        public static void updateRecord(int empId, Employee emp)
        {

            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Employes SET " +
                "firstName = '" + emp.FirstName + "'," +
                "lastName = '" + emp.LastName + "'," +
                "jobTitle =  '" + emp.JobTitle + "'" +
                "WHERE EmployeeId =  " + empId;

            cmdUpdate.Connection = con;
            cmdUpdate.ExecuteNonQuery();
            con.Close();
        }


        public static void DeleteRecord(int empId)
        {
            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = " + empId;
            cmdDelete.Connection = con;
            cmdDelete.ExecuteNonQuery();
            con.Close();

        }

        public static List<Employee> listAllRecord()
        {
            List<Employee> empList = new List<Employee>();

            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdListRecord = new SqlCommand();
            cmdListRecord.CommandText = "SELECT FROM Employees";
            cmdListRecord.Connection = con;
            SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

            Employee emp;

            while(sqlreadRecord.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlreadRecord["EmployeeId"]);
                emp.FirstName = sqlreadRecord["firstName"].ToString();
                emp.LastName = sqlreadRecord["lastName"].ToString();
                emp.JobTitle = sqlreadRecord["jobTitle"].ToString();
                empList.Add(emp);

            }






            return empList;

        }
  
    
    
    
    }



}
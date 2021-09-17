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


        public static void updateRecord(Employee emp)
        {

            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            //cmdUpdate.CommandText = "UPDATE Employees SET " +
            //    "firstName = '" + emp.FirstName + "'," +
            //    "lastName = '" + emp.LastName + "'," +
            //    "jobTitle =  '" + emp.JobTitle + "'" +
            //    "WHERE EmployeeId =  " + emp.EmployeeId;

            cmdUpdate.CommandText = ("UPDATE Employees " +
                    "SET firstName = @FirstName, " +
                    "lastName = @LastName, " +
                    "jobTitle = @JobTitle " +
                    "WHERE EmployeeId = @EmployeeId");
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpdate.Parameters.AddWithValue("@JobTitle", emp.JobTitle);


            cmdUpdate.Connection = con;
            cmdUpdate.ExecuteNonQuery();
            con.Close();
        }


        public static void DeleteRecord(int empId)
        {
            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            //cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = " + empId;
            cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", empId);
            cmdDelete.Connection = con;
            cmdDelete.ExecuteNonQuery();
            con.Close();

        }

        public static List<Employee> listAllRecord()
        {
            

            List<Employee> empList = new List<Employee>();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("SELECT * FROM Employees", con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                Employee emp;

                while (sqlreadRecord.Read())
                {
                    emp = new Employee();
                    emp.EmployeeId = Convert.ToInt32(sqlreadRecord["EmployeeId"]);
                    emp.FirstName = sqlreadRecord["firstName"].ToString();
                    emp.LastName = sqlreadRecord["lastName"].ToString();
                    emp.JobTitle = sqlreadRecord["jobTitle"].ToString();
                    empList.Add(emp);
                   

                }

                
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            return empList;

            //SqlCommand cmdListRecord = new SqlCommand();
            //cmdListRecord.CommandText = "SELECT * FROM Employees";
            //cmdListRecord.Connection = con;
            //SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

            //Employee emp;

            //while(sqlreadRecord.Read())
            //{
            //    emp = new Employee();
            //    emp.EmployeeId = Convert.ToInt32(sqlreadRecord["EmployeeId"]);
            //    emp.FirstName = sqlreadRecord["firstName"].ToString();
            //    emp.LastName = sqlreadRecord["lastName"].ToString();
            //    emp.JobTitle = sqlreadRecord["jobTitle"].ToString();
            //    empList.Add(emp);

            //}
            //
            //return empList;

        }

        public static Employee SearchRecord(int empid)
        {
            Employee emp = new Employee();
            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = con;
            cmdSearch.CommandText = " SELECT * FROM Employees " +
                "WHERE EmployeeId = @EmployeeId";
            cmdSearch.Parameters.AddWithValue("@EmployeeId",empid);
            SqlDataReader reader = cmdSearch.ExecuteReader();

            if (reader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                return emp;

            }
            return null;

        }
    
        public static bool IsDuplicateId(int empId)
        {
            Employee emp = EmployeeDB.SearchRecord(empId);
            if (emp!=null)
            {
                return true;
            }


            return false;
        }
        //        select* from Employees

        //where FirstName = 'Mary' or LastName = 'Green'


        public static List<Employee> SearchFirstName(string name)
        {
            List<Employee> empByName =  new List<Employee>();
      
            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = con;
            cmdSearch.CommandText = " SELECT * FROM Employees " +
                "WHERE FirstName = @FirstName";
            cmdSearch.Parameters.AddWithValue("@FirstName", name);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            Employee emp;

            while (reader.Read())
            {
                emp = new Employee();

                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                empByName.Add(emp);

            }
            return empByName;

        }
        public static List<Employee> SearchLastName(string name)
        {
            List<Employee> empByName = new List<Employee>();
            
            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = con;
            cmdSearch.CommandText = " SELECT * FROM Employees " +
                "WHERE LastName = @LastName";
            cmdSearch.Parameters.AddWithValue("@LastName", name);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            Employee emp;

            while (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                empByName.Add(emp);

            }
            return empByName;

        }

        public static List<Employee> SearchJobTitile(string title)
        {
            List<Employee> empByTitle = new List<Employee>();

            SqlConnection con = UtilityDB.ConnectDB();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = con;
            cmdSearch.CommandText = " SELECT * FROM Employees " +
                "WHERE Jobtitle = @JobTitle";
            cmdSearch.Parameters.AddWithValue("@JobTitle", title);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            Employee emp;

            while (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                empByTitle.Add(emp);

            }
            return empByTitle;

        }
    }



}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab1_ASP.NetConnectedMode.DAL;

namespace Lab1_ASP.NetConnectedMode.BILL
{
    public class Employee
    {
        // class private properties
        private  int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;

       // class public properties
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }



        // class public methods

       public void saveEmployee(Employee emp)
       {
            EmployeeDB.SaveRecord(emp);
       }

       public void updateEmployee(int empId, Employee emp)
       {
            EmployeeDB.updateRecord(empId, emp);
       }

       public void updateEmployee(int empId)
       {
            EmployeeDB.DeleteRecord(empId);
       }

        public List<Employee> listEmployees()
        {
            return EmployeeDB.listAllRecord();       
        }
        

    }
}
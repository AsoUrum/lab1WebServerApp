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

       public void SaveEmployee(Employee emp)
       {
            EmployeeDB.SaveRecord(emp);
       }

       public void UpdateEmployee(Employee emp)
       {
            EmployeeDB.updateRecord(emp);
       }

       public void DeleteEmployee(int empId)
       {
            EmployeeDB.DeleteRecord(empId);
       }

        public List<Employee> ListEmployees()
        {
            return EmployeeDB.listAllRecord();       
        }

        public Employee SearchEmployee(int id)
        {

            return EmployeeDB.SearchRecord(id);
        }

        public bool DuplicateId(int Id)
        {
            return EmployeeDB.IsDuplicateId(Id);
        }

        public List<Employee> SearchFirstName(string FirstName)
        {

            return EmployeeDB.SearchFirstName(FirstName);


        }

        public List<Employee> SearchLastName(string LastName)
        {

            return EmployeeDB.SearchLastName(LastName);


        }
        public  List<Employee> SearchJobTitile(string title)
        {
            return EmployeeDB.SearchJobTitile(title);
        }

    }
}
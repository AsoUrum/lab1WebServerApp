using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Lab1_ASP.NetConnectedMode.DAL;
using Lab1_ASP.NetConnectedMode.VALIDATION;
using Lab1_ASP.NetConnectedMode.BILL;



namespace Lab1_ASP.NetConnectedMode.GUI
{
    public partial class WebFormTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database connection : " + UtilityDB.ConnectDB().State.ToString());
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string input;
            input = tbEmployeeId.Text.Trim();
            if (!(Validator.Isvalid(input) == true))
            {

                MessageBox.Show("Employee ID must be 4digit number", "invalid Id");
                tbEmployeeId.Text = "";
                tbEmployeeId.Focus();
                return;

            }
            else
            {


                MessageBox.Show("valid id");
            }
            //checked duplicate id


            //Employee emp = new Employee();
            //if (emp.DuplicateId(Convert.ToInt32(tbEmployeeId.Text))
            //    {

            //}


            input = "";
            input = tbFirstName.Text;
            if (!(Validator.IsValidName(input) == true))
            {

                MessageBox.Show("Please Enter A valid first Name", "invalid Id");
                tbFirstName.Text = "";
                tbFirstName.Focus();
                return;

            }
            else
            {
                MessageBox.Show("valid FirstName");
            }

            Employee emp = new Employee();
            
            emp.EmployeeId = Convert.ToInt32(tbEmployeeId.Text);
            emp.FirstName = tbFirstName.Text.Trim();
            emp.LastName = tbLastName.Text.Trim();
            emp.JobTitle = tbJobTitle.Text.Trim();

            emp.SaveEmployee(emp);
            MessageBox.Show("employee Data saved");


        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(tbEmployeeId.Text);
            Employee emp = new Employee();
            emp = emp.SearchEmployee(searchId);
            if(emp != null)
            {
                tbEmployeeId.Text = emp.EmployeeId.ToString();
                tbFirstName.Text = emp.FirstName;
                tbLastName.Text = emp.LastName;
                tbJobTitle.Text = emp.JobTitle;

            }

        }

        protected void btnListAll_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> ListE = emp.ListEmployees();
            if (ListE.Count != 0)
            {
                GridViewEmployee.DataSource = ListE;
                GridViewEmployee.DataBind();
            }
            else {

                MessageBox.Show("DataBase is empty");
            
            }
            
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(tbEmployeeId.Text);
            emp.FirstName = tbFirstName.Text.Trim();
            emp.LastName = tbLastName.Text.Trim();
            emp.JobTitle = tbJobTitle.Text.Trim();

            emp.UpdateEmployee(emp);
            MessageBox.Show("employee Data updated");


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            int id = Convert.ToInt32(tbEmployeeId.Text);
            emp.DeleteEmployee(id);
            MessageBox.Show("employee Record deleted");

        }
    }
}
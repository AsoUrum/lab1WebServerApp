using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab1_ASP.NetConnectedMode.VALIDATION;
using System.Windows.Forms;
using Lab1_ASP.NetConnectedMode.BILL;


namespace Lab1_ASP.NetConnectedMode.GUI
{
    public partial class WebFormEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////dpdListSeearchBy.SelectedIndex = -1;
            //dpdListSeearchBy.Items.Add("FirstName");
            //dpdListSeearchBy.Items.Add("LastName");


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string input;
            input = txtEmployeeId.Text.Trim();
            if (!(Validator.Isvalid(input) == true))
            {

                MessageBox.Show("Employee ID must be 4digit number", "Invalid Id");
                txtEmployeeId.Text = "";
                txtEmployeeId.Focus();
                return;

            }

            //checked duplicate id


            //Employee emp = new Employee();
            //if (emp.DuplicateId(Convert.ToInt32(tbEmployeeId.Text))
            //    {

            //}


            input = "";
            input = txtFirstName.Text;
            if (!(Validator.IsValidName(input) == true))
            {

                MessageBox.Show("Please Enter A valid first Name", "Invalid First Name");
                txtFirstName.Text = "";
                txtFirstName.Focus();
                return;

            }
            input = "";
            input = txtLastName.Text;
            if (!(Validator.IsValidName(input) == true))
            {

                MessageBox.Show("Please Enter A valid Last Name", "Invalid Last Name");
                txtLastName.Text = "";
                txtLastName.Focus();
                return;

            }
            input = "";
            input = txtJobTitle.Text;
            if (input.Length == 0)
            {

                MessageBox.Show("Please Enter A JobTitle", "Warning");
                txtJobTitle.Text = "";
                txtJobTitle.Focus();
                return;

            }


            Employee emp = new Employee();

            emp.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            emp.FirstName = txtFirstName.Text.Trim();
            emp.LastName = txtLastName.Text.Trim();
            emp.JobTitle = txtJobTitle.Text.Trim();

            emp.SaveEmployee(emp);
            MessageBox.Show("Employee record  saved");

        }

        protected void btnListAll_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> ListE = emp.ListEmployees();
            if (ListE.Count != 0)
            {
                gviewListAllEmployee.DataSource = ListE;
                gviewListAllEmployee.DataBind();
            }
            else
            {

                MessageBox.Show("DataBase is empty");

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            emp.FirstName = txtFirstName.Text.Trim();
            emp.LastName = txtLastName.Text.Trim();
            emp.JobTitle = txtJobTitle.Text.Trim();

            emp.UpdateEmployee(emp);
            MessageBox.Show("employee Data updated");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            int id = Convert.ToInt32(txtEmployeeId.Text);
            emp.DeleteEmployee(id);
            MessageBox.Show("Employee Record deleted");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (!(txtSearchBy.Text.Length == 0))
            {
              string value = dpdListSeearchBy.SelectedValue;
                
                switch (value)
                {
                    case "EmployeeId":
                        int searchId = Convert.ToInt32(txtSearchBy.Text);
                        Employee emp = new Employee();
                        emp = emp.SearchEmployee(searchId);
                        if (emp != null)
                        {
                            txtEmployeeId.Text = emp.EmployeeId.ToString();
                            txtFirstName.Text = emp.FirstName;
                            txtLastName.Text = emp.LastName;
                            txtJobTitle.Text = emp.JobTitle;

                        }
                        break;
                    case "First Name":
                        string searchFName = txtSearchBy.Text;
                        Employee emp1 = new Employee();
                        List<Employee> empByFName = new List<Employee>();
                        empByFName = emp1.SearchFirstName(searchFName);
                        
                        if (empByFName != null)
                        {

                            gviewListAllEmployee.DataSource = empByFName;
                            gviewListAllEmployee.DataBind();

                        }
                        break;
                    case "Last Name":
                        string searchLName = txtSearchBy.Text;
                        Employee emp2 = new Employee();
                        List<Employee> empByLName = new List<Employee>();
                        empByLName = emp2.SearchLastName(searchLName);

                        if (empByLName != null)
                        {

                            gviewListAllEmployee.DataSource = empByLName;
                            gviewListAllEmployee.DataBind();

                        }
                        break;
                    case "JobTitle":
                        string searchTitle = txtSearchBy.Text;
                        Employee emp3 = new Employee();
                        List<Employee> empByTitle = new List<Employee>();
                        empByTitle = emp3.SearchJobTitile(searchTitle);

                        if (empByTitle != null)
                        {

                            gviewListAllEmployee.DataSource = empByTitle;
                            gviewListAllEmployee.DataBind();

                        }
                        else
                        {
                            MessageBox.Show("Information not found");
                            txtSearchBy.Text = "";
                            txtSearchBy.Focus();

                        }
                        break;

                    default:
                        break;

                }
                  

            }
            else
            {
                MessageBox.Show(" enter an id");
            }

        }
    }
}
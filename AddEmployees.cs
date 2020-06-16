using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace PayrollManagement
{
    public partial class AddEmployees : Form
    {
        private bool isMember;

        public AddEmployees()
        {
            InitializeComponent();
        }
        public void checkMember()
        {
            if (unionMember.Checked)
            {
                isMember = true;
            }
            else
            {
                isMember = false;
            }
        }
        public void PopulateCountry() { 
            List<string> countries = new List<string>();
            countries.Add("Select A Country....");
            countries.Add("Albania");
            countries.Add("Angola");
            countries.Add("Brazil");
            countries.Add("France");
            countries.Add("Germany");
            countries.Add("Ghana");
            countries.Add("Japan");
            countries.Add("Libya");
            countries.Add("Nigeria");
            countries.Add("Russia");
            countries.Add("South Korea");
            countries.Add("Tanzania");
            countries.Add("USA");
            countries.Add("England");
            countries.Sort();
            countries.ForEach(county =>country.Items.Add(county));
            countries.ElementAt(country.SelectedIndex=0);
            //for (var county = 0; county < countries.Count;county++ ) {
            //    country.Items.Add(countries[county]);
            //    country.SelectedIndex = 0;
            //}
        }
        private bool validateInputs()
        {
            Regex objEmployeeFirstName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objEmployeeLastName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objEmployeeNi = new Regex("^[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-D\\s]*$");
            Regex objEmailAddress = new Regex("^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,3}$");
            if (string.IsNullOrEmpty(empFirstName.Text))
            {
                MessageBox.Show("Please enter Employee First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empFirstName.Focus();
                empFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(150)))));
                return false;
            }
            else if (!objEmployeeFirstName.IsMatch(empFirstName.Text))
            {
                MessageBox.Show("Please enter a valid Name in the Employee Last name field", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empFirstName.Focus();
                empFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(150)))));
                return false;
            }
            else
            {
                empFirstName.BackColor = Color.WhiteSmoke;

            }
            if (string.IsNullOrEmpty(empLastName.Text))
            {
                MessageBox.Show("Please enter Employee Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empLastName.Focus();
                empLastName.BackColor = Color.MidnightBlue;
                return false;
            }
            else if (!objEmployeeLastName.IsMatch(empLastName.Text))
            {
                MessageBox.Show("Please enter a valid Employee Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empLastName.Focus();
                empLastName.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                empLastName.BackColor = Color.WhiteSmoke;

            }
            if (empGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Employee Gender", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empGender.Focus();
                empGender.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                empGender.BackColor = Color.WhiteSmoke;

            }
            if (maritalStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Employee Marital Status", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maritalStatus.Focus();
                maritalStatus.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                maritalStatus.BackColor = Color.WhiteSmoke;

            }
            if (niNumber.Text == "")
            {
                MessageBox.Show("Please enter National Insurance number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                niNumber.Focus();
                niNumber.BackColor = Color.MidnightBlue;
                return false;
            }
            else if (!objEmployeeNi.IsMatch(niNumber.Text))
            {
                MessageBox.Show("Please enter a valid Insurance Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                niNumber.Focus();
                niNumber.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                niNumber.BackColor = Color.WhiteSmoke;

            }
            if (address.Text == "")
            {
                MessageBox.Show("Please enter Employee Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                address.Focus();
                address.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                address.BackColor = Color.WhiteSmoke;

            }
            if (city.Text == "")
            {
                MessageBox.Show("Please enter Employee City", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                city.Focus();
                city.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                city.BackColor = Color.WhiteSmoke;

            }
            if (postCode.Text == "")
            {
                MessageBox.Show("Please enter Employee Post Code", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                postCode.Focus();
                postCode.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                postCode.BackColor = Color.WhiteSmoke;

            }
            if (country.SelectedIndex == 0 || country.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Employee Country", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                country.Focus();
                country.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                country.BackColor = Color.WhiteSmoke;

            }
            if (phoneNumber.Text.Length == 0)
            {
                MessageBox.Show("Please enter Employee Phone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumber.Focus();
                phoneNumber.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                phoneNumber.BackColor = Color.WhiteSmoke;

            }
            if (emailAddress.Text == "")
            {
                MessageBox.Show("Please enter Employee Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailAddress.Focus();
                emailAddress.BackColor = Color.MidnightBlue;
                return false;
            }
            //else if (!objEmailAddress.IsMatch(emailAddress.Text))
            //{
            //    MessageBox.Show("Please enter a valid Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    emailAddress.Focus();
            //    emailAddress.BackColor = Color.MidnightBlue;
            //    return false;
            //}
            //.net email validation
            else if (emailAddress.Text.Length >= 1)
            {
                try
                {
                    MailAddress objMail = new MailAddress(emailAddress.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailAddress.Focus();
                    emailAddress.BackColor = Color.MidnightBlue;
                    return false;
                }

            }
            else
            {
                emailAddress.BackColor = Color.WhiteSmoke;

            }
            if (notes.Text.Length > 30)
            {
                MessageBox.Show("The number of text entered is greater than 30. Please enter fewer text.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                notes.Focus();
                notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(150)))));
                return false;
            }
            else
            {
                notes.BackColor = Color.WhiteSmoke;

            }

            return true;
        }

        private void saveEmpDetails_Click(object sender, EventArgs e)
        {

            if (validateInputs())
            {
                //Connection String
                checkMember();
                string cs = ConfigurationManager.ConnectionStrings["PayrollManagement.Properties.Settings.PayrollDatabaseConnectionString"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(cs);
                string insertEmployeeDetails = "INSERT INTO Employees(FirstName,LastName,Gender,NINumber,DateOfBirth,MaritalStatus,IsMember,Address,City,PostCode,Country,PhoneNumber,EmailAddress,Notes)"
                         + " VALUES(@FirstName,@LastName,@Gender,@NINumber,@DateOfBirth,@MaritalStatus,@IsMember,@Address,@City,@PostCode,@Country,@PhoneNumber,@EmailAddress,@Notes)";
                SqlCommand sqlCommand = new SqlCommand(insertEmployeeDetails, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@FirstName", empFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", empLastName.Text);
                sqlCommand.Parameters.AddWithValue("@Gender", empGender.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@NINumber", niNumber.Text);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Value.ToString("MM/dd/yyyy"));
                sqlCommand.Parameters.AddWithValue("@MaritalStatus", maritalStatus.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@IsMember", isMember);
                sqlCommand.Parameters.AddWithValue("@Address", address.Text);
                sqlCommand.Parameters.AddWithValue("@City", city.Text);
                sqlCommand.Parameters.AddWithValue("@PostCode", postCode.Text);
                sqlCommand.Parameters.AddWithValue("@Country", country.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", emailAddress.Text);
                sqlCommand.Parameters.AddWithValue("@Notes", notes.Text);

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee has been added successfully", "Insertion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following errror occured while trying to insert new Employee Details: " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                    // this.Close();
                }







            }
        }

        private void resetEmpEntry_Click(object sender, EventArgs e)
        {
            empFirstName.Clear();
            empLastName.Clear();
            empGender.SelectedIndex = -1;
            dateOfBirth.Value = new DateTime(1990, 12, 30);
            maritalStatus.SelectedIndex = -1;
            unionMember.Checked = false;
            city.Clear();
            address.Clear();
            phoneNumber.Clear();
            postCode.Clear();
            emailAddress.Clear();
            niNumber.Text = "";
            country.SelectedIndex = 0;
            notes.Clear();
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {
            PopulateCountry();
        }
    }
}

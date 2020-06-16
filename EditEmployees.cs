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

namespace PayrollManagement
{
    public partial class EditEmployees : Form
    {
        bool isMember;
        public EditEmployees()
        {
            InitializeComponent();
        }
        private void clearDetails()
        {
            editEmpID.Clear();
            editFirstName.Clear();
            editLastName.Clear();
            editGender.SelectedIndex = -1;
            editUnionMember.Checked = false;
            editDateOfBirth.Value = new DateTime(1990, 12, 30);
            editMaritalStatus.SelectedIndex = -1;
            editNiNumber.Clear();
            editAddress.Clear();
            editCity.Clear();
            editPostCode.Clear();
            editCountry.SelectedIndex = 0;
            editPhoneNumber.Clear();
            editEmailAddress.Clear();
            editNotes.Clear();
        }
        private bool validateInputs()
        {
            Regex objEmployeeFirstName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objEmployeeLastName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objEmployeeNi = new Regex("^[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-D\\s]*$");
            Regex objEmailAddress = new Regex("^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,3}$");
            if (string.IsNullOrEmpty(editFirstName.Text))
            {
                MessageBox.Show("Please enter Employee First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editFirstName.Focus();
                editFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(150)))));
                return false;
            }
            else if (!objEmployeeFirstName.IsMatch(editFirstName.Text))
            {
                MessageBox.Show("Please enter a valid Name in the Employee Last name field", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editFirstName.Focus();
                editFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(150)))));
                return false;
            }
            else
            {
                editFirstName.BackColor = Color.WhiteSmoke;

            }
            if (string.IsNullOrEmpty(editLastName.Text))
            {
                MessageBox.Show("Please enter Employee Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editLastName.Focus();
                editLastName.BackColor = Color.MidnightBlue;
                return false;
            }
            else if (!objEmployeeLastName.IsMatch(editLastName.Text))
            {
                MessageBox.Show("Please enter a valid Employee Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editLastName.Focus();
                editLastName.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editLastName.BackColor = Color.WhiteSmoke;

            }
            if (editGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Employee Gender", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editGender.Focus();
                editGender.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editGender.BackColor = Color.WhiteSmoke;

            }
            if (editMaritalStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Employee Marital Status", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editMaritalStatus.Focus();
                editMaritalStatus.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editMaritalStatus.BackColor = Color.WhiteSmoke;

            }
            if (editNiNumber.Text == "")
            {
                MessageBox.Show("Please enter National Insurance number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editNiNumber.Focus();
                editNiNumber.BackColor = Color.MidnightBlue;
                return false;
            }
            else if (!objEmployeeNi.IsMatch(editNiNumber.Text))
            {
                MessageBox.Show("Please enter a valid Insurance Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editNiNumber.Focus();
                editNiNumber.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editNiNumber.BackColor = Color.WhiteSmoke;

            }
            if (editAddress.Text == "")
            {
                MessageBox.Show("Please enter Employee Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editAddress.Focus();
                editAddress.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editAddress.BackColor = Color.WhiteSmoke;

            }
            if (editCity.Text == "")
            {
                MessageBox.Show("Please enter Employee City", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editCity.Focus();
                editCity.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editCity.BackColor = Color.WhiteSmoke;

            }
            if (editPostCode.Text == "")
            {
                MessageBox.Show("Please enter Employee Post Code", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editPostCode.Focus();
                editPostCode.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editPostCode.BackColor = Color.WhiteSmoke;

            }
            if (editCountry.SelectedIndex == 0 || editCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Employee Country", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editCountry.Focus();
                editCountry.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editCountry.BackColor = Color.WhiteSmoke;

            }
            if (editPhoneNumber.Text.Length == 0)
            {
                MessageBox.Show("Please enter Employee Phone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editPhoneNumber.Focus();
                editPhoneNumber.BackColor = Color.MidnightBlue;
                return false;
            }
            else
            {
                editPhoneNumber.BackColor = Color.WhiteSmoke;

            }
            if (editEmailAddress.Text == "")
            {
                MessageBox.Show("Please enter Employee Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editEmailAddress.Focus();
                editEmailAddress.BackColor = Color.MidnightBlue;
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
            else if (editEmailAddress.Text.Length >= 1)
            {
                try
                {
                    MailAddress objMail = new MailAddress(editEmailAddress.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    editEmailAddress.Focus();
                    editEmailAddress.BackColor = Color.MidnightBlue;
                    return false;
                }

            }
            else
            {
                editEmailAddress.BackColor = Color.WhiteSmoke;

            }
            if (editNotes.Text.Length > 30)
            {
                MessageBox.Show("The number of text entered is greater than 30. Please enter fewer text.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editNotes.Focus();
                editNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(150)))));
                return false;
            }
            else
            {
                editNotes.BackColor = Color.WhiteSmoke;

            }

            return true;
        }
        public void getEmployeeDetails(int employeeID, string firstName, string lastName, string gender, string nationalInsurance, string dteOfBirth,
            string martalStatus, bool isUnionMember, string residentialAddress, string cityOfResidence, string pstCode, string countryOfResidence,
            string phone, string email, string note)
        {
            editEmpID.Text = Convert.ToString(employeeID);
            editFirstName.Text = firstName;
            editLastName.Text = lastName;
            editGender.Text = gender;
            editUnionMember.Text = isUnionMember.ToString();
            editDateOfBirth.Text = dteOfBirth;
            editMaritalStatus.Text = martalStatus;
            editNiNumber.Text = nationalInsurance;
            editAddress.Text = residentialAddress;
            editCity.Text = cityOfResidence;
            editPostCode.Text = pstCode;
            editCountry.Text = countryOfResidence;
            editPhoneNumber.Text = phone;
            editEmailAddress.Text = email;
            editNotes.Text = note;
            if (isUnionMember == true)
            {
                editUnionMember.Checked = true;
            }
            else
            {
                editUnionMember.Checked = false;
            }




        }
        public void checkMember()
        {
            if (editUnionMember.Checked)
            {
                isMember = true;
            }
            else
            {
                isMember = false;
            }
        }

        private void resetUpdateEntry_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void updateEmpDetails_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                //Connection String
                checkMember();
                string cs = ConfigurationManager.ConnectionStrings["PayrollManagement.Properties.Settings.PayrollDatabaseConnectionString"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(cs);


                string updateEmployeeDetails = "UPDATE Employees SET FirstName= @FirstName,LastName=@LastName,Gender= @Gender,NINumber=@NINumber,DateOfBirth=@DateOfBirth,MaritalStatus=@MaritalStatus,IsMember=@IsMember,Address=@Address,City=@City,PostCode=@PostCode,Country=@Country,PhoneNumber=@PhoneNumber,EmailAddress=@EmailAddress,Notes=@Notes WHERE EmployeeID=@EmployeeID";
                SqlCommand sqlCommand = new SqlCommand(updateEmployeeDetails, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@FirstName", editFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", editLastName.Text);
                sqlCommand.Parameters.AddWithValue("@Gender", editGender.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@NINumber", editNiNumber.Text);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", editDateOfBirth.Value.ToString("MM/dd/yyyy"));
                sqlCommand.Parameters.AddWithValue("@MaritalStatus", editMaritalStatus.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@IsMember", isMember);
                sqlCommand.Parameters.AddWithValue("@Address", editAddress.Text);
                sqlCommand.Parameters.AddWithValue("@City", editCity.Text);
                sqlCommand.Parameters.AddWithValue("@PostCode", editPostCode.Text);
                sqlCommand.Parameters.AddWithValue("@Country", editCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", editPhoneNumber.Text);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", editEmailAddress.Text);
                sqlCommand.Parameters.AddWithValue("@Notes", editNotes.Text);
                sqlCommand.Parameters.AddWithValue("@EmployeeID", editEmpID.Text);


                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee record has been updated successfully", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following errror occured while trying to update the Employee Details: " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                    // this.Close();
                }
            }
        }

        private void deleteEmployeeDetails_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string cs = ConfigurationManager.ConnectionStrings["PayrollManagement.Properties.Settings.PayrollDatabaseConnectionString"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(cs);

                try
                {
                    sqlConnection.Open();
                    string deleteEmployeeDetails = "DELETE FROM Employees WHERE EmployeeID='" + editEmpID.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(deleteEmployeeDetails, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee detail has been deleted successfully", "Successful Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following errror occured while trying to delete the Employee Details: " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                    clearDetails();
                }


            }
        }
    }
}

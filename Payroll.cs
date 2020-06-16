using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PayrollManagement
{
    public partial class Payroll : Form
    {
        String fullName= string.Empty;
        //Variables for days of the week
        double Mon1 = 0.00, Tues1 = 0.00, Wed1 = 0.00, Thurs1 = 0.00, Fri1 = 0.00, Sat1 = 0.00, Sun1 = 0.00;
        double Mon2 = 0.00, Tues2 = 0.00, Wed2 = 0.00, Thurs2 = 0.00, Fri2 = 0.00, Sat2 = 0.00, Sun2 = 0.00;
        double Mon3 = 0.00, Tues3 = 0.00, Wed3 = 0.00, Thurs3 = 0.00, Fri3 = 0.00, Sat3 = 0.00, Sun3= 0.00;
        double Mon4 = 0.00, Tues4 = 0.00, Wed4 = 0.00, Thurs4 = 0.00, Fri4 = 0.00, Sat4 = 0.00, Sun4 = 0.00;

        //Variables for Hours
        double totalWk1Hours, totalWk2Hours, totalWk3Hours, totalWk4Hours;
        double contractualWk1Hours, contractualWk2Hours, contractualWk3Hours, contractualWk4Hours;
        double overtimeWk1Hours, overtimeWk2Hours, overtimeWk3Hours, overtimeWk4Hours;
        double totalContractualHours, totalOvertimeHours,totalHoursWorked; 
              
        //Variables for Earnings
        double contractualWk1Amount, contractualWk2Amount, contractualWk3Amount, contractualWk4Amount;
        double overtimeWk1Amount, overtimeWk2Amount, overtimeWk3Amount, overtimeWk4Amount;
        double totalContractualAmount, totalOvertimeAmount, totalAmountEarned;

        //Variables for Mandatory deductions
        double tax, NIContribution, taxRate, NIRate, SLC, totalDeductions;

        //Constant for voluntary contribution;
        const double Union = 10.00;  
        const double SLCRate = .05;

        //Variables for payrate
        double hourlySalaryRate, overtimeSalaryRate;

        //Variable for NEt pay
        double netPay;
        public Payroll()
        {
            InitializeComponent();
        }
        private bool validateInput(){
            if(employeeID.Text==""){
                MessageBox.Show("Please enter employee Id","Data Entry Error");
                employeeID.Focus();
                return false;
            }
            if (currentMonth.SelectedIndex==0)
            {
                MessageBox.Show("Please Select current month", "Data Entry Error");
                currentMonth.Focus();
                return false;
            }
            if (payPeriod.SelectedIndex == 0)
            {
                MessageBox.Show("Please select employee's Pay period", "Data Entry Error");
                payPeriod.Focus();
                return false;
            }
            return true;
        }
        private void ListOfMonths() { 
            string[] months={"Select a Month...","January","February","March","April","May","June","July","August","September","October","November","December"};
            foreach(var month in months){
                currentMonth.Items.Add(month);
                currentMonth.SelectedIndex = 0;
            }  
        }
        //Getting and converting valuesfrom string to double for wk1
        private void GetWeek1Values() {
            //Monday
            try {
                Mon1=double.Parse(firstMonday.Value.ToString());
            }catch(FormatException ex){
                MessageBox.Show("The following error occured:"+ex.Message,"Error Message");
                this.firstMonday.Focus();
            }
            //Tuesday
            try
            {
                Tues1 = double.Parse(firstTuesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.firstTuesday.Focus();
            }
            //Wednesday
            try
            {
                Wed1 = double.Parse(firstWednesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.firstWednesday.Focus();
            }
            //Thursday
            try
            {
                Thurs1 = double.Parse(firstThursday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.firstThursday.Focus();
            }
            //Friday
            try
            {
                Fri1 = double.Parse(firstFriday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.firstFriday.Focus();
            }
            //Saturday
            try
            {
                Sat1 = double.Parse(firstSaturday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.firstSaturday.Focus();
            }
            //Sunday
            try
            {
                Sun1 = double.Parse(firstSunday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.firstSunday.Focus();
            }
        }
        private void GetWeek2Values()
        {
            //Monday
            try
            {
                Mon2 = double.Parse(secondMonday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.secondMonday.Focus();
            }
            //Tuesday
            try
            {
                Tues2 = double.Parse(secondTuesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.secondTuesday.Focus();
            }
            //Wednesday
            try
            {
                Wed2 = double.Parse(secondWednesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.secondWednesday.Focus();
            }
            //Thursday
            try
            {
                Thurs2 = double.Parse(secondThursday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.secondThursday.Focus();
            }
            //Friday
            try
            {
                Fri2 = double.Parse(secondFriday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.secondFriday.Focus();
            }
            //Saturday
            try
            {
                Sat2 = double.Parse(secondSaturday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.secondSaturday.Focus();
            }
            //Sunday
            try
            {
                Sun2 = double.Parse(secondSunday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.secondSunday.Focus();
            }
        }
        private void GetWeek3Values()
        {
            //Monday
            try
            {
                Mon3 = double.Parse(thirdMonday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.thirdMonday.Focus();
            }
            //Tuesday
            try
            {
                Tues3 = double.Parse(thirdTuesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.thirdTuesday.Focus();
            }
            //Wednesday
            try
            {
                Wed3 = double.Parse(thirdWednesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.thirdWednesday.Focus();
            }
            //Thursday
            try
            {
                Thurs3 = double.Parse(thirdThursday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.thirdThursday.Focus();
            }
            //Friday
            try
            {
                Fri3 = double.Parse(thirdFriday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.thirdFriday.Focus();
            }
            //Saturday
            try
            {
                Sat3 = double.Parse(thirdSaturday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.thirdSaturday.Focus();
            }
            //Sunday
            try
            {
                Sun3 = double.Parse(thirdSunday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.thirdSunday.Focus();
            }
        }
        private void GetWeek4Values()
        {
            //Monday
            try
            {
                Mon4 = double.Parse(fourthMonday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.fourthMonday.Focus();
            }
            //Tuesday
            try
            {
                Tues4 = double.Parse(fourthTuesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.fourthTuesday.Focus();
            }
            //Wednesday
            try
            {
                Wed4 = double.Parse(fourthWednesday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.fourthWednesday.Focus();
            }
            //Thursday
            try
            {
                Thurs4 = double.Parse(fourthThursday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.fourthThursday.Focus();
            }
            //Friday
            try
            {
                Fri4 = double.Parse(fourthFriday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.fourthFriday.Focus();
            }
            //Saturday
            try
            {
                Sat4 = double.Parse(fourthSaturday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.fourthSaturday.Focus();
            }
            //Sunday
            try
            {
                Sun4 = double.Parse(fourthSunday.Value.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("The following error occured:" + ex.Message, "Error Message");
                this.fourthSunday.Focus();
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            ListOfMonths(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void computePayment_Click(object sender, EventArgs e)
        {
            if(validateInput()){
                GetWeek1Values();
                GetWeek2Values();
                GetWeek3Values();
                GetWeek4Values();

                //Computing wely hours
                totalWk1Hours = Mon1 + Tues1 + Wed1 + Thurs1 + Fri1 + Sat1 + Sun1;
                totalWk2Hours = Mon2 + Tues2 + Wed2 + Thurs2 + Fri2 + Sat2 + Sun2;
                totalWk3Hours = Mon3 + Tues3 + Wed3 + Thurs3 + Fri3 + Sat3 + Sun3;
                totalWk4Hours = Mon4 + Tues4 + Wed4 + Thurs4 + Fri4 + Sat4 + Sun4;

                //Retriving Hourly rate
                try{
                    hourlySalaryRate= double.Parse(hourlyRate.Value.ToString());
                }catch(FormatException ex){
                    MessageBox.Show("The following error occured: "+ex.Message,"Error Message");
                }

                //Retriving overtime rate
                overtimeSalaryRate = hourlySalaryRate * 1.5;

                #region   First week payments calculation
                //Calculating payments for hours worked in week1 without overtime
                if(totalWk1Hours<=36){
                    contractualWk1Hours = hourlySalaryRate *totalWk1Hours;
                    contractualWk1Amount = hourlySalaryRate * totalWk1Hours;
                    overtimeWk1Hours = 0.00;
                    overtimeWk1Amount = 0.00;
                }
                //Calculating payments for hours worked in week1 with overtime
                else if(totalWk1Hours>36){
                    contractualWk1Hours = 36;
                    contractualWk1Amount = hourlySalaryRate * contractualWk1Hours;
                    overtimeWk1Hours = totalWk1Hours-contractualWk1Hours;
                    overtimeWk1Amount = overtimeWk1Hours * overtimeSalaryRate;
                }
                #endregion   end of first weeek computation
                #region   Second week payments calculation
                //Calculating payments for hours worked in week2 without overtime
                if (totalWk2Hours <= 36)
                {
                    contractualWk2Hours = hourlySalaryRate * totalWk2Hours;
                    contractualWk2Amount = hourlySalaryRate * totalWk2Hours;
                    overtimeWk2Hours = 0.00;
                    overtimeWk2Amount = 0.00;
                }
                //Calculating payments for hours worked in week2 with overtime
                else if (totalWk2Hours > 36)
                {
                    contractualWk2Hours = 36;
                    contractualWk2Amount = hourlySalaryRate * contractualWk2Hours;
                    overtimeWk2Hours = totalWk2Hours - contractualWk2Hours;
                    overtimeWk2Amount = overtimeWk2Hours * overtimeSalaryRate;
                }
                #endregion   end of second week payment calculation
                #region   Third week payments calculation
                //Calculating payments for hours worked in week3 without overtime
                if (totalWk1Hours <= 36)
                {
                    contractualWk3Hours = hourlySalaryRate * totalWk3Hours;
                    contractualWk3Amount = hourlySalaryRate * totalWk3Hours;
                    overtimeWk3Hours = 0.00;
                    overtimeWk3Amount = 0.00;
                }
                //Calculating payments for hours worked in week3 with overtime
                else if (totalWk1Hours > 36)
                {
                    contractualWk3Hours = 36;
                    contractualWk3Amount = hourlySalaryRate * contractualWk3Hours;
                    overtimeWk3Hours = totalWk3Hours - contractualWk3Hours;
                    overtimeWk3Amount = overtimeWk3Hours * overtimeSalaryRate;
                }
                #endregion   end of third weeek payment calculation
                #region   Fourth week payments calculation
                //Calculating payments for hours worked in week4 without overtime
                if (totalWk1Hours <= 36)
                {
                    contractualWk4Hours = hourlySalaryRate * totalWk4Hours;
                    contractualWk4Amount = hourlySalaryRate * totalWk4Hours;
                    overtimeWk4Hours = 0.00;
                    overtimeWk4Amount = 0.00;
                }
                //Calculating payments for hours worked in week4 with overtime
                else if (totalWk1Hours > 36)
                {
                    contractualWk4Hours = 36;
                    contractualWk4Amount = hourlySalaryRate * contractualWk4Hours;
                    overtimeWk4Hours = totalWk4Hours - contractualWk4Hours;
                    overtimeWk4Amount = overtimeWk4Hours * overtimeSalaryRate;
                }
                #endregion   end of Fourth week payment calculation

                //Calculating total hours and amount for all 4weeks
                totalContractualAmount = contractualWk1Amount + contractualWk2Amount + contractualWk3Amount + contractualWk4Amount;
                totalContractualHours = contractualWk1Hours + contractualWk2Hours + contractualWk3Hours + contractualWk4Hours;
                totalOvertimeHours = overtimeWk1Hours + overtimeWk2Hours + overtimeWk3Hours + overtimeWk4Hours;
                totalOvertimeAmount = overtimeWk1Amount+overtimeWk2Amount+overtimeWk3Amount+ overtimeWk4Amount;
                totalHoursWorked = totalContractualAmount + totalOvertimeHours;
                totalAmountEarned = totalContractualAmount + totalOvertimeAmount;

                //Calculating deductions
                #region Tax Calculation
                // Caclulating income Tax
                if(totalAmountEarned <916.67){
                    //Tax free rate
                    taxRate=.0;
                    tax = totalAmountEarned * taxRate;
                }
                else if(totalAmountEarned >916.67 && totalAmountEarned<3583.33){
                    //Basic tax Rate
                    taxRate = .20;
                    //Income tax
                    tax=((916.67*.0)+((totalAmountEarned-916.67)*taxRate));
                }
                else if(totalAmountEarned>3583.33 && totalAmountEarned <12500){
                    //High tax rate
                    taxRate = .40;
                    //Icome tax
                    tax = ((916.67 * .0)+((3583.33-916.67)*.20) + ((totalAmountEarned - 3583.33) * taxRate));
                }
                else if(totalAmountEarned>12500){
                    //Additional tax rate
                    taxRate=.45;
                    //Income rate
                    tax = ((916.67 * .0)+((3583.33-916.67)*.20)+((12500-3583.33)*.40) + ((totalAmountEarned - 3583.33) * taxRate));
                }
                #endregion End of Tax calculation

                #region Calculating National Insurance
                if(totalAmountEarned<620){
                    //Lower earnnig limit
                    NIRate = .0;
                }
                else if(totalAmountEarned>=620 && totalAmountEarned<=3308){
                    NIRate = .12;
                }
                else if(totalAmountEarned>3308){
                    NIContribution = 0.2;
                }
                #endregion

                NIContribution = totalAmountEarned * NIRate;

                SLC = totalAmountEarned * SLCRate;

                totalDeductions = tax + NIContribution + SLC + Union;

                netPay = totalAmountEarned - totalDeductions;

                //displaying result to user interface
                contractualHoursField.Text = totalContractualHours.ToString("F");
                overtimeEarningsField.Text = totalOvertimeAmount.ToString("C");
                overtimeHoursField.Text = totalOvertimeHours.ToString("F");
                contractualEarningsField.Text = totalContractualAmount.ToString("F");
                totalHoursField.Text = totalHoursWorked.ToString("F");
                taxAmountField.Text = tax.ToString("C");
                overtimeRateField.Text = overtimeSalaryRate.ToString("F");
                totalEarnnigsField.Text = totalAmountEarned.ToString("C");
                niContributionField.Text = NIContribution.ToString("C");
                slcField.Text = SLC.ToString("C");
                unionField.Text = Union.ToString("C");
                totalDeductionsField.Text = totalDeductions.ToString("C");
                netPayField.Text = netPay.ToString("C");





            }
        }

        private void getDetails_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["PayrollManagement.Properties.Settings.PayrollDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(cs);
            sqlConnection.Open();

            string getEmployeeDetails = "SELECT FirstName,LastName,NINumber FROM Employees WHERE EmployeeID= "+employeeID.Text;
            SqlCommand sqlCommand = new SqlCommand(getEmployeeDetails, sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@EmployeeID",employeeID);

            try
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    employeeFirstName.Text = sqlDataReader[0].ToString();
                    employeeLastName.Text = sqlDataReader[1].ToString();
                    employeeNINumber.Text = sqlDataReader[2].ToString();
                    fullName = employeeFirstName.Text + " " + employeeLastName.Text;
                    employeeFullNameLabel.Text = fullName;
                }
                else {
                    MessageBox.Show(" No Employee with such record was found"+ employeeID.Text, "Successful retrieve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlDataReader.Close();

    
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following errror occured while trying to retrieve the Employee Details: " + ex.Message, "Data Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
                // this.Close();
            }
        }

        private void savePaymentDetails_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["PayrollManagement.Properties.Settings.PayrollDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(cs);
            string insertPaymentDetails = "INSERT INTO Payments(EmployeeID,FullName,NINumber,PayDate,PayPeriod,PayMonth,HourlyRate,ContractualHours,OvertimeHours,TotalHours,ContractualEarnings,OvertimeEarnings,TotalEarnings,taxCode,TaxAmount,NIContribution,UnionFee,SLC,TotalDeductions,NetPay)"
                     + " VALUES(@EmployeeID,@FullName,@NINumber,@PayDate,@PayPeriod,@PayMonth,@HourlyRate,@ContractualHours,@OvertimeHours,@TotalHours,@ContractualEarnings,@OvertimeEarnings,@TotalEarnings,@taxCode,@TaxAmount,@NIContribution,@UnionFee,@SLC,@TotalDeductions,@NetPay)";
            SqlCommand sqlCommand = new SqlCommand(insertPaymentDetails, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@EmployeeID", employeeID.Text);
            sqlCommand.Parameters.AddWithValue("@FullName", employeeFullNameLabel.Text);
            sqlCommand.Parameters.AddWithValue("@NINumber", employeeNINumber.Text);
            sqlCommand.Parameters.AddWithValue("@PayDate", currentDate.Value.ToString("MM/dd/yyyy"));
            sqlCommand.Parameters.AddWithValue("@PayPeriod",payPeriod.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@PayMonth", currentMonth.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@HourlyRate", hourlyRate.Value.ToString());
            sqlCommand.Parameters.AddWithValue("@ContractualHours", contractualHoursField.Text);
            sqlCommand.Parameters.AddWithValue("@OvertimeHours", overtimeHoursField.Text);
            sqlCommand.Parameters.AddWithValue("@TotalHours", totalHoursField.Text);
            sqlCommand.Parameters.AddWithValue("@ContractualEarnings", contractualEarningsField.Text);
            sqlCommand.Parameters.AddWithValue("@OvertimeEarnings", overtimeEarningsField.Text);
            sqlCommand.Parameters.AddWithValue("@TotalEarnings", totalEarnnigsField.Text);
            sqlCommand.Parameters.AddWithValue("@TaxCode", taxCodeField.Text);
            sqlCommand.Parameters.AddWithValue("@TaxAmount", taxAmountField.Text);
            sqlCommand.Parameters.AddWithValue("@NIContribution", niContributionField.Text);
            sqlCommand.Parameters.AddWithValue("@UnionFee", unionField.Text);
            sqlCommand.Parameters.AddWithValue("@SLC", slcField.Text);
            sqlCommand.Parameters.AddWithValue("@TotalDeductions", totalDeductionsField.Text);
            sqlCommand.Parameters.AddWithValue("@NetPay", netPayField.Text);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Payment Details has been added successfully", "Successful Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following errror occured while trying to add new Employee Payment Details: " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); 
            }

        }
    }
}

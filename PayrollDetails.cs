using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagement
{
    public partial class PayrollDetails : Form
    {
        public PayrollDetails()
        {
            InitializeComponent();
        }

        private void PayrollDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentsDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.paymentsDataSet.Payments);

        }

        private void payrollTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Passing by values
            int num1, num2,result;
            num1 = int.Parse(hoursField.Text);
            num2 = int.Parse(minutesField.Text);
            result = SumOFNumbers(num1,num2);
            decimalField.Text = result.ToString();
        }

        private int SumOFNumbers(int number1, int number2)
        {
            int result = number1 + number2;
             
            return result;
        }

    }
}

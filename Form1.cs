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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            attachedPanel.Height = employeesBtn.Height;
            attachedPanel.Top = employeesBtn.Top;

            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.MdiParent = this;
            // addEmployees.Location= new System.Drawing.Point(223,37);       
            //employeeDetails.Show();
            employeeDetails.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployees addEmployees = new AddEmployees();
            addEmployees.MdiParent = this;
            addEmployees.Visible = true;
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            //Payroll payroll = new Payroll();
            //payroll.MdiParent = this;
            //payroll.Show();
            PayrollDetails payrollDetails = new PayrollDetails();
            payrollDetails.MdiParent = this;
            payrollDetails.Show();

        }
    }
}

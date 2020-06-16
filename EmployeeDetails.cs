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
    public partial class EmployeeDetails : Form
    {
        EditEmployees editEmployees = new EditEmployees();
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);

        }

        private void employeesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editEmployees.getEmployeeDetails(Convert.ToInt32(employeesTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()), employeesTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(), employeesTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(),
               employeesTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(), employeesTable.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(), employeesTable.Rows[e.RowIndex].Cells[5].FormattedValue.ToString(),
               employeesTable.Rows[e.RowIndex].Cells[6].FormattedValue.ToString(), Convert.ToBoolean(employeesTable.Rows[e.RowIndex].Cells[7].FormattedValue.ToString()), employeesTable.Rows[e.RowIndex].Cells[8].FormattedValue.ToString(),
               employeesTable.Rows[e.RowIndex].Cells[9].FormattedValue.ToString(), employeesTable.Rows[e.RowIndex].Cells[10].FormattedValue.ToString(), employeesTable.Rows[e.RowIndex].Cells[11].FormattedValue.ToString(),
               employeesTable.Rows[e.RowIndex].Cells[12].FormattedValue.ToString(), employeesTable.Rows[e.RowIndex].Cells[13].FormattedValue.ToString(), employeesTable.Rows[e.RowIndex].Cells[14].FormattedValue.ToString());
            editEmployees.Visible = true;
        }
    }
}

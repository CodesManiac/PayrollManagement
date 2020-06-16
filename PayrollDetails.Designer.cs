namespace PayrollManagement
{
    partial class PayrollDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollDetails));
            this.payrollTable = new System.Windows.Forms.DataGridView();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nINumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractualHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractualEarningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeEarningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEarningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIContributionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unionFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeductionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsDataSet = new PayrollManagement.PaymentsDataSet();
            this.paymentsTableAdapter = new PayrollManagement.PaymentsDataSetTableAdapters.PaymentsTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label32 = new System.Windows.Forms.Label();
            this.viewEmployees = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchByEmployeeIDField = new System.Windows.Forms.TextBox();
            this.searchByNINumberField = new System.Windows.Forms.TextBox();
            this.searchByFullNameField = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.searchByPaymentIDField = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchByPayDateField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchPaymentDetail = new System.Windows.Forms.Button();
            this.clearSearch = new System.Windows.Forms.Button();
            this.searchByPayMonthField = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minutesField = new System.Windows.Forms.TextBox();
            this.decimalField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hoursField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollTable
            // 
            this.payrollTable.AllowUserToAddRows = false;
            this.payrollTable.AllowUserToDeleteRows = false;
            this.payrollTable.AllowUserToResizeColumns = false;
            this.payrollTable.AllowUserToResizeRows = false;
            this.payrollTable.AutoGenerateColumns = false;
            this.payrollTable.BackgroundColor = System.Drawing.Color.White;
            this.payrollTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payrollTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.nINumberDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.payPeriodDataGridViewTextBoxColumn,
            this.payMonthDataGridViewTextBoxColumn,
            this.hourlyRateDataGridViewTextBoxColumn,
            this.contractualHoursDataGridViewTextBoxColumn,
            this.overtimeHoursDataGridViewTextBoxColumn,
            this.totalHoursDataGridViewTextBoxColumn,
            this.contractualEarningsDataGridViewTextBoxColumn,
            this.overtimeEarningsDataGridViewTextBoxColumn,
            this.totalEarningsDataGridViewTextBoxColumn,
            this.taxCodeDataGridViewTextBoxColumn,
            this.taxAmountDataGridViewTextBoxColumn,
            this.nIContributionDataGridViewTextBoxColumn,
            this.unionFeeDataGridViewTextBoxColumn,
            this.sLCDataGridViewTextBoxColumn,
            this.totalDeductionsDataGridViewTextBoxColumn,
            this.netPayDataGridViewTextBoxColumn});
            this.payrollTable.DataSource = this.paymentsBindingSource;
            this.payrollTable.Location = new System.Drawing.Point(27, 294);
            this.payrollTable.MultiSelect = false;
            this.payrollTable.Name = "payrollTable";
            this.payrollTable.ReadOnly = true;
            this.payrollTable.Size = new System.Drawing.Size(904, 307);
            this.payrollTable.TabIndex = 0;
            this.payrollTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payrollTable_CellContentClick);
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nINumberDataGridViewTextBoxColumn
            // 
            this.nINumberDataGridViewTextBoxColumn.DataPropertyName = "NINumber";
            this.nINumberDataGridViewTextBoxColumn.HeaderText = "NINumber";
            this.nINumberDataGridViewTextBoxColumn.Name = "nINumberDataGridViewTextBoxColumn";
            this.nINumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate";
            this.payDateDataGridViewTextBoxColumn.HeaderText = "PayDate";
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            this.payDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payPeriodDataGridViewTextBoxColumn
            // 
            this.payPeriodDataGridViewTextBoxColumn.DataPropertyName = "PayPeriod";
            this.payPeriodDataGridViewTextBoxColumn.HeaderText = "PayPeriod";
            this.payPeriodDataGridViewTextBoxColumn.Name = "payPeriodDataGridViewTextBoxColumn";
            this.payPeriodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payMonthDataGridViewTextBoxColumn
            // 
            this.payMonthDataGridViewTextBoxColumn.DataPropertyName = "PayMonth";
            this.payMonthDataGridViewTextBoxColumn.HeaderText = "PayMonth";
            this.payMonthDataGridViewTextBoxColumn.Name = "payMonthDataGridViewTextBoxColumn";
            this.payMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            this.hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "HourlyRate";
            this.hourlyRateDataGridViewTextBoxColumn.HeaderText = "HourlyRate";
            this.hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            this.hourlyRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractualHoursDataGridViewTextBoxColumn
            // 
            this.contractualHoursDataGridViewTextBoxColumn.DataPropertyName = "ContractualHours";
            this.contractualHoursDataGridViewTextBoxColumn.HeaderText = "ContractualHours";
            this.contractualHoursDataGridViewTextBoxColumn.Name = "contractualHoursDataGridViewTextBoxColumn";
            this.contractualHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overtimeHoursDataGridViewTextBoxColumn
            // 
            this.overtimeHoursDataGridViewTextBoxColumn.DataPropertyName = "OvertimeHours";
            this.overtimeHoursDataGridViewTextBoxColumn.HeaderText = "OvertimeHours";
            this.overtimeHoursDataGridViewTextBoxColumn.Name = "overtimeHoursDataGridViewTextBoxColumn";
            this.overtimeHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalHoursDataGridViewTextBoxColumn
            // 
            this.totalHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalHours";
            this.totalHoursDataGridViewTextBoxColumn.HeaderText = "TotalHours";
            this.totalHoursDataGridViewTextBoxColumn.Name = "totalHoursDataGridViewTextBoxColumn";
            this.totalHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractualEarningsDataGridViewTextBoxColumn
            // 
            this.contractualEarningsDataGridViewTextBoxColumn.DataPropertyName = "ContractualEarnings";
            this.contractualEarningsDataGridViewTextBoxColumn.HeaderText = "ContractualEarnings";
            this.contractualEarningsDataGridViewTextBoxColumn.Name = "contractualEarningsDataGridViewTextBoxColumn";
            this.contractualEarningsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overtimeEarningsDataGridViewTextBoxColumn
            // 
            this.overtimeEarningsDataGridViewTextBoxColumn.DataPropertyName = "OvertimeEarnings";
            this.overtimeEarningsDataGridViewTextBoxColumn.HeaderText = "OvertimeEarnings";
            this.overtimeEarningsDataGridViewTextBoxColumn.Name = "overtimeEarningsDataGridViewTextBoxColumn";
            this.overtimeEarningsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalEarningsDataGridViewTextBoxColumn
            // 
            this.totalEarningsDataGridViewTextBoxColumn.DataPropertyName = "TotalEarnings";
            this.totalEarningsDataGridViewTextBoxColumn.HeaderText = "TotalEarnings";
            this.totalEarningsDataGridViewTextBoxColumn.Name = "totalEarningsDataGridViewTextBoxColumn";
            this.totalEarningsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxCodeDataGridViewTextBoxColumn
            // 
            this.taxCodeDataGridViewTextBoxColumn.DataPropertyName = "TaxCode";
            this.taxCodeDataGridViewTextBoxColumn.HeaderText = "TaxCode";
            this.taxCodeDataGridViewTextBoxColumn.Name = "taxCodeDataGridViewTextBoxColumn";
            this.taxCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxAmountDataGridViewTextBoxColumn
            // 
            this.taxAmountDataGridViewTextBoxColumn.DataPropertyName = "TaxAmount";
            this.taxAmountDataGridViewTextBoxColumn.HeaderText = "TaxAmount";
            this.taxAmountDataGridViewTextBoxColumn.Name = "taxAmountDataGridViewTextBoxColumn";
            this.taxAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIContributionDataGridViewTextBoxColumn
            // 
            this.nIContributionDataGridViewTextBoxColumn.DataPropertyName = "NIContribution";
            this.nIContributionDataGridViewTextBoxColumn.HeaderText = "NIContribution";
            this.nIContributionDataGridViewTextBoxColumn.Name = "nIContributionDataGridViewTextBoxColumn";
            this.nIContributionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unionFeeDataGridViewTextBoxColumn
            // 
            this.unionFeeDataGridViewTextBoxColumn.DataPropertyName = "UnionFee";
            this.unionFeeDataGridViewTextBoxColumn.HeaderText = "UnionFee";
            this.unionFeeDataGridViewTextBoxColumn.Name = "unionFeeDataGridViewTextBoxColumn";
            this.unionFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLCDataGridViewTextBoxColumn
            // 
            this.sLCDataGridViewTextBoxColumn.DataPropertyName = "SLC";
            this.sLCDataGridViewTextBoxColumn.HeaderText = "SLC";
            this.sLCDataGridViewTextBoxColumn.Name = "sLCDataGridViewTextBoxColumn";
            this.sLCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDeductionsDataGridViewTextBoxColumn
            // 
            this.totalDeductionsDataGridViewTextBoxColumn.DataPropertyName = "TotalDeductions";
            this.totalDeductionsDataGridViewTextBoxColumn.HeaderText = "TotalDeductions";
            this.totalDeductionsDataGridViewTextBoxColumn.Name = "totalDeductionsDataGridViewTextBoxColumn";
            this.totalDeductionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netPayDataGridViewTextBoxColumn
            // 
            this.netPayDataGridViewTextBoxColumn.DataPropertyName = "NetPay";
            this.netPayDataGridViewTextBoxColumn.HeaderText = "NetPay";
            this.netPayDataGridViewTextBoxColumn.Name = "netPayDataGridViewTextBoxColumn";
            this.netPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.paymentsDataSet;
            // 
            // paymentsDataSet
            // 
            this.paymentsDataSet.DataSetName = "PaymentsDataSet";
            this.paymentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.viewEmployees);
            this.panel3.Location = new System.Drawing.Point(27, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 32);
            this.panel3.TabIndex = 108;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 20);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(265, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(127, 20);
            this.label32.TabIndex = 2;
            this.label32.Text = "/ Edit Employees";
            // 
            // viewEmployees
            // 
            this.viewEmployees.AutoSize = true;
            this.viewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewEmployees.LinkColor = System.Drawing.Color.White;
            this.viewEmployees.Location = new System.Drawing.Point(143, 7);
            this.viewEmployees.Name = "viewEmployees";
            this.viewEmployees.Size = new System.Drawing.Size(125, 20);
            this.viewEmployees.TabIndex = 0;
            this.viewEmployees.TabStop = true;
            this.viewEmployees.Text = "View Employees";
            this.viewEmployees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchByPayMonthField);
            this.groupBox4.Controls.Add(this.searchPaymentDetail);
            this.groupBox4.Controls.Add(this.clearSearch);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.searchByPayDateField);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.searchByEmployeeIDField);
            this.groupBox4.Controls.Add(this.searchByNINumberField);
            this.groupBox4.Controls.Add(this.searchByFullNameField);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.searchByPaymentIDField);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(27, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 237);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Payment";
            // 
            // searchByEmployeeIDField
            // 
            this.searchByEmployeeIDField.Location = new System.Drawing.Point(153, 46);
            this.searchByEmployeeIDField.Name = "searchByEmployeeIDField";
            this.searchByEmployeeIDField.Size = new System.Drawing.Size(166, 26);
            this.searchByEmployeeIDField.TabIndex = 15;
            // 
            // searchByNINumberField
            // 
            this.searchByNINumberField.Location = new System.Drawing.Point(153, 106);
            this.searchByNINumberField.Name = "searchByNINumberField";
            this.searchByNINumberField.Size = new System.Drawing.Size(166, 26);
            this.searchByNINumberField.TabIndex = 14;
            // 
            // searchByFullNameField
            // 
            this.searchByFullNameField.Location = new System.Drawing.Point(153, 76);
            this.searchByFullNameField.Name = "searchByFullNameField";
            this.searchByFullNameField.Size = new System.Drawing.Size(166, 26);
            this.searchByFullNameField.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(17, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "FullName:";
            // 
            // searchByPaymentIDField
            // 
            this.searchByPaymentIDField.Location = new System.Drawing.Point(153, 16);
            this.searchByPaymentIDField.Name = "searchByPaymentIDField";
            this.searchByPaymentIDField.Size = new System.Drawing.Size(166, 26);
            this.searchByPaymentIDField.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(17, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "Employee ID:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(17, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 16);
            this.label22.TabIndex = 8;
            this.label22.Text = "Payment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "NI Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pay Date:";
            // 
            // searchByPayDateField
            // 
            this.searchByPayDateField.Location = new System.Drawing.Point(153, 136);
            this.searchByPayDateField.Name = "searchByPayDateField";
            this.searchByPayDateField.Size = new System.Drawing.Size(166, 26);
            this.searchByPayDateField.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pay Month:";
            // 
            // searchPaymentDetail
            // 
            this.searchPaymentDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.searchPaymentDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPaymentDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchPaymentDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPaymentDetail.ForeColor = System.Drawing.Color.White;
            this.searchPaymentDetail.Location = new System.Drawing.Point(20, 201);
            this.searchPaymentDetail.Name = "searchPaymentDetail";
            this.searchPaymentDetail.Size = new System.Drawing.Size(86, 30);
            this.searchPaymentDetail.TabIndex = 33;
            this.searchPaymentDetail.Text = "Search";
            this.searchPaymentDetail.UseVisualStyleBackColor = false;
            // 
            // clearSearch
            // 
            this.clearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearch.ForeColor = System.Drawing.Color.White;
            this.clearSearch.Location = new System.Drawing.Point(129, 201);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(86, 30);
            this.clearSearch.TabIndex = 34;
            this.clearSearch.Text = "Clear";
            this.clearSearch.UseVisualStyleBackColor = false;
            // 
            // searchByPayMonthField
            // 
            this.searchByPayMonthField.FormattingEnabled = true;
            this.searchByPayMonthField.Location = new System.Drawing.Point(153, 167);
            this.searchByPayMonthField.Name = "searchByPayMonthField";
            this.searchByPayMonthField.Size = new System.Drawing.Size(166, 28);
            this.searchByPayMonthField.TabIndex = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.minutesField);
            this.groupBox1.Controls.Add(this.decimalField);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.hoursField);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 132);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert time to Decimal";
            // 
            // minutesField
            // 
            this.minutesField.Location = new System.Drawing.Point(91, 42);
            this.minutesField.Name = "minutesField";
            this.minutesField.Size = new System.Drawing.Size(51, 26);
            this.minutesField.TabIndex = 15;
            // 
            // decimalField
            // 
            this.decimalField.Location = new System.Drawing.Point(76, 98);
            this.decimalField.Name = "decimalField";
            this.decimalField.Size = new System.Drawing.Size(86, 26);
            this.decimalField.TabIndex = 12;
            this.decimalField.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Decimal:";
            // 
            // hoursField
            // 
            this.hoursField.Location = new System.Drawing.Point(20, 42);
            this.hoursField.Name = "hoursField";
            this.hoursField.Size = new System.Drawing.Size(45, 26);
            this.hoursField.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Minute(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hours:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(189, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = ":";
            // 
            // timeBtn
            // 
            this.timeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.timeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBtn.ForeColor = System.Drawing.Color.White;
            this.timeBtn.Location = new System.Drawing.Point(756, 59);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(175, 59);
            this.timeBtn.TabIndex = 110;
            this.timeBtn.Text = "00:00:00";
            this.timeBtn.UseVisualStyleBackColor = false;
            // 
            // PayrollDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 613);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.payrollTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayrollDetails";
            this.Text = "PayrollDetails";
            this.Load += new System.EventHandler(this.PayrollDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView payrollTable;
        private PaymentsDataSet paymentsDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private PaymentsDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nINumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractualHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimeHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractualEarningsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimeEarningsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEarningsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIContributionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unionFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeductionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.LinkLabel viewEmployees;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchByPayDateField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchByEmployeeIDField;
        private System.Windows.Forms.TextBox searchByNINumberField;
        private System.Windows.Forms.TextBox searchByFullNameField;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox searchByPaymentIDField;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button searchPaymentDetail;
        private System.Windows.Forms.Button clearSearch;
        private System.Windows.Forms.ComboBox searchByPayMonthField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox minutesField;
        private System.Windows.Forms.TextBox decimalField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hoursField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button timeBtn;
    }
}
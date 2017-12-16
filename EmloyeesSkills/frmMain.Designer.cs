namespace EmloyeesSkills
{
    partial class frmMain
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.btnDisplayEmployees = new System.Windows.Forms.Button();
            this.btnOpenConnection = new System.Windows.Forms.Button();
            this.txtConnectionStat = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.btnCloseConnection = new System.Windows.Forms.Button();
            this.grpBxOpenCloseConnection = new System.Windows.Forms.GroupBox();
            this.lblTableEmployees = new System.Windows.Forms.Label();
            this.dataGridViewSkills = new System.Windows.Forms.DataGridView();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblSkillDescription = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnAddSkillDesc = new System.Windows.Forms.Button();
            this.txtChagedDeskription = new System.Windows.Forms.TextBox();
            this.txtSearchForSkill = new System.Windows.Forms.TextBox();
            this.btnSearchForSkill = new System.Windows.Forms.Button();
            this.lblSearchForSkill = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.txtSkillDescription = new System.Windows.Forms.TextBox();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.lblSkillDescr = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmplyeeId = new System.Windows.Forms.TextBox();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.grpBoxAddEmployee = new System.Windows.Forms.GroupBox();
            this.grpBoxSkillSearch = new System.Windows.Forms.GroupBox();
            this.grpBoxAddSkill = new System.Windows.Forms.GroupBox();
            this.txtRefSkills = new System.Windows.Forms.RichTextBox();
            this.grpBoxAddToSkillDescription = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.grpBxOpenCloseConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).BeginInit();
            this.grpBoxAddEmployee.SuspendLayout();
            this.grpBoxSkillSearch.SuspendLayout();
            this.grpBoxAddSkill.SuspendLayout();
            this.grpBoxAddToSkillDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(10, 39);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(458, 134);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            // 
            // btnDisplayEmployees
            // 
            this.btnDisplayEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisplayEmployees.Location = new System.Drawing.Point(154, 179);
            this.btnDisplayEmployees.Name = "btnDisplayEmployees";
            this.btnDisplayEmployees.Size = new System.Drawing.Size(151, 40);
            this.btnDisplayEmployees.TabIndex = 1;
            this.btnDisplayEmployees.Text = "Update Employees Table";
            this.btnDisplayEmployees.UseVisualStyleBackColor = true;
            this.btnDisplayEmployees.Click += new System.EventHandler(this.btnDisplayEmployees_Click);
            // 
            // btnOpenConnection
            // 
            this.btnOpenConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenConnection.Location = new System.Drawing.Point(157, 19);
            this.btnOpenConnection.Name = "btnOpenConnection";
            this.btnOpenConnection.Size = new System.Drawing.Size(81, 38);
            this.btnOpenConnection.TabIndex = 2;
            this.btnOpenConnection.Text = "Open Connection";
            this.btnOpenConnection.UseVisualStyleBackColor = true;
            this.btnOpenConnection.Click += new System.EventHandler(this.btnOpenConnection_Click);
            // 
            // txtConnectionStat
            // 
            this.txtConnectionStat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtConnectionStat.Location = new System.Drawing.Point(36, 37);
            this.txtConnectionStat.Name = "txtConnectionStat";
            this.txtConnectionStat.ReadOnly = true;
            this.txtConnectionStat.Size = new System.Drawing.Size(100, 20);
            this.txtConnectionStat.TabIndex = 3;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(33, 19);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(106, 15);
            this.lblConnectionStatus.TabIndex = 4;
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(937, 756);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 44);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close App";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtConnectionString.Location = new System.Drawing.Point(36, 84);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(420, 20);
            this.txtConnectionString.TabIndex = 6;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConnectionString.Location = new System.Drawing.Point(191, 66);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(104, 15);
            this.lblConnectionString.TabIndex = 7;
            this.lblConnectionString.Text = "Connection String";
            // 
            // txtDataBase
            // 
            this.txtDataBase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDataBase.Location = new System.Drawing.Point(356, 37);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.ReadOnly = true;
            this.txtDataBase.Size = new System.Drawing.Size(100, 20);
            this.txtDataBase.TabIndex = 8;
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDataBase.Location = new System.Drawing.Point(378, 19);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(64, 15);
            this.lblDataBase.TabIndex = 9;
            this.lblDataBase.Text = "Data Base";
            // 
            // btnCloseConnection
            // 
            this.btnCloseConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseConnection.Location = new System.Drawing.Point(257, 19);
            this.btnCloseConnection.Name = "btnCloseConnection";
            this.btnCloseConnection.Size = new System.Drawing.Size(81, 38);
            this.btnCloseConnection.TabIndex = 10;
            this.btnCloseConnection.Text = "Close Connection";
            this.btnCloseConnection.UseVisualStyleBackColor = true;
            this.btnCloseConnection.Click += new System.EventHandler(this.btnCloseConnection_Click);
            // 
            // grpBxOpenCloseConnection
            // 
            this.grpBxOpenCloseConnection.Controls.Add(this.btnCloseConnection);
            this.grpBxOpenCloseConnection.Controls.Add(this.btnOpenConnection);
            this.grpBxOpenCloseConnection.Controls.Add(this.lblDataBase);
            this.grpBxOpenCloseConnection.Controls.Add(this.txtConnectionStat);
            this.grpBxOpenCloseConnection.Controls.Add(this.txtDataBase);
            this.grpBxOpenCloseConnection.Controls.Add(this.lblConnectionStatus);
            this.grpBxOpenCloseConnection.Controls.Add(this.lblConnectionString);
            this.grpBxOpenCloseConnection.Controls.Add(this.txtConnectionString);
            this.grpBxOpenCloseConnection.Location = new System.Drawing.Point(556, 12);
            this.grpBxOpenCloseConnection.Name = "grpBxOpenCloseConnection";
            this.grpBxOpenCloseConnection.Size = new System.Drawing.Size(489, 118);
            this.grpBxOpenCloseConnection.TabIndex = 11;
            this.grpBxOpenCloseConnection.TabStop = false;
            // 
            // lblTableEmployees
            // 
            this.lblTableEmployees.AutoSize = true;
            this.lblTableEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTableEmployees.Location = new System.Drawing.Point(176, 12);
            this.lblTableEmployees.Name = "lblTableEmployees";
            this.lblTableEmployees.Size = new System.Drawing.Size(110, 24);
            this.lblTableEmployees.TabIndex = 12;
            this.lblTableEmployees.Text = "Employees ";
            // 
            // dataGridViewSkills
            // 
            this.dataGridViewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkills.Location = new System.Drawing.Point(10, 252);
            this.dataGridViewSkills.Name = "dataGridViewSkills";
            this.dataGridViewSkills.Size = new System.Drawing.Size(242, 99);
            this.dataGridViewSkills.TabIndex = 13;
            this.dataGridViewSkills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSkills_CellClick);
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkills.Location = new System.Drawing.Point(56, 225);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(143, 24);
            this.lblSkills.TabIndex = 14;
            this.lblSkills.Text = "Employee Skills";
            // 
            // lblSkillDescription
            // 
            this.lblSkillDescription.AutoSize = true;
            this.lblSkillDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkillDescription.Location = new System.Drawing.Point(12, 363);
            this.lblSkillDescription.Name = "lblSkillDescription";
            this.lblSkillDescription.Size = new System.Drawing.Size(159, 24);
            this.lblSkillDescription.TabIndex = 17;
            this.lblSkillDescription.Text = "Skill Description";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Location = new System.Drawing.Point(416, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // txtAlias
            // 
            this.txtAlias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAlias.Location = new System.Drawing.Point(281, 37);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(100, 20);
            this.txtAlias.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLastName.Location = new System.Drawing.Point(152, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFirstName.Location = new System.Drawing.Point(19, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 21;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(159, 16);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 15);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(38, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(446, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAlias.Location = new System.Drawing.Point(310, 16);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(33, 15);
            this.lblAlias.TabIndex = 23;
            this.lblAlias.Text = "Alias";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmployee.Location = new System.Drawing.Point(199, 63);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(152, 40);
            this.btnAddEmployee.TabIndex = 24;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnAddSkillDesc
            // 
            this.btnAddSkillDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSkillDesc.Location = new System.Drawing.Point(58, 73);
            this.btnAddSkillDesc.Name = "btnAddSkillDesc";
            this.btnAddSkillDesc.Size = new System.Drawing.Size(86, 40);
            this.btnAddSkillDesc.TabIndex = 25;
            this.btnAddSkillDesc.Text = "Add ";
            this.btnAddSkillDesc.UseVisualStyleBackColor = true;
            this.btnAddSkillDesc.Click += new System.EventHandler(this.btnAddSkillDesc_Click);
            // 
            // txtChagedDeskription
            // 
            this.txtChagedDeskription.Location = new System.Drawing.Point(14, 14);
            this.txtChagedDeskription.Multiline = true;
            this.txtChagedDeskription.Name = "txtChagedDeskription";
            this.txtChagedDeskription.Size = new System.Drawing.Size(174, 53);
            this.txtChagedDeskription.TabIndex = 26;
            // 
            // txtSearchForSkill
            // 
            this.txtSearchForSkill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearchForSkill.Location = new System.Drawing.Point(28, 30);
            this.txtSearchForSkill.Name = "txtSearchForSkill";
            this.txtSearchForSkill.Size = new System.Drawing.Size(314, 20);
            this.txtSearchForSkill.TabIndex = 11;
            // 
            // btnSearchForSkill
            // 
            this.btnSearchForSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchForSkill.Location = new System.Drawing.Point(27, 56);
            this.btnSearchForSkill.Name = "btnSearchForSkill";
            this.btnSearchForSkill.Size = new System.Drawing.Size(137, 25);
            this.btnSearchForSkill.TabIndex = 27;
            this.btnSearchForSkill.Text = "Search";
            this.btnSearchForSkill.UseVisualStyleBackColor = true;
            this.btnSearchForSkill.Click += new System.EventHandler(this.btnSearchForSkill_Click);
            // 
            // lblSearchForSkill
            // 
            this.lblSearchForSkill.AutoSize = true;
            this.lblSearchForSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchForSkill.Location = new System.Drawing.Point(146, 10);
            this.lblSearchForSkill.Name = "lblSearchForSkill";
            this.lblSearchForSkill.Size = new System.Drawing.Size(72, 15);
            this.lblSearchForSkill.TabIndex = 28;
            this.lblSearchForSkill.Text = "Search Skill";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(204, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 25);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkillName.Location = new System.Drawing.Point(42, 14);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(67, 15);
            this.lblSkillName.TabIndex = 30;
            this.lblSkillName.Text = "Skill Name";
            // 
            // txtSkillDescription
            // 
            this.txtSkillDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSkillDescription.Location = new System.Drawing.Point(159, 84);
            this.txtSkillDescription.Multiline = true;
            this.txtSkillDescription.Name = "txtSkillDescription";
            this.txtSkillDescription.Size = new System.Drawing.Size(154, 68);
            this.txtSkillDescription.TabIndex = 31;
            // 
            // txtSkillName
            // 
            this.txtSkillName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSkillName.Location = new System.Drawing.Point(22, 32);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(100, 20);
            this.txtSkillName.TabIndex = 32;
            // 
            // lblSkillDescr
            // 
            this.lblSkillDescr.AutoSize = true;
            this.lblSkillDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkillDescr.Location = new System.Drawing.Point(191, 66);
            this.lblSkillDescr.Name = "lblSkillDescr";
            this.lblSkillDescr.Size = new System.Drawing.Size(97, 15);
            this.lblSkillDescr.TabIndex = 33;
            this.lblSkillDescr.Text = "Brief Description";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployeeId.Location = new System.Drawing.Point(372, 14);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(72, 15);
            this.lblEmployeeId.TabIndex = 34;
            this.lblEmployeeId.Text = "EmployeeId";
            // 
            // txtEmplyeeId
            // 
            this.txtEmplyeeId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmplyeeId.Location = new System.Drawing.Point(356, 32);
            this.txtEmplyeeId.Name = "txtEmplyeeId";
            this.txtEmplyeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmplyeeId.TabIndex = 35;
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSkill.Location = new System.Drawing.Point(177, 166);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(123, 28);
            this.btnAddSkill.TabIndex = 36;
            this.btnAddSkill.Text = "Add Skill";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtURL.Location = new System.Drawing.Point(137, 32);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(193, 20);
            this.txtURL.TabIndex = 37;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblURL.Location = new System.Drawing.Point(222, 14);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 15);
            this.lblURL.TabIndex = 38;
            this.lblURL.Text = "URL";
            // 
            // grpBoxAddEmployee
            // 
            this.grpBoxAddEmployee.Controls.Add(this.btnAddEmployee);
            this.grpBoxAddEmployee.Controls.Add(this.txtEmail);
            this.grpBoxAddEmployee.Controls.Add(this.txtAlias);
            this.grpBoxAddEmployee.Controls.Add(this.txtLastName);
            this.grpBoxAddEmployee.Controls.Add(this.txtFirstName);
            this.grpBoxAddEmployee.Controls.Add(this.lblFirstName);
            this.grpBoxAddEmployee.Controls.Add(this.lblLastName);
            this.grpBoxAddEmployee.Controls.Add(this.lblEmail);
            this.grpBoxAddEmployee.Controls.Add(this.lblAlias);
            this.grpBoxAddEmployee.Location = new System.Drawing.Point(507, 252);
            this.grpBoxAddEmployee.Name = "grpBoxAddEmployee";
            this.grpBoxAddEmployee.Size = new System.Drawing.Size(531, 107);
            this.grpBoxAddEmployee.TabIndex = 39;
            this.grpBoxAddEmployee.TabStop = false;
            this.grpBoxAddEmployee.Text = "Add Employee";
            // 
            // grpBoxSkillSearch
            // 
            this.grpBoxSkillSearch.Controls.Add(this.txtSearchForSkill);
            this.grpBoxSkillSearch.Controls.Add(this.btnSearchForSkill);
            this.grpBoxSkillSearch.Controls.Add(this.lblSearchForSkill);
            this.grpBoxSkillSearch.Controls.Add(this.btnClear);
            this.grpBoxSkillSearch.Location = new System.Drawing.Point(42, 704);
            this.grpBoxSkillSearch.Name = "grpBoxSkillSearch";
            this.grpBoxSkillSearch.Size = new System.Drawing.Size(370, 96);
            this.grpBoxSkillSearch.TabIndex = 40;
            this.grpBoxSkillSearch.TabStop = false;
            this.grpBoxSkillSearch.Text = "Search Skill";
            // 
            // grpBoxAddSkill
            // 
            this.grpBoxAddSkill.Controls.Add(this.txtSkillDescription);
            this.grpBoxAddSkill.Controls.Add(this.lblSkillName);
            this.grpBoxAddSkill.Controls.Add(this.txtSkillName);
            this.grpBoxAddSkill.Controls.Add(this.lblURL);
            this.grpBoxAddSkill.Controls.Add(this.lblSkillDescr);
            this.grpBoxAddSkill.Controls.Add(this.txtURL);
            this.grpBoxAddSkill.Controls.Add(this.lblEmployeeId);
            this.grpBoxAddSkill.Controls.Add(this.btnAddSkill);
            this.grpBoxAddSkill.Controls.Add(this.txtEmplyeeId);
            this.grpBoxAddSkill.Location = new System.Drawing.Point(533, 432);
            this.grpBoxAddSkill.Name = "grpBoxAddSkill";
            this.grpBoxAddSkill.Size = new System.Drawing.Size(473, 201);
            this.grpBoxAddSkill.TabIndex = 41;
            this.grpBoxAddSkill.TabStop = false;
            this.grpBoxAddSkill.Text = "Add Skill";
            // 
            // txtRefSkills
            // 
            this.txtRefSkills.Location = new System.Drawing.Point(10, 391);
            this.txtRefSkills.Name = "txtRefSkills";
            this.txtRefSkills.Size = new System.Drawing.Size(458, 303);
            this.txtRefSkills.TabIndex = 42;
            this.txtRefSkills.Text = "";
            this.txtRefSkills.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtRefSkills_LinkClicked);
            // 
            // grpBoxAddToSkillDescription
            // 
            this.grpBoxAddToSkillDescription.Controls.Add(this.btnAddSkillDesc);
            this.grpBoxAddToSkillDescription.Controls.Add(this.txtChagedDeskription);
            this.grpBoxAddToSkillDescription.Location = new System.Drawing.Point(268, 246);
            this.grpBoxAddToSkillDescription.Name = "grpBoxAddToSkillDescription";
            this.grpBoxAddToSkillDescription.Size = new System.Drawing.Size(200, 123);
            this.grpBoxAddToSkillDescription.TabIndex = 43;
            this.grpBoxAddToSkillDescription.TabStop = false;
            this.grpBoxAddToSkillDescription.Text = "Add To Current Employee Skill ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 812);
            this.Controls.Add(this.grpBoxAddToSkillDescription);
            this.Controls.Add(this.txtRefSkills);
            this.Controls.Add(this.grpBoxAddSkill);
            this.Controls.Add(this.grpBoxSkillSearch);
            this.Controls.Add(this.grpBoxAddEmployee);
            this.Controls.Add(this.lblSkillDescription);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.dataGridViewSkills);
            this.Controls.Add(this.lblTableEmployees);
            this.Controls.Add(this.grpBxOpenCloseConnection);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplayEmployees);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "frmMain";
            this.Text = "Employees and Skills Data";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.grpBxOpenCloseConnection.ResumeLayout(false);
            this.grpBxOpenCloseConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).EndInit();
            this.grpBoxAddEmployee.ResumeLayout(false);
            this.grpBoxAddEmployee.PerformLayout();
            this.grpBoxSkillSearch.ResumeLayout(false);
            this.grpBoxSkillSearch.PerformLayout();
            this.grpBoxAddSkill.ResumeLayout(false);
            this.grpBoxAddSkill.PerformLayout();
            this.grpBoxAddToSkillDescription.ResumeLayout(false);
            this.grpBoxAddToSkillDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button btnDisplayEmployees;
        private System.Windows.Forms.Button btnOpenConnection;
        private System.Windows.Forms.TextBox txtConnectionStat;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Button btnCloseConnection;
        private System.Windows.Forms.GroupBox grpBxOpenCloseConnection;
        private System.Windows.Forms.Label lblTableEmployees;
        private System.Windows.Forms.DataGridView dataGridViewSkills;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblSkillDescription;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddSkillDesc;
        private System.Windows.Forms.TextBox txtChagedDeskription;
        private System.Windows.Forms.TextBox txtSearchForSkill;
        private System.Windows.Forms.Button btnSearchForSkill;
        private System.Windows.Forms.Label lblSearchForSkill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.TextBox txtSkillDescription;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.Label lblSkillDescr;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmplyeeId;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.GroupBox grpBoxAddEmployee;
        private System.Windows.Forms.GroupBox grpBoxSkillSearch;
        private System.Windows.Forms.GroupBox grpBoxAddSkill;
        private System.Windows.Forms.RichTextBox txtRefSkills;
        private System.Windows.Forms.GroupBox grpBoxAddToSkillDescription;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmloyeesSkills
{

    public partial class frmMain : Form
    {
        private string connectString = @"Data Source=OLEGLIVCHA\SQLEXPRESS;Initial Catalog=SkilledEmployees;Integrated Security=True";

        private SqlDataReader reader;
        private SqlConnection sqlConnect;
        private DataTable tmpTable;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.sqlConnect = new SqlConnection();
            ShowConnectionStatus();

            this.txtRefSkills.BackColor = Color.LightBlue;
            this.txtRefSkills.ForeColor = Color.Black;
        }

        #region Open or Close Connection
        private void btnOpenConnection_Click(object sender, EventArgs e)
        {
            this.sqlConnect.ConnectionString = this.connectString;

            try
            {
                sqlConnect.Open();
                ShowConnectionStatus();
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseConnection_Click(object sender, EventArgs e)
        {
            this.sqlConnect.Close();
            ShowConnectionStatus();
        }

        private void ShowConnectionStatus()
        {
            if (this.sqlConnect.State.ToString() == "Closed")
            {
                this.txtConnectionStat.BackColor = Color.Red;
                this.txtConnectionStat.ForeColor = Color.Black;
                this.txtConnectionStat.Text = this.sqlConnect.State.ToString();
                this.txtDataBase.Text = "Unknown";
                this.txtConnectionString.Text = "Unknown";
            }
            else
            {
                this.txtConnectionStat.BackColor = Color.Green;
                this.txtConnectionStat.ForeColor = Color.White;
                this.txtConnectionStat.Text = this.sqlConnect.State.ToString();
                this.txtDataBase.Text = this.sqlConnect.Database.ToString();
                this.txtConnectionString.Text = this.sqlConnect.ConnectionString.ToString();
            }
        }
        #endregion

        #region Updating Tables
        /// <summary>
        /// Updating Employees Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayEmployees_Click(object sender, EventArgs e)
        {
            string sqlQuerie = "SELECT LastName,FirstName,Alias,Email FROM [dbo].[Employees]";
            bool flag = false;

            this.tmpTable = new DataTable();

            using (SqlCommand cmd = new SqlCommand(sqlQuerie, this.sqlConnect))
            {

                try
                {
                    this.reader = cmd.ExecuteReader();
                    flag = true;

                    this.tmpTable.Load(reader, LoadOption.OverwriteChanges);
                }
                catch (Exception ex)
                {
                    System.Media.SystemSounds.Beep.Play();

                    if (this.sqlConnect.State.ToString() == "Closed") MessageBox.Show("Connection must be opened first !!!");
                    else MessageBox.Show(ex.Message);
                }

                if (flag) this.reader.Close();
                this.dataGridViewEmployees.DataSource = this.tmpTable;
            }
        }
        /// <summary>
        /// Updating Skills Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tmpTable = new DataTable();

            string sqlQuery = "SELECT SkillName,BriefDescription FROM [dbo].[Skills] JOIN [dbo].[Employees] ON ([dbo].[Skills].EmployeeId) = [dbo].[Employees].EmployeeId WHERE [dbo].[Employees].LastName = @LastName";
            bool flag = false;

            using (SqlCommand cmd = new SqlCommand(sqlQuery, this.sqlConnect))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@LastName";
                param.Value = this.dataGridViewEmployees.CurrentCell.Value;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                try
                {
                    this.reader = cmd.ExecuteReader();
                    flag = true;
                    this.tmpTable.Load(this.reader, LoadOption.OverwriteChanges);

                }
                catch (Exception ex)
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show(ex.Message);
                }

                if (flag) this.reader.Close();
                this.dataGridViewSkills.DataSource = this.tmpTable;
            }
        }
        #endregion

        #region Updating Skill Description Text Box
        /// <summary>
        /// Updating Skills Description TextBox depending on current Cell on Skills Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSkills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tmpTable = new DataTable();

            string sqlQuery = "SELECT DISTINCT(BriefDescription),SkillName,URL FROM [dbo].[Skills]" +
                "JOIN [dbo].[SkillsInfo] ON ([dbo].[SkillsInfo].Skillid = [dbo].[Skills].Skillid) WHERE [dbo].[Skills].SkillName = @SkillName";

            bool flag = false;

            using (SqlCommand cmd = new SqlCommand(sqlQuery, this.sqlConnect))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@SkillName";
                param.Value = this.dataGridViewSkills.CurrentCell.Value;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                try
                {
                    this.reader = cmd.ExecuteReader();
                    flag = true;
                    this.tmpTable.Load(this.reader);
                }
                catch (Exception ex)
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show(ex.Message);
                }

                if (flag) this.reader.Close();
                FillingSkillDescriptionTextBox(this.tmpTable);
                
            }
        }
        /// <summary>
        /// Updating Skills Description TextBox using search TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchForSkill_Click(object sender, EventArgs e)
        {
            this.tmpTable = new DataTable();
            bool flag = false;

            using (SqlCommand cmd = new SqlCommand("Search_For_Skill_By_Word",this.sqlConnect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@word";
                param.Value = this.txtSearchForSkill.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                try
                {
                    this.reader = cmd.ExecuteReader();
                    flag = true;
                    this.tmpTable.Load(this.reader, LoadOption.OverwriteChanges);
                }
                catch (Exception ex)
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show(ex.Message);
                }

                if (flag) this.reader.Close();
                FillingSkillDescriptionTextBox(this.tmpTable);          
            }
        }
        /// <summary>
        /// Method that filling Skill Description TextBox by getting DataTable obj
        /// </summary>
        /// <param name="dt"></param>
        private void FillingSkillDescriptionTextBox(DataTable dt)
        {
            try
            {
                this.txtRefSkills.Text = string.Format("[Skill Name] : {1} \r\n\r\n[Description] : {0} \r\n\r\n[Skill Info] : {2}",
                    dt.Rows[0][0], dt.Rows[0][1], dt.Rows[0][2]);
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Folowing to website by clicking on link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRefSkills_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        /// <summary>
        /// Clearing Skill Search Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSearchForSkill.Text = string.Empty;
        }
        #endregion

        #region Adding Rows To Table
        /// <summary>
        /// Adding employee to Employees table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.tmpTable = new DataTable();

            string sqlQuery = "INSERT INTO [dbo].[Employees] (LastName,FirstName,Alias,Email) VALUES (@LastName,@FirstName,@Alias,@Email)";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, this.sqlConnect))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@LastName";
                param.Value = this.txtLastName.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@FirstName";
                param.Value = this.txtFirstName.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Alias";
                param.Value = this.txtAlias.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Email";
                param.Value = this.txtEmail.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                btnDisplayEmployees_Click(new Object(),EventArgs.Empty); //Updating table on the fly
            }           
        }
        /// <summary>
        /// Adding skill to Skills Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            int skillId;

            //Inserting new skill into SkillsTable
            using (SqlCommand cmd = new SqlCommand("Add_Skill",this.sqlConnect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@SkillName";
                param.Value = this.txtSkillName.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@BriefDescription";
                param.Value = this.txtSkillDescription.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "EmployeeId";
                param.Value = this.txtEmplyeeId.Text;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();               
            }

            //Getting added skill id
            using (SqlCommand cmd = new SqlCommand("Get_Skill_Id", this.sqlConnect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@SkillName";
                param.Value = this.txtSkillName.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                param.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@SkillId";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                skillId = int.Parse(cmd.Parameters["@SkillId"].Value.ToString());
            }
                //Inserting row into SkillInfo Table
                using (SqlCommand cmd = new SqlCommand("Insert_Skill_Info",this.sqlConnect))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter param  = new SqlParameter();
                    param.ParameterName = "@SkillId";
                    param.Value = skillId;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@URL";
                    param.Value = this.txtURL.Text;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                }

            btnDisplayEmployees_Click(new Object(), EventArgs.Empty); //Updating table on the fly       
        }
        #endregion

        #region Adding Text To Current Skill Description
        private void btnAddSkillDesc_Click(object sender, EventArgs e)
        {
            string currentText = string.Empty;
            string sqlQuery = "UPDATE [dbo].[Skills] SET BriefDescription = @BriefDescription WHERE SkillName = @SkillName";
            
            //Getting current "BriefDescription" text
            using (SqlCommand cmd = new SqlCommand("GET_Skill_Description",this.sqlConnect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@SkillName";
                param.Value = this.dataGridViewSkills.CurrentCell.Value;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                param.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@BriefDescription";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 1000000;//Random max number
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                currentText = (cmd.Parameters["@BriefDescription"].Value).ToString();
            }

            //Updating current Description Text
            using (SqlCommand cmd = new SqlCommand(sqlQuery, this.sqlConnect)) 
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@SkillName";
                param.Value = this.dataGridViewSkills.CurrentCell.Value;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@BriefDescription";
                param.Value = currentText + this.txtChagedDeskription.Text;
                param.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                btnDisplayEmployees_Click(new Object(), EventArgs.Empty); //Updating table on the fly 
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}


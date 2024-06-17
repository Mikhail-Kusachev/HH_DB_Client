using System;
using System.CodeDom;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WorkingWithDB
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=localhost;Database=hhdb;" +
            "Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void UpdateForm()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapterCompanies = new SqlDataAdapter("SELECT * FROM [COMPANIES]", sqlConnection);
            DataTable dataTableCompanies = new DataTable();
            sqlDataAdapterCompanies.Fill(dataTableCompanies);
            dataGridView1.DataSource = dataTableCompanies;

            SqlDataAdapter sqlDataAdapterEmployees = new SqlDataAdapter("SELECT * FROM [EMPLOYEES]", sqlConnection);
            DataTable dataTableEmployees = new DataTable();
            sqlDataAdapterEmployees.Fill(dataTableEmployees);
            dataGridView2.DataSource = dataTableEmployees;

            SqlDataAdapter sqlDataAdapterConnections = new SqlDataAdapter(
                "SELECT EMPLOYEES.FIRST_NAME, EMPLOYEES.SURNAME, COMPANIES.COMPANY_NAME FROM EMPLOYEES " +
                "LEFT JOIN COMPANIES ON COMPANIES.ID = EMPLOYEES.COMPANY_ID",
                sqlConnection);
            DataTable dataTableConnections = new DataTable();
            sqlDataAdapterConnections.Fill(dataTableConnections);
            dataGridView3.DataSource = dataTableConnections;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            textBox13.Text = workingDirectory + "\\hhdb_companies.csv";
            textBox15.Text = workingDirectory + "\\hhdb_employees.csv";
            textBox12.Text = workingDirectory + "\\hhdb_companies.csv";
            textBox14.Text = workingDirectory + "\\hhdb_employees.csv";
            UpdateForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            MessageBox.Show("Application exit", "Information");
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                SqlCommand sqlCommand = new SqlCommand(
                    "INSERT INTO [COMPANIES] (COMPANY_NAME, INN, REGISTRATION_ADDRESS, OPERATIONAL_ADDRESS) " +
                    "VALUES(@COMPANY_NAME, @INN, @REGISTRATION_ADDRESS, @OPERATIONAL_ADDRESS)", sqlConnection);
                textBox1.Text = textBox1.Text.Replace(",", "");
                textBox2.Text = textBox2.Text.Replace(",", "");
                textBox3.Text = textBox3.Text.Replace(",", ";");
                textBox4.Text = textBox4.Text.Replace(",", ";");
                sqlCommand.Parameters.AddWithValue("COMPANY_NAME", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("INN", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("REGISTRATION_ADDRESS", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("OPERATIONAL_ADDRESS", textBox4.Text);
                await sqlCommand.ExecuteNonQueryAsync();
                MessageBox.Show($"Company with INN {textBox2.Text} successfully  added", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                UpdateForm();
            }
            else
            {
                MessageBox.Show("error", "input data format error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "I was out of time, this is concept so far\r\nThis is not user ready or finished application", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            //make method()
            ////////////////////////////////////////////////////////////////////////////////////////////
            string companyINN = textBox11.Text;
            SqlDataReader sqlReader = null;
            string companyID = "";
            SqlCommand sqlCommandGetINN = new SqlCommand($"SELECT ID FROM [COMPANIES] WHERE COMPANIES.INN={companyINN}",
                sqlConnection);
            try
            {
                sqlReader = await sqlCommandGetINN.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    companyID += Convert.ToString(sqlReader["ID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

            if (companyID == "")
            {
                MessageBox.Show($"couldn't find the company with INN {textBox11.Text}", "Information");
                return;
            }

            if (!IsNullOrEmptyOrSpace(new List<string>()
                {
                    textBox6.Text, textBox9.Text, textBox8.Text, textBox7.Text, textBox5.Text, textBox10.Text,
                    textBox11.Text
                }))
            {
                SqlCommand sqlCommand = new SqlCommand(
                    "INSERT INTO [EMPLOYEES] (FIRST_NAME, MIDDLE_NAME, SURNAME, BIRTH_DATE, PASSPORT_SERIES," +
                    "PASSPORT_NUMBER, COMPANY_ID) VALUES(@FIRST_NAME, @MIDDLE_NAME, @SURNAME, @BIRTH_DATE," +
                    "@PASSPORT_SERIES, @PASSPORT_NUMBER, @COMPANY_ID)",
                    sqlConnection);
                textBox6.Text = textBox6.Text.Replace(",", "");
                textBox9.Text = textBox9.Text.Replace(",", "");
                textBox8.Text = textBox8.Text.Replace(",", "");
                textBox7.Text = textBox7.Text.Replace(",", "");
                textBox5.Text = textBox5.Text.Replace(",", "");
                textBox10.Text = textBox10.Text.Replace(",", "");
                sqlCommand.Parameters.AddWithValue("FIRST_NAME", textBox6.Text);
                sqlCommand.Parameters.AddWithValue("MIDDLE_NAME", textBox9.Text);
                sqlCommand.Parameters.AddWithValue("SURNAME", textBox8.Text);
                sqlCommand.Parameters.AddWithValue("BIRTH_DATE", textBox7.Text);
                sqlCommand.Parameters.AddWithValue("PASSPORT_SERIES", textBox5.Text);
                sqlCommand.Parameters.AddWithValue("PASSPORT_NUMBER", textBox10.Text);
                sqlCommand.Parameters.AddWithValue("COMPANY_ID", companyID);
                try
                {
                    await sqlCommand.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    if (ex.Message.ToString().Contains("Violation of UNIQUE KEY constraint"))
                        MessageBox.Show(
                            $"The employee with the passport {textBox5.Text} {textBox10.Text} already exists",
                            "Information");
                    else
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show($"EMPLOYEE with PASSPORT {textBox5.Text} {textBox10.Text} successfully  added",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox6.Clear();
                textBox9.Clear();
                textBox8.Clear();
                textBox7.Text = "1999-12-31";
                textBox5.Clear();
                textBox10.Clear();
                textBox11.Clear();
                UpdateForm();
            }
            else
            {
                MessageBox.Show("error", "input data format error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM COMPANIES", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            string fileName = textBox13.Text;
            StreamWriter sw = new StreamWriter(fileName);
            object[] output = new object[reader.FieldCount];
            for (int i = 0; i < reader.FieldCount; i++)
                output[i] = reader.GetName(i);
            sw.WriteLine(string.Join(",", output));
            while (reader.Read())
            {
                reader.GetValues(output);
                sw.WriteLine(string.Join(",", output));
            }

            sw.Close();
            reader.Close();
            sqlCon.Close();
            MessageBox.Show("COMPANIES exported", "information");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //SqlCommand sqlCommand = new SqlCommand("DELETE FROM [COMPANIES]", sqlConnection);
            //await sqlCommand.ExecuteNonQueryAsync();
            SqlCommand sqlCommand = new SqlCommand("DROP TABLE [EMPLOYEES]", sqlConnection);
            await sqlCommand.ExecuteNonQueryAsync();
            sqlCommand = new SqlCommand("DROP TABLE [COMPANIES]", sqlConnection);
            await sqlCommand.ExecuteNonQueryAsync();
            sqlCommand =
                new SqlCommand(
                    "CREATE TABLE COMPANIES (ID INT PRIMARY KEY IDENTITY, COMPANY_NAME TEXT NOT NULL, " +
                    "INN BIGINT UNIQUE, REGISTRATION_ADDRESS TEXT NOT NULL, OPERATIONAL_ADDRESS TEXT NOT NULL)",
                    sqlConnection);
            await sqlCommand.ExecuteNonQueryAsync();
            sqlCommand = new SqlCommand(
                "CREATE TABLE EMPLOYEES (ID INT PRIMARY KEY IDENTITY, FIRST_NAME TEXT NOT NULL, MIDDLE_NAME " +
                "TEXT NULL, SURNAME TEXT NOT NULL, BIRTH_DATE DATE NOT NULL, PASSPORT_SERIES INT, PASSPORT_NUMBER " +
                "INT, UNIQUE(PASSPORT_SERIES, PASSPORT_NUMBER), COMPANY_ID INT REFERENCES COMPANIES(ID))",
                sqlConnection);
            await sqlCommand.ExecuteNonQueryAsync();
            string csv_file_path = textBox12.Text;
            string tableName = "COMPANIES";
            DataTable csvData = GetDataTabletFromCSVFile(csv_file_path);
            InsertDataIntoSQLServerUsingSQLBulkCopy(csvData, tableName);
            MessageBox.Show("COMPANIES successfully imported\r\nEMPLOYEES erased and need import", "Information");
            UpdateForm();
        }

        static void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData, string tableName)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    s.DestinationTableName = tableName;
                    foreach (var column in csvFileData.Columns)
                        s.ColumnMappings.Add(column.ToString(), column.ToString());
                    s.WriteToServer(csvFileData);
                }
            }
        }

        private bool IsNullOrEmptyOrSpace(List<string> listInput)
        {
            bool result = false;
            foreach (string input in listInput)
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                    result = true;
            return result;
        }

        private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }

                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return csvData;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //copy paste - should be method()
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM EMPLOYEES", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            string fileName = textBox15.Text;
            StreamWriter sw = new StreamWriter(fileName);
            object[] output = new object[reader.FieldCount];
            for (int i = 0; i < reader.FieldCount; i++)
                output[i] = reader.GetName(i);
            sw.WriteLine(string.Join(",", output));
            while (reader.Read())
            {
                reader.GetValues(output);
                sw.WriteLine(string.Join(",", output));
            }

            sw.Close();
            reader.Close();
            sqlCon.Close();
            MessageBox.Show("EMPLOYEES exported", "information");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //SqlCommand sqlCommand = new SqlCommand("DELETE FROM [EMPLOYEES]", sqlConnection);
            //await sqlCommand.ExecuteNonQueryAsync();
            SqlCommand sqlCommand = new SqlCommand("DROP TABLE [EMPLOYEES]", sqlConnection);
            await sqlCommand.ExecuteNonQueryAsync();
            sqlCommand = new SqlCommand(
                "CREATE TABLE EMPLOYEES (ID INT PRIMARY KEY IDENTITY, FIRST_NAME TEXT NOT NULL, MIDDLE_NAME " +
                "TEXT NULL, SURNAME TEXT NOT NULL, BIRTH_DATE DATE NOT NULL, PASSPORT_SERIES INT, PASSPORT_NUMBER " +
                "INT, UNIQUE(PASSPORT_SERIES, PASSPORT_NUMBER), COMPANY_ID INT REFERENCES COMPANIES(ID))",
                sqlConnection);
            await sqlCommand.ExecuteNonQueryAsync();
            string csv_file_path = textBox14.Text;
            string tableName = "EMPLOYEES";
            DataTable csvData = GetDataTabletFromCSVFile(csv_file_path);
            InsertDataIntoSQLServerUsingSQLBulkCopy(csvData, tableName);
            UpdateForm();
        }
    }
}
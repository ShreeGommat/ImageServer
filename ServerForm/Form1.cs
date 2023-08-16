using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForm
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
           
            string value1 = IpAddressBox.Text;
            string value2 = FolderPathBox.Text;
            int value3 = (int)HeartBeatBox.Value;
            int value4 = (int)CaptureIntervalBox.Value;
            int value5 = (int)AutoResolveBox.Value;
            int value6 = (int)TimeoutBox.Value;
            string value7 = EmailAddBox.Text;
            string value8 = ADBox.Text;

            
            InsertDataIntoDatabase(value1, value2, value3, value4, value5, value6, value7, value8);

            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]; 
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        private void InsertDataIntoDatabase( string value1, string value2, int value3, int value4, int value5, int value6, string value7, string value8)
        {
            string query = "INSERT INTO WINFORM.dbo.ConfigSettings (ServerIPAddr, ConfigDestFolderPath, ConfigHeartbeatInterval,ConfigCaptureInterval,ConfigCommIssueAutoResolveWindow, ConfigIdleTimeout, ConfigAdminEmailAddr, ConfigAdminADGroups) " +
                           "VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@Value1", value1);
                command.Parameters.AddWithValue("@Value2", value2);
                command.Parameters.AddWithValue("@Value3", value3);
                command.Parameters.AddWithValue("@Value4", value4);
                command.Parameters.AddWithValue("@Value5", value5);
                command.Parameters.AddWithValue("@Value6", value6);
                command.Parameters.AddWithValue("@Value7", value7);
                command.Parameters.AddWithValue("@Value8", value8);

                command.ExecuteNonQuery();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    FolderPathBox.Text = folderDialog.SelectedPath; 
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UKZN_Howard_Clinic_Management_System
{
    public partial class AppointmentUI : Form
    {
        public AppointmentUI()
        {
            InitializeComponent();
            displayPatientsWithAppointments();
        }

        private void AppointmentUI_Load(object sender, EventArgs e)
        {

        }

        //DISPLAY PATIENTS
        public void displayPatientsWithAppointments()
        {
            string connectionString = @"Data Source=146.230.177.46;Initial Catalog=G15Wst2024;User ID=G15Wst2024;Password=7hqx0";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Patient_DB", sqlConnection);
                DataTable databaseTable = new DataTable();
                sqlAdapter.Fill(databaseTable);

                dataGridView1.DataSource = databaseTable;
            }
        }
    }
}

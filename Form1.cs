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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayPatients();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void fiildataGridView()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            myForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                if((e.Value != DBNull.Value))
                {
                    bool binary = Convert.ToBoolean(e.Value);
                    if(binary == true)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(242, 56, 199); 
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(63, 135, 186);
                    }
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(i%2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Firebrick;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        //DISPLAY PATIENTS
        public void displayPatients()
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

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Patient myPatients = new Patient();
            myPatients.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AppointmentUI appointments = new AppointmentUI();
            appointments.Show();
            this.Hide();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

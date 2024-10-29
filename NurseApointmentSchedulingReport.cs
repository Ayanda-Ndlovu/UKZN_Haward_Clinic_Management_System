using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKZN_Howard_Clinic_Management_System
{
    public partial class NurseApointmentSchedulingReport : Form
    {
        public NurseApointmentSchedulingReport()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NurseApointmentSchedulingReport_Load(object sender, EventArgs e)
        {
            appointmentTA.Fill(ds1.AppointmentTableDB);
            patientTA.Fill(ds1.PatientTableDB);
            staffTA.Fill(ds1.StaffTableDB);
            appointmentSchedingReport1.SetDataSource(ds1);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            appointmentSchedingReport1.SetParameterValue("StaffName",textBox1.Text);
            crv.ReportSource = appointmentSchedingReport1;
            crv.Refresh();
        }
    }
}

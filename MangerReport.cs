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
    public partial class MangerReport : Form
    {
        public MangerReport()
        {
            InitializeComponent();
        }


        private void MangerReport_Load(object sender, EventArgs e)
        {
            clinicInventoryTA.Fill(supplierInventoryDS1.ClinicInventoryDB);
            supplierTA.Fill(supplierInventoryDS1.SupplierDB);
            inventorySupplierReport1.SetDataSource(supplierInventoryDS1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            inventorySupplierReport1.SetParameterValue("ProductID",51);
            crystalReportViewer1.ReportSource = inventorySupplierReport1;
            crystalReportViewer1.Refresh();
        }
    }
}

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
    public partial class InventorySummaryReport : Form
    {
        public InventorySummaryReport()
        {
            InitializeComponent();
        }

        private void InventorySummaryReport_Load(object sender, EventArgs e)
        {
            clinicInventoryTA.Fill(inventorySupplierDS1.ClinicInventoryDB);
            supplierTA.Fill(inventorySupplierDS1.SupplierDB);
            inventorySupplierReport1.SetDataSource(inventorySupplierDS1);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            inventorySupplierReport1.SetParameterValue("ProductID", 0);
            inventorySupplierReport1.SetParameterValue("ProductName",txtProduct.Text);
            crystalReportViewer1.ReportSource = inventorySupplierReport1;
            crystalReportViewer1.Refresh();

        }

        private void inventorySupplierReport1_InitReport(object sender, EventArgs e)
        {

        }

        private void btnAllReport_Click(object sender, EventArgs e)
        {
            inventorySupplierReport1.SetParameterValue("ProductName", "");
            inventorySupplierReport1.SetParameterValue("ProductID", 51);
            crystalReportViewer1.ReportSource = inventorySupplierReport1;
            crystalReportViewer1.Refresh();
        }
    }
}

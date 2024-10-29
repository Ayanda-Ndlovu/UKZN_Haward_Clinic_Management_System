
namespace UKZN_Howard_Clinic_Management_System
{
    partial class InventorySummaryReport
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
            this.inventorySupplierDS1 = new UKZN_Howard_Clinic_Management_System.InventorySupplierDS();
            this.clinicInventoryTA = new UKZN_Howard_Clinic_Management_System.InventorySupplierDSTableAdapters.ClinicInventoryDBTableAdapter();
            this.supplierTA = new UKZN_Howard_Clinic_Management_System.InventorySupplierDSTableAdapters.SupplierDBTableAdapter();
            this.btnReport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.inventorySupplierReport1 = new UKZN_Howard_Clinic_Management_System.InventorySupplierReport();
            this.btnAllReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySupplierDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventorySupplierDS1
            // 
            this.inventorySupplierDS1.DataSetName = "InventorySupplierDS";
            this.inventorySupplierDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicInventoryTA
            // 
            this.clinicInventoryTA.ClearBeforeFill = true;
            // 
            // supplierTA
            // 
            this.supplierTA.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(477, 23);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(131, 23);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtProduct
            // 
            this.txtProduct.AutoSize = true;
            this.txtProduct.Location = new System.Drawing.Point(163, 28);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(103, 13);
            this.txtProduct.TabIndex = 2;
            this.txtProduct.Text = "Enter Product Name";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 52);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 398);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // inventorySupplierReport1
            // 
            this.inventorySupplierReport1.InitReport += new System.EventHandler(this.inventorySupplierReport1_InitReport);
            // 
            // btnAllReport
            // 
            this.btnAllReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllReport.Location = new System.Drawing.Point(640, 23);
            this.btnAllReport.Name = "btnAllReport";
            this.btnAllReport.Size = new System.Drawing.Size(131, 23);
            this.btnAllReport.TabIndex = 4;
            this.btnAllReport.Text = "Generate All Report";
            this.btnAllReport.UseVisualStyleBackColor = true;
            this.btnAllReport.Click += new System.EventHandler(this.btnAllReport_Click);
            // 
            // InventorySummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAllReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InventorySummaryReport";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.InventorySummaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventorySupplierDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventorySupplierDS inventorySupplierDS1;
        private InventorySupplierDSTableAdapters.ClinicInventoryDBTableAdapter clinicInventoryTA;
        private InventorySupplierDSTableAdapters.SupplierDBTableAdapter supplierTA;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtProduct;
        private InventorySupplierReport inventorySupplierReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnAllReport;
    }
}
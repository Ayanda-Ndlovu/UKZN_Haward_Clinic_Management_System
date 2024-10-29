
namespace UKZN_Howard_Clinic_Management_System
{
    partial class MangerReport
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
            this.button1 = new System.Windows.Forms.Button();
            this.supplierInventoryDS1 = new UKZN_Howard_Clinic_Management_System.SupplierInventoryDS();
            this.clinicInventoryTA = new UKZN_Howard_Clinic_Management_System.SupplierInventoryDSTableAdapters.ClinicInventoryDBTableAdapter();
            this.supplierTA = new UKZN_Howard_Clinic_Management_System.SupplierInventoryDSTableAdapters.SupplierDBTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.inventorySupplierReport1 = new UKZN_Howard_Clinic_Management_System.InventorySupplierReport();
            ((System.ComponentModel.ISupportInitialize)(this.supplierInventoryDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(311, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // supplierInventoryDS1
            // 
            this.supplierInventoryDS1.DataSetName = "SupplierInventoryDS";
            this.supplierInventoryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicInventoryTA
            // 
            this.clinicInventoryTA.ClearBeforeFill = true;
            // 
            // supplierTA
            // 
            this.supplierTA.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 58);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 392);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // MangerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::UKZN_Howard_Clinic_Management_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "MangerReport";
            this.Text = "MangerReport";
            this.Load += new System.EventHandler(this.MangerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierInventoryDS1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private SupplierInventoryDS supplierInventoryDS1;
        private SupplierInventoryDSTableAdapters.ClinicInventoryDBTableAdapter clinicInventoryTA;
        private SupplierInventoryDSTableAdapters.SupplierDBTableAdapter supplierTA;
        private InventorySupplierReport inventorySupplierReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
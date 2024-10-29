
namespace UKZN_Howard_Clinic_Management_System
{
    partial class NurseApointmentSchedulingReport
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
            this.appointmentTA = new UKZN_Howard_Clinic_Management_System.G15Wst2024DataSet1TableAdapters.AppointmentTableDBTableAdapter();
            this.patientTA = new UKZN_Howard_Clinic_Management_System.G15Wst2024DataSet1TableAdapters.PatientTableDBTableAdapter();
            this.staffTA = new UKZN_Howard_Clinic_Management_System.G15Wst2024DataSet1TableAdapters.StaffTableDBTableAdapter();
            this.ds1 = new UKZN_Howard_Clinic_Management_System.G15Wst2024DataSet1();
            this.btnReport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentSchedingReport1 = new UKZN_Howard_Clinic_Management_System.AppointmentSchedingReport();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentTA
            // 
            this.appointmentTA.ClearBeforeFill = true;
            // 
            // patientTA
            // 
            this.patientTA.ClearBeforeFill = true;
            // 
            // staffTA
            // 
            this.staffTA.ClearBeforeFill = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "G15Wst2024DataSet1";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(501, 29);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(116, 23);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Patient Name";
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv.Location = new System.Drawing.Point(0, 58);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(800, 392);
            this.crv.TabIndex = 3;
            // 
            // NurseApointmentSchedulingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReport);
            this.Name = "NurseApointmentSchedulingReport";
            this.Text = "NurseApointmentSchedulingReport";
            this.Load += new System.EventHandler(this.NurseApointmentSchedulingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private G15Wst2024DataSet1TableAdapters.AppointmentTableDBTableAdapter appointmentTA;
        private G15Wst2024DataSet1TableAdapters.PatientTableDBTableAdapter patientTA;
        private G15Wst2024DataSet1TableAdapters.StaffTableDBTableAdapter staffTA;
        private G15Wst2024DataSet1 ds1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private AppointmentSchedingReport appointmentSchedingReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
    }
}
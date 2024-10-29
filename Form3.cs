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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //loading main form at start
            Form myForm = new Form1();
            FormSetup(myForm);
        }

        public void FormSetup(Form myForm)
        {
            foreach(Form c in this.MdiChildren)
            {
	c.Close();
            }
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        public void ChangeDisplay()
        {
            if(this.MdiChildren.Equals(new  Patient()))
            {
	
            }
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new Patient();
            FormSetup(myForm);
        }
    }
}

﻿using System;
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
    public partial class HelpPanelForm : Form
    {
        public HelpPanelForm()
        {
            InitializeComponent();
        }

        private void HelpPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Program
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Form1 logIn = new Form1();
            logIn.Show();
            this.Hide();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            
        }

        private void btnAllDoctors_Click(object sender, EventArgs e)
        {
            AllDoctor allDoctor = new AllDoctor();
            allDoctor.Show();
            
        }
    }
}

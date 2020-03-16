using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Program
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();

            obj.PatientFirstName = txtFirstName.Text;
            obj.PatientSecondName = txtSurname.Text;
            obj.Address1 = txtAddress1.Text;
            obj.Address2 = txtAddress2.Text;
            obj.Address3 = txtAddress3.Text;
            obj.PostCode = txtPostCode.Text;
            obj.ContactNumber = txtContactNumber.Text;
            obj.DateOfBirth = txtDOB.Text;

            obj.AddPatient();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment2Program
{
    public partial class AppointmentForm : Form
    {
        public int whichRecord = 0;
        public int countRecords = 0;

        System.Data.SqlClient.SqlDataAdapter daGetAppointment;
        DataSet dsAppointment;
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            dsAppointment = new DataSet();
            String sqlGetWhat;
            sqlGetWhat = "SELECT * From tblAppointment";

            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            daGetAppointment = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);
            daGetAppointment.Fill(dsAppointment, "Appointment");

            countRecords = dsAppointment.Tables["Appointment"].Rows.Count;
            MoveRecords();
        }

        private void MoveRecords()
        {
            DataRow OneRecord = dsAppointment.Tables["Appointment"].Rows[whichRecord];
            txtApptDate.Text = OneRecord.ItemArray.GetValue(1).ToString();
            txtApptTime.Text = OneRecord.ItemArray.GetValue(2).ToString();
            txtPatientID.Text = OneRecord.ItemArray.GetValue(3).ToString();
            txtDoctorID.Text = OneRecord.ItemArray.GetValue(4).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Appointment obj = new Appointment();

            obj.AppointmentDate = txtApptDate.Text;
            obj.AppointmentTime = txtApptTime.Text;
            obj.PatientID = txtPatientID.Text;
            obj.DoctorID = txtDoctorID.Text;


            obj.AddAppt();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 logIn = new Form1();
            logIn.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

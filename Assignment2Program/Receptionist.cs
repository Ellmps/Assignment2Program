using System;
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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();

        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();

        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelAppt viewCancel = new CancelAppt();
            viewCancel.Show();

        }

        private void btnDoctorReport_Click(object sender, EventArgs e)
        {
            ParticularDoctor particularDoctor = new ParticularDoctor();
            particularDoctor.Show();

        }
    }
}

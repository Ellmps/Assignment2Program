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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "Doctor")
            {
                DoctorForm doctorForm = new DoctorForm();
                doctorForm.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "Manager")
            {
                ManagerForm managerForm = new ManagerForm();
                managerForm.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "Reception")
            {
                Receptionist receptionForm = new Receptionist();
                receptionForm.Show();
                this.Hide();
            }
        }
    }
}

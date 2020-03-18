using System;
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
    public partial class CancelAppt : Form
    {
        public int whichRecord = 0;
        public int countRecords = 0;

        System.Data.SqlClient.SqlDataAdapter daGetAppointment;
        DataSet dsAppointment;
        public CancelAppt()
        {
            InitializeComponent();
        }

        private void CancelAppt_Load(object sender, EventArgs e)
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

            txtApptID.Text = OneRecord.ItemArray.GetValue(0).ToString();
            txtApptDate.Text = OneRecord.ItemArray.GetValue(1).ToString();
            txtApptTime.Text = OneRecord.ItemArray.GetValue(2).ToString();
            txtPatientID.Text = OneRecord.ItemArray.GetValue(3).ToString();
            txtDoctorID.Text = OneRecord.ItemArray.GetValue(4).ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            whichRecord = 0;
            MoveRecords();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            whichRecord = countRecords - 1;
            MoveRecords();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (whichRecord > 0)
            {
                whichRecord--;
                MoveRecords();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (whichRecord < countRecords - 1)
            {
                whichRecord++;
                MoveRecords();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

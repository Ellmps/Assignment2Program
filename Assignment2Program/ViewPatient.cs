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
    public partial class ViewPatient : Form
    {

        public int whichRecord = 0;
        public int countRecords = 0;

        System.Data.SqlClient.SqlDataAdapter daGetPatient;
        DataSet dsPatient;
        public ViewPatient()
        {
            InitializeComponent();
        }

        private void ViewPatient_Load(object sender, EventArgs e)
        {
            dsPatient = new DataSet();
            String sqlGetWhat;
            sqlGetWhat = "SELECT * From tblPatient";

            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            daGetPatient = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);
            daGetPatient.Fill(dsPatient, "Patient");

            countRecords = dsPatient.Tables["Patient"].Rows.Count;

            MoveRecords();
           
        }

        private void MoveRecords()
        {
            DataRow OneRecord = dsPatient.Tables["Patient"].Rows[whichRecord];

            txtPatientID.Text = OneRecord.ItemArray.GetValue(0).ToString();
            txtFirstName.Text = OneRecord.ItemArray.GetValue(1).ToString();
            txtSurname.Text = OneRecord.ItemArray.GetValue(2).ToString();
            txtAddress1.Text = OneRecord.ItemArray.GetValue(3).ToString();
            txtAddress2.Text = OneRecord.ItemArray.GetValue(4).ToString();
            txtAddress3.Text = OneRecord.ItemArray.GetValue(5).ToString();
            txtPostCode.Text = OneRecord.ItemArray.GetValue(6).ToString();
            txtContactNumber.Text = OneRecord.ItemArray.GetValue(7).ToString();
            txtDOB.Text = OneRecord.ItemArray.GetValue(8).ToString();
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
            if(whichRecord > 0)
            {
                whichRecord--;
                MoveRecords();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(whichRecord < countRecords - 1)
            {
                whichRecord++;
                MoveRecords();
            }
        }
    }
}

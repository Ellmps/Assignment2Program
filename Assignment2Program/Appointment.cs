using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;

namespace Assignment2Program
{
    class Appointment
    {
        public int myApptID;
        public string myApptDate;
        public string myApptTime;
        public string myPatientID;
        public string myDoctorID;

        public int AppointmentID
        {
            get
            {
                return myApptID;
            }

            set
            {
                myApptID = value;
            }
        }

        // Declare a ProductName property of type string:
        public string AppointmentDate
        {
            get
            {
                return myApptDate;
            }
            set
            {
                myApptDate = value;
            }
        }

        // Declare a QuantityPerUnit property of type string:
        public string AppointmentTime
        {
            get
            {
                return myApptTime;
            }
            set
            {
                myApptTime = value;
            }
        }

        // Declare a UnitPrice property of type decimal:
        public string PatientID
        {
            get
            {
                return myPatientID;
            }
            set
            {
                myPatientID = value;
            }
        }

        // Declare a UnitsInStock property of type int:
        public string DoctorID
        {
            get
            {
                return myDoctorID;
            }
            set
            {
                myDoctorID = value;
            }
        }


        public void AddAppt()
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            SqlCommand cmAppt = new SqlCommand();
            cmAppt.Connection = mySQLCon;
            cmAppt.CommandType = CommandType.Text;
            cmAppt.CommandText = "INSERT INTO tblAppointment(Appointment ID, Date, Time, PatientID, DoctorID) VALUES('"
                + myApptID + "','" + myApptDate + "','" + myApptTime
                + "'," + "'" + myPatientID + "','" + myDoctorID + "')";
            cmAppt.ExecuteNonQuery();
            cmAppt.CommandText = "Select MAX(AppointmentID) FROM tblAppointment";
            myApptID = (int)cmAppt.ExecuteScalar();
        }

    }
}

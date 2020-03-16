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
    class Patient
    {
        public int myPatientID;
        public string myPatientFirstName;
        public string myPatientSecondName;
        public string myAddress1;
        public string myAddress2;
        public string myAddress3;       
        public string myPostCode;
        public string myContactNo;
        public string myDOB;


        public int PatientID
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

        // Declare a ProductName property of type string:
        public string PatientFirstName
        {
            get
            {
                return myPatientFirstName;
            }
            set
            {
                myPatientFirstName = value;
            }
        }

        // Declare a QuantityPerUnit property of type string:
        public string PatientSecondName
        {
            get
            {
                return myPatientSecondName;
            }
            set
            {
                myPatientSecondName = value;
            }
        }

        // Declare a UnitPrice property of type decimal:
        public string Address1
        {
            get
            {
                return myAddress1;
            }
            set
            {
                myAddress1 = value;
            }
        }

        // Declare a UnitsInStock property of type int:
        public string Address2
        {
            get
            {
                return myAddress2;
            }
            set
            {
                myAddress2 = value;
            }
        }

        public string Address3
        {
            get
            {
                return myAddress3;
            }

            set
            {
                myAddress3 = value;
            }

        }

        public string PostCode
        {
            get
            {
                return myPostCode;
            }
            set
            {
                myPostCode = value;
            }
        }

        public string ContactNumber
        {
            get
            {
                return myContactNo;
            }
            set
            {
                myContactNo = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return myDOB;
            }
            set
            {
                myDOB = value;
            }
        }

        public void AddPatient()
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            SqlCommand cmPatient = new SqlCommand();
            cmPatient.Connection = mySQLCon;
            cmPatient.CommandType = CommandType.Text;
            cmPatient.CommandText = "INSERT INTO tblPatient(First Name, Surname, Address 1, Address 2, Address 3, Post Code, Contact Number, Date of Birth) VALUES('"
                + myPatientFirstName + "','" + myPatientSecondName + "','" + myAddress1
                + "'," + "'" + myAddress2 + "','" + myAddress3 + "','" + myPostCode + "','" + myContactNo + "','" + myDOB + "')";
        }

    }

   
}

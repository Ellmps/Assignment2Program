namespace Assignment2Program
{
    partial class Receptionist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.btnDoctorReport = new System.Windows.Forms.Button();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(251, 154);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(168, 76);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Location = new System.Drawing.Point(17, 154);
            this.btnViewPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(168, 70);
            this.btnViewPatient.TabIndex = 1;
            this.btnViewPatient.Text = "View Patient";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnDoctorReport
            // 
            this.btnDoctorReport.Location = new System.Drawing.Point(17, 258);
            this.btnDoctorReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctorReport.Name = "btnDoctorReport";
            this.btnDoctorReport.Size = new System.Drawing.Size(168, 64);
            this.btnDoctorReport.TabIndex = 2;
            this.btnDoctorReport.Text = "Report for particular Doctor";
            this.btnDoctorReport.UseVisualStyleBackColor = true;
            this.btnDoctorReport.Click += new System.EventHandler(this.btnDoctorReport_Click);
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Location = new System.Drawing.Point(17, 358);
            this.btnCreateAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(168, 70);
            this.btnCreateAppointment.TabIndex = 3;
            this.btnCreateAppointment.Text = "Create Appointment";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(17, 450);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 62);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Appointment Cancellations";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateAppointment);
            this.Controls.Add(this.btnDoctorReport);
            this.Controls.Add(this.btnViewPatient);
            this.Controls.Add(this.btnAddPatient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.Button btnDoctorReport;
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnCancel;
    }
}
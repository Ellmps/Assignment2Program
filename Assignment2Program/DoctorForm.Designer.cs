namespace Assignment2Program
{
    partial class DoctorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnViewPat = new System.Windows.Forms.Button();
            this.btnDoctorSearch = new System.Windows.Forms.Button();
            this.btnCancelAppt = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(387, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Panel";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(17, 16);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(125, 53);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnViewPat
            // 
            this.btnViewPat.Location = new System.Drawing.Point(17, 149);
            this.btnViewPat.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPat.Name = "btnViewPat";
            this.btnViewPat.Size = new System.Drawing.Size(125, 53);
            this.btnViewPat.TabIndex = 2;
            this.btnViewPat.Text = "View Patient";
            this.btnViewPat.UseVisualStyleBackColor = true;
            this.btnViewPat.Click += new System.EventHandler(this.btnViewPat_Click);
            // 
            // btnDoctorSearch
            // 
            this.btnDoctorSearch.Location = new System.Drawing.Point(17, 238);
            this.btnDoctorSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctorSearch.Name = "btnDoctorSearch";
            this.btnDoctorSearch.Size = new System.Drawing.Size(125, 53);
            this.btnDoctorSearch.TabIndex = 3;
            this.btnDoctorSearch.Text = "Report for particular Doctor";
            this.btnDoctorSearch.UseVisualStyleBackColor = true;
            this.btnDoctorSearch.Click += new System.EventHandler(this.btnDoctorSearch_Click);
            // 
            // btnCancelAppt
            // 
            this.btnCancelAppt.Location = new System.Drawing.Point(17, 335);
            this.btnCancelAppt.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAppt.Name = "btnCancelAppt";
            this.btnCancelAppt.Size = new System.Drawing.Size(155, 79);
            this.btnCancelAppt.TabIndex = 4;
            this.btnCancelAppt.Text = "Appointment Cancellations";
            this.btnCancelAppt.UseVisualStyleBackColor = true;
            this.btnCancelAppt.Click += new System.EventHandler(this.btnCancelAppt_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(656, 374);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(100, 22);
            this.txtNotes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notes for current consultation";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(777, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnCancelAppt);
            this.Controls.Add(this.btnDoctorSearch);
            this.Controls.Add(this.btnViewPat);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnViewPat;
        private System.Windows.Forms.Button btnDoctorSearch;
        private System.Windows.Forms.Button btnCancelAppt;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
    }
}
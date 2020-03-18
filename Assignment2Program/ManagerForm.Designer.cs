namespace Assignment2Program
{
    partial class ManagerForm
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
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.btnAllDoctors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Panel";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(17, 16);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(125, 53);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Location = new System.Drawing.Point(17, 127);
            this.btnViewPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(125, 50);
            this.btnViewPatient.TabIndex = 2;
            this.btnViewPatient.Text = "View Patient";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnAllDoctors
            // 
            this.btnAllDoctors.Location = new System.Drawing.Point(17, 217);
            this.btnAllDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAllDoctors.Name = "btnAllDoctors";
            this.btnAllDoctors.Size = new System.Drawing.Size(125, 59);
            this.btnAllDoctors.TabIndex = 3;
            this.btnAllDoctors.Text = "Obtain and Run Reports for all doctors";
            this.btnAllDoctors.UseVisualStyleBackColor = true;
            this.btnAllDoctors.Click += new System.EventHandler(this.btnAllDoctors_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAllDoctors);
            this.Controls.Add(this.btnViewPatient);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.Button btnAllDoctors;
    }
}
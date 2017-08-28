namespace _6CIT
{
    partial class profile
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
            this.cb_patient_sex = new System.Windows.Forms.ComboBox();
            this.dtp_patient_DOB = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_patient_id = new System.Windows.Forms.TextBox();
            this.rtb_patient_notes = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_patient_postcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_patient_adl2 = new System.Windows.Forms.TextBox();
            this.txt_patient_occupation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_begintest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_patient_adl1 = new System.Windows.Forms.TextBox();
            this.txt_patient_sname = new System.Windows.Forms.TextBox();
            this.txt_patient_fname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_patient_sex
            // 
            this.cb_patient_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_patient_sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_patient_sex.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_patient_sex.FormattingEnabled = true;
            this.cb_patient_sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_patient_sex.Location = new System.Drawing.Point(118, 156);
            this.cb_patient_sex.MaxDropDownItems = 2;
            this.cb_patient_sex.Name = "cb_patient_sex";
            this.cb_patient_sex.Size = new System.Drawing.Size(139, 22);
            this.cb_patient_sex.TabIndex = 59;
            // 
            // dtp_patient_DOB
            // 
            this.dtp_patient_DOB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_patient_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_patient_DOB.Location = new System.Drawing.Point(118, 191);
            this.dtp_patient_DOB.Name = "dtp_patient_DOB";
            this.dtp_patient_DOB.Size = new System.Drawing.Size(138, 20);
            this.dtp_patient_DOB.TabIndex = 60;
            this.dtp_patient_DOB.Value = new System.DateTime(1889, 1, 1, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 14);
            this.label15.TabIndex = 78;
            this.label15.Text = "ID";
            // 
            // txt_patient_id
            // 
            this.txt_patient_id.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_id.Location = new System.Drawing.Point(118, 52);
            this.txt_patient_id.MaxLength = 10;
            this.txt_patient_id.Name = "txt_patient_id";
            this.txt_patient_id.Size = new System.Drawing.Size(138, 20);
            this.txt_patient_id.TabIndex = 56;
            // 
            // rtb_patient_notes
            // 
            this.rtb_patient_notes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_patient_notes.Location = new System.Drawing.Point(281, 84);
            this.rtb_patient_notes.MaxLength = 1000;
            this.rtb_patient_notes.Name = "rtb_patient_notes";
            this.rtb_patient_notes.Size = new System.Drawing.Size(223, 265);
            this.rtb_patient_notes.TabIndex = 65;
            this.rtb_patient_notes.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 14);
            this.label11.TabIndex = 77;
            this.label11.Text = "Occupation";
            // 
            // txt_patient_postcode
            // 
            this.txt_patient_postcode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_postcode.Location = new System.Drawing.Point(118, 296);
            this.txt_patient_postcode.MaxLength = 10;
            this.txt_patient_postcode.Name = "txt_patient_postcode";
            this.txt_patient_postcode.Size = new System.Drawing.Size(138, 20);
            this.txt_patient_postcode.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 14);
            this.label9.TabIndex = 76;
            this.label9.Text = "Pre-Existing Notes";
            // 
            // txt_patient_adl2
            // 
            this.txt_patient_adl2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_adl2.Location = new System.Drawing.Point(118, 261);
            this.txt_patient_adl2.MaxLength = 60;
            this.txt_patient_adl2.Name = "txt_patient_adl2";
            this.txt_patient_adl2.Size = new System.Drawing.Size(138, 20);
            this.txt_patient_adl2.TabIndex = 62;
            // 
            // txt_patient_occupation
            // 
            this.txt_patient_occupation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_occupation.Location = new System.Drawing.Point(118, 331);
            this.txt_patient_occupation.MaxLength = 30;
            this.txt_patient_occupation.Name = "txt_patient_occupation";
            this.txt_patient_occupation.Size = new System.Drawing.Size(138, 20);
            this.txt_patient_occupation.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 75;
            this.label7.Text = "Address Line 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 74;
            this.label6.Text = "Postcode";
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(20, 389);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 23);
            this.btn_back.TabIndex = 67;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_begintest
            // 
            this.btn_begintest.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_begintest.Location = new System.Drawing.Point(404, 389);
            this.btn_begintest.Name = "btn_begintest";
            this.btn_begintest.Size = new System.Drawing.Size(100, 23);
            this.btn_begintest.TabIndex = 66;
            this.btn_begintest.Text = "Begin Test";
            this.btn_begintest.UseVisualStyleBackColor = true;
            this.btn_begintest.Click += new System.EventHandler(this.btn_begintest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Patient Registration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 14);
            this.label10.TabIndex = 72;
            this.label10.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 71;
            this.label4.Text = "Address Line 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 70;
            this.label3.Text = "DOB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 14);
            this.label2.TabIndex = 69;
            this.label2.Text = "Sex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 68;
            this.label1.Text = "First Name";
            // 
            // txt_patient_adl1
            // 
            this.txt_patient_adl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_adl1.Location = new System.Drawing.Point(118, 226);
            this.txt_patient_adl1.MaxLength = 60;
            this.txt_patient_adl1.Name = "txt_patient_adl1";
            this.txt_patient_adl1.Size = new System.Drawing.Size(138, 20);
            this.txt_patient_adl1.TabIndex = 61;
            // 
            // txt_patient_sname
            // 
            this.txt_patient_sname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_sname.Location = new System.Drawing.Point(118, 121);
            this.txt_patient_sname.MaxLength = 30;
            this.txt_patient_sname.Name = "txt_patient_sname";
            this.txt_patient_sname.Size = new System.Drawing.Size(138, 20);
            this.txt_patient_sname.TabIndex = 58;
            // 
            // txt_patient_fname
            // 
            this.txt_patient_fname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_fname.Location = new System.Drawing.Point(118, 86);
            this.txt_patient_fname.MaxLength = 30;
            this.txt_patient_fname.Name = "txt_patient_fname";
            this.txt_patient_fname.Size = new System.Drawing.Size(138, 20);
            this.txt_patient_fname.TabIndex = 57;
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 435);
            this.Controls.Add(this.cb_patient_sex);
            this.Controls.Add(this.dtp_patient_DOB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_patient_id);
            this.Controls.Add(this.rtb_patient_notes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_patient_postcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_patient_adl2);
            this.Controls.Add(this.txt_patient_occupation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_begintest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patient_adl1);
            this.Controls.Add(this.txt_patient_sname);
            this.Controls.Add(this.txt_patient_fname);
            this.Name = "profile";
            this.Text = "Patient Profile Capture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.profile_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_patient_sex;
        private System.Windows.Forms.DateTimePicker dtp_patient_DOB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_patient_id;
        private System.Windows.Forms.RichTextBox rtb_patient_notes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_patient_postcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_patient_adl2;
        private System.Windows.Forms.TextBox txt_patient_occupation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_begintest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_patient_adl1;
        private System.Windows.Forms.TextBox txt_patient_sname;
        private System.Windows.Forms.TextBox txt_patient_fname;
    }
}
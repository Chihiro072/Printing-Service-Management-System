namespace kekw
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_AssignmentDataSet = new kekw.IOOP_AssignmentDataSet();
            this.serviceTableAdapter = new kekw.IOOP_AssignmentDataSetTableAdapters.ServiceTableAdapter();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lable8 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoHelicopter = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.iOOP_AssignmentDataSet;
            // 
            // iOOP_AssignmentDataSet
            // 
            this.iOOP_AssignmentDataSet.DataSetName = "IOOP_AssignmentDataSet";
            this.iOOP_AssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "student",
            "worker",
            "manager"});
            this.cboRole.Location = new System.Drawing.Point(196, 482);
            this.cboRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(301, 23);
            this.cboRole.TabIndex = 38;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignUp.Location = new System.Drawing.Point(403, 545);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSignUp.Size = new System.Drawing.Size(267, 52);
            this.btnSignUp.TabIndex = 35;
            this.btnSignUp.Text = "S I G N  U P";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(192, 441);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Role";
            // 
            // txtVerify
            // 
            this.txtVerify.ForeColor = System.Drawing.Color.Gray;
            this.txtVerify.Location = new System.Drawing.Point(196, 392);
            this.txtVerify.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(301, 25);
            this.txtVerify.TabIndex = 33;
            this.txtVerify.Text = "Type your password again";
            this.txtVerify.Click += new System.EventHandler(this.txtVerify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(192, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Verify Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(389, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sign Up to APU PSMS";
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(197, 311);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(301, 25);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Text = "Type your password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(192, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(196, 219);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(301, 25);
            this.txtUsername.TabIndex = 28;
            this.txtUsername.Text = "Type your username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(192, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Username";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(492, 40);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(100, 29);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(866, 629);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-27, -24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(579, 441);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Home Address";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(583, 392);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 25);
            this.txtEmail.TabIndex = 44;
            this.txtEmail.Text = "Type your email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable8.ForeColor = System.Drawing.Color.Gray;
            this.lable8.Location = new System.Drawing.Point(579, 355);
            this.lable8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(53, 19);
            this.lable8.TabIndex = 43;
            this.lable8.Text = "Email";
            // 
            // txtDOB
            // 
            this.txtDOB.AutoSize = true;
            this.txtDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.Color.Gray;
            this.txtDOB.Location = new System.Drawing.Point(579, 268);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(106, 19);
            this.txtDOB.TabIndex = 41;
            this.txtDOB.Text = "Date of Birth";
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.Gray;
            this.txtGender.Location = new System.Drawing.Point(579, 182);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(71, 19);
            this.txtGender.TabIndex = 39;
            this.txtGender.Text = "Gender";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Location = new System.Drawing.Point(583, 480);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 25);
            this.txtAddress.TabIndex = 46;
            this.txtAddress.Text = "Type your address";
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(586, 220);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(60, 19);
            this.rdoMale.TabIndex = 47;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(665, 220);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(76, 19);
            this.rdoFemale.TabIndex = 48;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoHelicopter
            // 
            this.rdoHelicopter.AutoSize = true;
            this.rdoHelicopter.Location = new System.Drawing.Point(757, 219);
            this.rdoHelicopter.Name = "rdoHelicopter";
            this.rdoHelicopter.Size = new System.Drawing.Size(108, 19);
            this.rdoHelicopter.TabIndex = 49;
            this.rdoHelicopter.TabStop = true;
            this.rdoHelicopter.Text = "Helicopter";
            this.rdoHelicopter.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(586, 307);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 25);
            this.datePicker.TabIndex = 50;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 699);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.rdoHelicopter);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lable8);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Register";
            this.Text = "Sign Up Form";
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IOOP_AssignmentDataSet iOOP_AssignmentDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private IOOP_AssignmentDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.Label txtDOB;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoHelicopter;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}
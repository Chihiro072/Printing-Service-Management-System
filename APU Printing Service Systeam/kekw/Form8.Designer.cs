namespace kekw
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.lblVerify = new System.Windows.Forms.Label();
            this.txtUsernameAndPw = new System.Windows.Forms.TextBox();
            this.lblUsernameAndPw = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.MediumPurple;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(300, 302);
            this.btnReset.Margin = new System.Windows.Forms.Padding(10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(5);
            this.btnReset.Size = new System.Drawing.Size(200, 45);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "RESET PASSWORD";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.AutoSize = true;
            this.btnContinue.BackColor = System.Drawing.Color.MediumPurple;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContinue.Location = new System.Drawing.Point(300, 240);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(10);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Padding = new System.Windows.Forms.Padding(5);
            this.btnContinue.Size = new System.Drawing.Size(200, 45);
            this.btnContinue.TabIndex = 24;
            this.btnContinue.Text = "C O N T I N U E";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtVerify
            // 
            this.txtVerify.ForeColor = System.Drawing.Color.Gray;
            this.txtVerify.Location = new System.Drawing.Point(288, 269);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(227, 20);
            this.txtVerify.TabIndex = 22;
            this.txtVerify.TabStop = false;
            this.txtVerify.Text = "Type your password again";
            this.txtVerify.Visible = false;
            this.txtVerify.Click += new System.EventHandler(this.txtVerify_Click);
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.ForeColor = System.Drawing.Color.Gray;
            this.lblVerify.Location = new System.Drawing.Point(285, 237);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(141, 16);
            this.lblVerify.TabIndex = 21;
            this.lblVerify.Text = "Verify New Password";
            this.lblVerify.Visible = false;
            // 
            // txtUsernameAndPw
            // 
            this.txtUsernameAndPw.ForeColor = System.Drawing.Color.Gray;
            this.txtUsernameAndPw.Location = new System.Drawing.Point(288, 194);
            this.txtUsernameAndPw.Name = "txtUsernameAndPw";
            this.txtUsernameAndPw.Size = new System.Drawing.Size(227, 20);
            this.txtUsernameAndPw.TabIndex = 23;
            this.txtUsernameAndPw.TabStop = false;
            this.txtUsernameAndPw.Text = "Type your username";
            this.txtUsernameAndPw.Click += new System.EventHandler(this.txtUsernameAndPw_Click);
            // 
            // lblUsernameAndPw
            // 
            this.lblUsernameAndPw.AutoSize = true;
            this.lblUsernameAndPw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameAndPw.ForeColor = System.Drawing.Color.Gray;
            this.lblUsernameAndPw.Location = new System.Drawing.Point(285, 162);
            this.lblUsernameAndPw.Name = "lblUsernameAndPw";
            this.lblUsernameAndPw.Size = new System.Drawing.Size(71, 16);
            this.lblUsernameAndPw.TabIndex = 20;
            this.lblUsernameAndPw.Text = "Username";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(366, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(301, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Forgot Password?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(250, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 400);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-8, -23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(816, 496);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.txtUsernameAndPw);
            this.Controls.Add(this.lblUsernameAndPw);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Name = "ChangePassword";
            this.Text = "Update Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.TextBox txtUsernameAndPw;
        private System.Windows.Forms.Label lblUsernameAndPw;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
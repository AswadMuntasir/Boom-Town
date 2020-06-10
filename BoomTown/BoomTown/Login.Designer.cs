namespace BoomTown
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnForgetPass = new System.Windows.Forms.Button();
            this.grbBoxLogin = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPass.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPass.Location = new System.Drawing.Point(382, 493);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(128, 34);
            this.btnForgetPass.TabIndex = 30;
            this.btnForgetPass.Text = "Forget Password?";
            this.btnForgetPass.UseVisualStyleBackColor = false;
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            // 
            // grbBoxLogin
            // 
            this.grbBoxLogin.Controls.Add(this.txtPass);
            this.grbBoxLogin.Controls.Add(this.txtUserId);
            this.grbBoxLogin.Controls.Add(this.lblPass);
            this.grbBoxLogin.Controls.Add(this.lblUserID);
            this.grbBoxLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.grbBoxLogin.Location = new System.Drawing.Point(382, 275);
            this.grbBoxLogin.Name = "grbBoxLogin";
            this.grbBoxLogin.Size = new System.Drawing.Size(307, 201);
            this.grbBoxLogin.TabIndex = 27;
            this.grbBoxLogin.TabStop = false;
            this.grbBoxLogin.Text = "Login here";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(118, 129);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(154, 22);
            this.txtPass.TabIndex = 3;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(118, 65);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(154, 22);
            this.txtUserId.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Red;
            this.lblPass.Location = new System.Drawing.Point(33, 130);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(79, 17);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Red;
            this.lblUserID.Location = new System.Drawing.Point(33, 70);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(70, 17);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(424, 230);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(243, 29);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.Text = "Sign in with Owner ID";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(605, 493);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 34);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnForgetPass);
            this.Controls.Add(this.grbBoxLogin);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.grbBoxLogin.ResumeLayout(false);
            this.grbBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnForgetPass;
        private System.Windows.Forms.GroupBox grbBoxLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogin;
    }
}
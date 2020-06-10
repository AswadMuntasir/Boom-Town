namespace BoomTown
{
    partial class ResetPassword
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
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.tBoxPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.tBoxCPass = new System.Windows.Forms.TextBox();
            this.lblRetypePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxID
            // 
            this.tBoxID.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxID.Location = new System.Drawing.Point(326, 108);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(396, 44);
            this.tBoxID.TabIndex = 20;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(51, 108);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(194, 42);
            this.lblUserID.TabIndex = 19;
            this.lblUserID.Text = "Enter User ID :";
            // 
            // tBoxPass
            // 
            this.tBoxPass.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPass.Location = new System.Drawing.Point(326, 188);
            this.tBoxPass.Name = "tBoxPass";
            this.tBoxPass.Size = new System.Drawing.Size(396, 44);
            this.tBoxPass.TabIndex = 18;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(51, 188);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(206, 42);
            this.lblNewPass.TabIndex = 17;
            this.lblNewPass.Text = "New Password :";
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnForgetPassword.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.Location = new System.Drawing.Point(315, 362);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(220, 53);
            this.btnForgetPassword.TabIndex = 16;
            this.btnForgetPassword.Text = "Done";
            this.btnForgetPassword.UseVisualStyleBackColor = false;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // tBoxCPass
            // 
            this.tBoxCPass.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCPass.Location = new System.Drawing.Point(326, 268);
            this.tBoxCPass.Name = "tBoxCPass";
            this.tBoxCPass.Size = new System.Drawing.Size(396, 44);
            this.tBoxCPass.TabIndex = 15;
            // 
            // lblRetypePass
            // 
            this.lblRetypePass.AutoSize = true;
            this.lblRetypePass.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePass.Location = new System.Drawing.Point(51, 268);
            this.lblRetypePass.Name = "lblRetypePass";
            this.lblRetypePass.Size = new System.Drawing.Size(237, 42);
            this.lblRetypePass.TabIndex = 14;
            this.lblRetypePass.Text = "Retype Password :";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.tBoxPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.tBoxCPass);
            this.Controls.Add(this.lblRetypePass);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox tBoxPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.TextBox tBoxCPass;
        private System.Windows.Forms.Label lblRetypePass;
    }
}
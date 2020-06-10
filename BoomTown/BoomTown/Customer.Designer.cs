namespace BoomTown
{
    partial class Customer
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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerContactNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerContactNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxSearchCustomer = new System.Windows.Forms.GroupBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.customer_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_contact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grpBoxSearchCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(575, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerEmail);
            this.groupBox1.Controls.Add(this.lblCustomerEmail);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.lblCustomerAddress);
            this.groupBox1.Controls.Add(this.txtCustomerContactNo);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.lblCustomerContactNo);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.lblCustomerId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(348, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 280);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert here";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(200, 164);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerEmail.TabIndex = 11;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustomerEmail.Location = new System.Drawing.Point(88, 165);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(57, 15);
            this.lblCustomerEmail.TabIndex = 10;
            this.lblCustomerEmail.Text = "E-Mail :";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(200, 203);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(143, 52);
            this.txtCustomerAddress.TabIndex = 9;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustomerAddress.Location = new System.Drawing.Point(88, 203);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(66, 15);
            this.lblCustomerAddress.TabIndex = 4;
            this.lblCustomerAddress.Text = "Address :";
            // 
            // txtCustomerContactNo
            // 
            this.txtCustomerContactNo.Location = new System.Drawing.Point(200, 125);
            this.txtCustomerContactNo.Name = "txtCustomerContactNo";
            this.txtCustomerContactNo.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerContactNo.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(200, 86);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Location = new System.Drawing.Point(200, 47);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerId.TabIndex = 5;
            // 
            // lblCustomerContactNo
            // 
            this.lblCustomerContactNo.AutoSize = true;
            this.lblCustomerContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerContactNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustomerContactNo.Location = new System.Drawing.Point(88, 127);
            this.lblCustomerContactNo.Name = "lblCustomerContactNo";
            this.lblCustomerContactNo.Size = new System.Drawing.Size(85, 15);
            this.lblCustomerContactNo.TabIndex = 2;
            this.lblCustomerContactNo.Text = "Contact No :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustomerName.Location = new System.Drawing.Point(88, 89);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(53, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name :";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustomerId.Location = new System.Drawing.Point(88, 51);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(94, 15);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "Customer ID :";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_no,
            this.customer_name,
            this.customer_contact_no,
            this.customer_email,
            this.customer_address});
            this.dgvCustomer.Location = new System.Drawing.Point(11, 427);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(1042, 305);
            this.dgvCustomer.TabIndex = 20;
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(950, 388);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 33);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(950, 43);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 33);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBoxSearchCustomer
            // 
            this.grpBoxSearchCustomer.Controls.Add(this.metroTextBox1);
            this.grpBoxSearchCustomer.Controls.Add(this.label3);
            this.grpBoxSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSearchCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpBoxSearchCustomer.Location = new System.Drawing.Point(23, 63);
            this.grpBoxSearchCustomer.Name = "grpBoxSearchCustomer";
            this.grpBoxSearchCustomer.Size = new System.Drawing.Size(290, 100);
            this.grpBoxSearchCustomer.TabIndex = 23;
            this.grpBoxSearchCustomer.TabStop = false;
            this.grpBoxSearchCustomer.Text = "Search";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(6, 49);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "type here";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(225, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "type here";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name/Contact No :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(494, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // customer_no
            // 
            this.customer_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_no.DataPropertyName = "customer_no";
            this.customer_no.HeaderText = "Customer ID";
            this.customer_no.Name = "customer_no";
            this.customer_no.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Name";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // customer_contact_no
            // 
            this.customer_contact_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_contact_no.DataPropertyName = "customer_contact_no";
            this.customer_contact_no.HeaderText = "Contact no";
            this.customer_contact_no.Name = "customer_contact_no";
            this.customer_contact_no.ReadOnly = true;
            // 
            // customer_email
            // 
            this.customer_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_email.DataPropertyName = "customer_email";
            this.customer_email.HeaderText = "E-Mail";
            this.customer_email.Name = "customer_email";
            this.customer_email.ReadOnly = true;
            // 
            // customer_address
            // 
            this.customer_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_address.DataPropertyName = "customer_address";
            this.customer_address.HeaderText = "Address";
            this.customer_address.Name = "customer_address";
            this.customer_address.ReadOnly = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 741);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpBoxSearchCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customer";
            this.Text = "Customer Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grpBoxSearchCustomer.ResumeLayout(false);
            this.grpBoxSearchCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerContactNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerContactNo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBoxSearchCustomer;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_contact_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_address;
    }
}
namespace BoomTown
{
    partial class Employee
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
            this.emp_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpHireDate = new System.Windows.Forms.TextBox();
            this.lblEmpHireDate = new System.Windows.Forms.Label();
            this.txtEmpSal = new System.Windows.Forms.TextBox();
            this.lblEmpSal = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.txtEmpType = new System.Windows.Forms.TextBox();
            this.txtEmpContactNo = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.emp_sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.emp_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmpContactNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empDataGridView = new System.Windows.Forms.DataGridView();
            this.emp_contact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxSearchEmp = new System.Windows.Forms.GroupBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBoxSearchEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_type
            // 
            this.emp_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_type.DataPropertyName = "emp_type";
            this.emp_type.HeaderText = "Employee Type";
            this.emp_type.Name = "emp_type";
            this.emp_type.ReadOnly = true;
            // 
            // txtEmpHireDate
            // 
            this.txtEmpHireDate.Location = new System.Drawing.Point(200, 221);
            this.txtEmpHireDate.Name = "txtEmpHireDate";
            this.txtEmpHireDate.Size = new System.Drawing.Size(143, 22);
            this.txtEmpHireDate.TabIndex = 13;
            // 
            // lblEmpHireDate
            // 
            this.lblEmpHireDate.AutoSize = true;
            this.lblEmpHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpHireDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpHireDate.Location = new System.Drawing.Point(79, 221);
            this.lblEmpHireDate.Name = "lblEmpHireDate";
            this.lblEmpHireDate.Size = new System.Drawing.Size(76, 15);
            this.lblEmpHireDate.TabIndex = 12;
            this.lblEmpHireDate.Text = "Hire Date :";
            // 
            // txtEmpSal
            // 
            this.txtEmpSal.Location = new System.Drawing.Point(200, 192);
            this.txtEmpSal.Name = "txtEmpSal";
            this.txtEmpSal.Size = new System.Drawing.Size(143, 22);
            this.txtEmpSal.TabIndex = 11;
            // 
            // lblEmpSal
            // 
            this.lblEmpSal.AutoSize = true;
            this.lblEmpSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpSal.Location = new System.Drawing.Point(79, 192);
            this.lblEmpSal.Name = "lblEmpSal";
            this.lblEmpSal.Size = new System.Drawing.Size(55, 15);
            this.lblEmpSal.TabIndex = 10;
            this.lblEmpSal.Text = "Salary :";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(200, 162);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(143, 22);
            this.txtEmpAddress.TabIndex = 9;
            // 
            // txtEmpType
            // 
            this.txtEmpType.Location = new System.Drawing.Point(200, 133);
            this.txtEmpType.Name = "txtEmpType";
            this.txtEmpType.Size = new System.Drawing.Size(143, 22);
            this.txtEmpType.TabIndex = 8;
            // 
            // txtEmpContactNo
            // 
            this.txtEmpContactNo.Location = new System.Drawing.Point(200, 104);
            this.txtEmpContactNo.Name = "txtEmpContactNo";
            this.txtEmpContactNo.Size = new System.Drawing.Size(143, 22);
            this.txtEmpContactNo.TabIndex = 7;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(200, 75);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(143, 22);
            this.txtEmpName.TabIndex = 6;
            // 
            // emp_sal
            // 
            this.emp_sal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_sal.DataPropertyName = "emp_sal";
            this.emp_sal.HeaderText = "Salary";
            this.emp_sal.Name = "emp_sal";
            this.emp_sal.ReadOnly = true;
            // 
            // emp_hiredate
            // 
            this.emp_hiredate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_hiredate.DataPropertyName = "emp_hiredate";
            this.emp_hiredate.HeaderText = "Hire Date";
            this.emp_hiredate.Name = "emp_hiredate";
            this.emp_hiredate.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(950, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 33);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(950, 363);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 33);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Location = new System.Drawing.Point(200, 44);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(143, 22);
            this.txtEmpId.TabIndex = 5;
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpAddress.Location = new System.Drawing.Point(79, 163);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(66, 15);
            this.lblEmpAddress.TabIndex = 4;
            this.lblEmpAddress.Text = "Address :";
            // 
            // lblEmpType
            // 
            this.lblEmpType.AutoSize = true;
            this.lblEmpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpType.Location = new System.Drawing.Point(79, 134);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(112, 15);
            this.lblEmpType.TabIndex = 3;
            this.lblEmpType.Text = "Employee Type :";
            // 
            // emp_address
            // 
            this.emp_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_address.DataPropertyName = "emp_address";
            this.emp_address.HeaderText = "Address";
            this.emp_address.Name = "emp_address";
            this.emp_address.ReadOnly = true;
            // 
            // lblEmpContactNo
            // 
            this.lblEmpContactNo.AutoSize = true;
            this.lblEmpContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpContactNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpContactNo.Location = new System.Drawing.Point(79, 105);
            this.lblEmpContactNo.Name = "lblEmpContactNo";
            this.lblEmpContactNo.Size = new System.Drawing.Size(85, 15);
            this.lblEmpContactNo.TabIndex = 2;
            this.lblEmpContactNo.Text = "Contact No :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 4;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(357, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 39);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpName.Location = new System.Drawing.Point(79, 76);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(53, 15);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Name :";
            // 
            // emp_name
            // 
            this.emp_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_name.DataPropertyName = "emp_name";
            this.emp_name.HeaderText = "Name";
            this.emp_name.Name = "emp_name";
            this.emp_name.ReadOnly = true;
            // 
            // emp_no
            // 
            this.emp_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_no.DataPropertyName = "emp_no";
            this.emp_no.HeaderText = "Employee ID";
            this.emp_no.Name = "emp_no";
            this.emp_no.ReadOnly = true;
            // 
            // empDataGridView
            // 
            this.empDataGridView.AllowUserToAddRows = false;
            this.empDataGridView.AllowUserToDeleteRows = false;
            this.empDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.empDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_no,
            this.emp_name,
            this.emp_contact_no,
            this.emp_type,
            this.emp_address,
            this.emp_sal,
            this.emp_hiredate});
            this.empDataGridView.Location = new System.Drawing.Point(11, 402);
            this.empDataGridView.Name = "empDataGridView";
            this.empDataGridView.ReadOnly = true;
            this.empDataGridView.Size = new System.Drawing.Size(1042, 367);
            this.empDataGridView.TabIndex = 27;
            // 
            // emp_contact_no
            // 
            this.emp_contact_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_contact_no.DataPropertyName = "emp_contact_no";
            this.emp_contact_no.HeaderText = "Contact No ";
            this.emp_contact_no.Name = "emp_contact_no";
            this.emp_contact_no.ReadOnly = true;
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpId.Location = new System.Drawing.Point(79, 47);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(96, 15);
            this.lblEmpId.TabIndex = 0;
            this.lblEmpId.Text = "Employee ID :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.btnSave.FlatAppearance.BorderSize = 4;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(556, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpHireDate);
            this.groupBox1.Controls.Add(this.lblEmpHireDate);
            this.groupBox1.Controls.Add(this.txtEmpSal);
            this.groupBox1.Controls.Add(this.lblEmpSal);
            this.groupBox1.Controls.Add(this.txtEmpAddress);
            this.groupBox1.Controls.Add(this.txtEmpType);
            this.groupBox1.Controls.Add(this.txtEmpContactNo);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.txtEmpId);
            this.groupBox1.Controls.Add(this.lblEmpAddress);
            this.groupBox1.Controls.Add(this.lblEmpType);
            this.groupBox1.Controls.Add(this.lblEmpContactNo);
            this.groupBox1.Controls.Add(this.lblEmpName);
            this.groupBox1.Controls.Add(this.lblEmpId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(314, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 280);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert here";
            // 
            // grpBoxSearchEmp
            // 
            this.grpBoxSearchEmp.Controls.Add(this.metroTextBox1);
            this.grpBoxSearchEmp.Controls.Add(this.label3);
            this.grpBoxSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSearchEmp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpBoxSearchEmp.Location = new System.Drawing.Point(11, 63);
            this.grpBoxSearchEmp.Name = "grpBoxSearchEmp";
            this.grpBoxSearchEmp.Size = new System.Drawing.Size(290, 100);
            this.grpBoxSearchEmp.TabIndex = 32;
            this.grpBoxSearchEmp.TabStop = false;
            this.grpBoxSearchEmp.Text = "Search";
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
            this.metroTextBox1.Size = new System.Drawing.Size(203, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "type here";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 788);
            this.Controls.Add(this.grpBoxSearchEmp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.empDataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxSearchEmp.ResumeLayout(false);
            this.grpBoxSearchEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn emp_type;
        private System.Windows.Forms.TextBox txtEmpHireDate;
        private System.Windows.Forms.Label lblEmpHireDate;
        private System.Windows.Forms.TextBox txtEmpSal;
        private System.Windows.Forms.Label lblEmpSal;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.TextBox txtEmpType;
        private System.Windows.Forms.TextBox txtEmpContactNo;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_sal;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_hiredate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_address;
        private System.Windows.Forms.Label lblEmpContactNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_no;
        private System.Windows.Forms.DataGridView empDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_contact_no;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxSearchEmp;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label3;
    }
}
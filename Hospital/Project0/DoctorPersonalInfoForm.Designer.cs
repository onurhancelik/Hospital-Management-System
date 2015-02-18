namespace Project0
{
    partial class DoctorPersonalInfoForm
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label doctor_idLabel;
            System.Windows.Forms.Label doctor_nameLabel;
            System.Windows.Forms.Label doctor_surnameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label dept_nameLabel;
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.doctor_idTextBox = new System.Windows.Forms.TextBox();
            this.doctor_nameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_surnameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            addressLabel = new System.Windows.Forms.Label();
            doctor_idLabel = new System.Windows.Forms.Label();
            doctor_nameLabel = new System.Windows.Forms.Label();
            doctor_surnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            dept_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(43, 201);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // doctor_idLabel
            // 
            doctor_idLabel.AutoSize = true;
            doctor_idLabel.Location = new System.Drawing.Point(43, 64);
            doctor_idLabel.Name = "doctor_idLabel";
            doctor_idLabel.Size = new System.Drawing.Size(53, 13);
            doctor_idLabel.TabIndex = 5;
            doctor_idLabel.Text = "Doctor id:";
            // 
            // doctor_nameLabel
            // 
            doctor_nameLabel.AutoSize = true;
            doctor_nameLabel.Location = new System.Drawing.Point(43, 90);
            doctor_nameLabel.Name = "doctor_nameLabel";
            doctor_nameLabel.Size = new System.Drawing.Size(71, 13);
            doctor_nameLabel.TabIndex = 7;
            doctor_nameLabel.Text = "Doctor name:";
            // 
            // doctor_surnameLabel
            // 
            doctor_surnameLabel.AutoSize = true;
            doctor_surnameLabel.Location = new System.Drawing.Point(43, 116);
            doctor_surnameLabel.Name = "doctor_surnameLabel";
            doctor_surnameLabel.Size = new System.Drawing.Size(85, 13);
            doctor_surnameLabel.TabIndex = 9;
            doctor_surnameLabel.Text = "Doctor surname:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(43, 175);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // dept_nameLabel
            // 
            dept_nameLabel.AutoSize = true;
            dept_nameLabel.Location = new System.Drawing.Point(43, 145);
            dept_nameLabel.Name = "dept_nameLabel";
            dept_nameLabel.Size = new System.Drawing.Size(62, 13);
            dept_nameLabel.TabIndex = 15;
            dept_nameLabel.Text = "Dept name:";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Project0.Doctor);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(134, 198);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(126, 77);
            this.addressTextBox.TabIndex = 2;
            // 
            // doctor_idTextBox
            // 
            this.doctor_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor_id", true));
            this.doctor_idTextBox.Location = new System.Drawing.Point(134, 61);
            this.doctor_idTextBox.Name = "doctor_idTextBox";
            this.doctor_idTextBox.ReadOnly = true;
            this.doctor_idTextBox.Size = new System.Drawing.Size(126, 20);
            this.doctor_idTextBox.TabIndex = 6;
            // 
            // doctor_nameTextBox
            // 
            this.doctor_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor_name", true));
            this.doctor_nameTextBox.Location = new System.Drawing.Point(134, 87);
            this.doctor_nameTextBox.Name = "doctor_nameTextBox";
            this.doctor_nameTextBox.Size = new System.Drawing.Size(126, 20);
            this.doctor_nameTextBox.TabIndex = 8;
            // 
            // doctor_surnameTextBox
            // 
            this.doctor_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor_surname", true));
            this.doctor_surnameTextBox.Location = new System.Drawing.Point(134, 113);
            this.doctor_surnameTextBox.Name = "doctor_surnameTextBox";
            this.doctor_surnameTextBox.Size = new System.Drawing.Size(126, 20);
            this.doctor_surnameTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(134, 172);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(126, 20);
            this.phoneTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Doctor Personal Info";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(146, 289);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(53, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "SAVE";
            this.toolTip1.SetToolTip(this.saveButton, "Save");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.Location = new System.Drawing.Point(205, 289);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 23);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "CLOSE";
            this.toolTip1.SetToolTip(this.exitButton, "Close");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dept_nameTextBox
            // 
            this.dept_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Department.Dept_name", true));
            this.dept_nameTextBox.Location = new System.Drawing.Point(134, 142);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.ReadOnly = true;
            this.dept_nameTextBox.Size = new System.Drawing.Size(126, 20);
            this.dept_nameTextBox.TabIndex = 16;
            // 
            // DoctorPersonalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 324);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(dept_nameLabel);
            this.Controls.Add(this.dept_nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(doctor_idLabel);
            this.Controls.Add(this.doctor_idTextBox);
            this.Controls.Add(doctor_nameLabel);
            this.Controls.Add(this.doctor_nameTextBox);
            this.Controls.Add(doctor_surnameLabel);
            this.Controls.Add(this.doctor_surnameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Name = "DoctorPersonalInfoForm";
            this.Text = "Doctor Personal Info";
            this.Load += new System.EventHandler(this.DoctorPersonalInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox doctor_idTextBox;
        private System.Windows.Forms.TextBox doctor_nameTextBox;
        private System.Windows.Forms.TextBox doctor_surnameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
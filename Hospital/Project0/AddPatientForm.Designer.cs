namespace Project0
{
    partial class AddPatientForm
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
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label birth_placeLabel;
            System.Windows.Forms.Label father_nameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label ssnLabel;
            System.Windows.Forms.Label surnameLabel;
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inspectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birth_placeTextBox = new System.Windows.Forms.TextBox();
            this.father_nameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ssnTextBox1 = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            addressLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            birth_placeLabel = new System.Windows.Forms.Label();
            father_nameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(47, 343);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 55;
            addressLabel.Text = "Address:";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Location = new System.Drawing.Point(47, 240);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(55, 13);
            birth_dateLabel.TabIndex = 57;
            birth_dateLabel.Text = "Birth date:";
            // 
            // birth_placeLabel
            // 
            birth_placeLabel.AutoSize = true;
            birth_placeLabel.Location = new System.Drawing.Point(47, 265);
            birth_placeLabel.Name = "birth_placeLabel";
            birth_placeLabel.Size = new System.Drawing.Size(60, 13);
            birth_placeLabel.TabIndex = 59;
            birth_placeLabel.Text = "Birth place:";
            // 
            // father_nameLabel
            // 
            father_nameLabel.AutoSize = true;
            father_nameLabel.Location = new System.Drawing.Point(47, 291);
            father_nameLabel.Name = "father_nameLabel";
            father_nameLabel.Size = new System.Drawing.Size(69, 13);
            father_nameLabel.TabIndex = 61;
            father_nameLabel.Text = "Father name:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(47, 160);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 63;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(47, 317);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 67;
            phoneLabel.Text = "Phone:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(47, 212);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 69;
            sexLabel.Text = "Sex:";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new System.Drawing.Point(47, 134);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(28, 13);
            ssnLabel.TabIndex = 71;
            ssnLabel.Text = "Ssn:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(47, 186);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 73;
            surnameLabel.Text = "Surname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ssn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(47, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Please before add staff, check records.";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(50, 24);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(121, 20);
            this.ssnTextBox.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(346, 262);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 36);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "SAVE";
            this.toolTip1.SetToolTip(this.saveButton, "Add New Patient Record");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.Location = new System.Drawing.Point(459, 262);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "CLOSE";
            this.toolTip1.SetToolTip(this.exitButton, "Close");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(187, 22);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(68, 23);
            this.checkButton.TabIndex = 25;
            this.checkButton.Text = "CHECK";
            this.toolTip1.SetToolTip(this.checkButton, "Check");
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ssnTextBox);
            this.groupBox1.Controls.Add(this.checkButton);
            this.groupBox1.Location = new System.Drawing.Point(50, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 58);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check whether the patient record by Ssn";
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(357, 64);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(279, 34);
            this.messageLabel.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Inspection Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Doctor:";
            // 
            // inspectionDateTimePicker
            // 
            this.inspectionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inspectionDateTimePicker.Location = new System.Drawing.Point(411, 128);
            this.inspectionDateTimePicker.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.inspectionDateTimePicker.MinDate = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.inspectionDateTimePicker.Name = "inspectionDateTimePicker";
            this.inspectionDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.inspectionDateTimePicker.TabIndex = 52;
            this.inspectionDateTimePicker.Value = new System.DateTime(2014, 12, 21, 0, 0, 0, 0);
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(411, 160);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(137, 21);
            this.deptComboBox.TabIndex = 53;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(411, 187);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(137, 21);
            this.doctorComboBox.TabIndex = 54;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Project0.Patient);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(122, 340);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(137, 71);
            this.addressTextBox.TabIndex = 56;
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Birth_date", true));
            this.birth_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(122, 236);
            this.birth_dateDateTimePicker.MaxDate = new System.DateTime(2014, 12, 15, 0, 0, 0, 0);
            this.birth_dateDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.birth_dateDateTimePicker.TabIndex = 58;
            this.birth_dateDateTimePicker.Value = new System.DateTime(2014, 12, 15, 0, 0, 0, 0);
            // 
            // birth_placeTextBox
            // 
            this.birth_placeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Birth_place", true));
            this.birth_placeTextBox.Location = new System.Drawing.Point(122, 262);
            this.birth_placeTextBox.Name = "birth_placeTextBox";
            this.birth_placeTextBox.Size = new System.Drawing.Size(137, 20);
            this.birth_placeTextBox.TabIndex = 60;
            // 
            // father_nameTextBox
            // 
            this.father_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Father_name", true));
            this.father_nameTextBox.Location = new System.Drawing.Point(122, 288);
            this.father_nameTextBox.Name = "father_nameTextBox";
            this.father_nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.father_nameTextBox.TabIndex = 62;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(122, 157);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.nameTextBox.TabIndex = 64;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(122, 314);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(137, 20);
            this.phoneTextBox.TabIndex = 68;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Sex", true));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(122, 209);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(137, 21);
            this.sexComboBox.TabIndex = 70;
            // 
            // ssnTextBox1
            // 
            this.ssnTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Ssn", true));
            this.ssnTextBox1.Location = new System.Drawing.Point(122, 131);
            this.ssnTextBox1.Name = "ssnTextBox1";
            this.ssnTextBox1.Size = new System.Drawing.Size(137, 20);
            this.ssnTextBox1.TabIndex = 72;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(122, 183);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(137, 20);
            this.surnameTextBox.TabIndex = 74;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(661, 448);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(birth_dateLabel);
            this.Controls.Add(this.birth_dateDateTimePicker);
            this.Controls.Add(birth_placeLabel);
            this.Controls.Add(this.birth_placeTextBox);
            this.Controls.Add(father_nameLabel);
            this.Controls.Add(this.father_nameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(ssnLabel);
            this.Controls.Add(this.ssnTextBox1);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.deptComboBox);
            this.Controls.Add(this.inspectionDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label10);
            this.Name = "AddPatientForm";
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddPatientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inspectionDateTimePicker;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox birth_placeTextBox;
        private System.Windows.Forms.TextBox father_nameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox ssnTextBox1;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
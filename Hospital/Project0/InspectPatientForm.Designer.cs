namespace Project0
{
    partial class InspectPatientForm
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
            System.Windows.Forms.Label blood_analysisLabel;
            System.Windows.Forms.Label complaintLabel;
            System.Windows.Forms.Label date_inLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label prescriptionLabel;
            System.Windows.Forms.Label urianalysisLabel;
            System.Windows.Forms.Label xrayLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label ssnLabel;
            System.Windows.Forms.Label surnameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectPatientForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.patient_AdmissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_analysisCheckBox = new System.Windows.Forms.CheckBox();
            this.complaintTextBox = new System.Windows.Forms.TextBox();
            this.date_inTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.urianalysisCheckBox = new System.Windows.Forms.CheckBox();
            this.xrayCheckBox = new System.Windows.Forms.CheckBox();
            this.birth_dateTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            blood_analysisLabel = new System.Windows.Forms.Label();
            complaintLabel = new System.Windows.Forms.Label();
            date_inLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            prescriptionLabel = new System.Windows.Forms.Label();
            urianalysisLabel = new System.Windows.Forms.Label();
            xrayLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patient_AdmissionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // blood_analysisLabel
            // 
            blood_analysisLabel.AutoSize = true;
            blood_analysisLabel.Location = new System.Drawing.Point(43, 24);
            blood_analysisLabel.Name = "blood_analysisLabel";
            blood_analysisLabel.Size = new System.Drawing.Size(74, 13);
            blood_analysisLabel.TabIndex = 73;
            blood_analysisLabel.Text = "Blood analysis";
            // 
            // complaintLabel
            // 
            complaintLabel.AutoSize = true;
            complaintLabel.Location = new System.Drawing.Point(269, 89);
            complaintLabel.Name = "complaintLabel";
            complaintLabel.Size = new System.Drawing.Size(56, 13);
            complaintLabel.TabIndex = 75;
            complaintLabel.Text = "Complaint:";
            // 
            // date_inLabel
            // 
            date_inLabel.AutoSize = true;
            date_inLabel.Location = new System.Drawing.Point(269, 60);
            date_inLabel.Name = "date_inLabel";
            date_inLabel.Size = new System.Drawing.Size(44, 13);
            date_inLabel.TabIndex = 77;
            date_inLabel.Text = "Date in:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(269, 189);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 81;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // prescriptionLabel
            // 
            prescriptionLabel.AutoSize = true;
            prescriptionLabel.Location = new System.Drawing.Point(269, 289);
            prescriptionLabel.Name = "prescriptionLabel";
            prescriptionLabel.Size = new System.Drawing.Size(65, 13);
            prescriptionLabel.TabIndex = 89;
            prescriptionLabel.Text = "Prescription:";
            // 
            // urianalysisLabel
            // 
            urianalysisLabel.AutoSize = true;
            urianalysisLabel.Location = new System.Drawing.Point(43, 50);
            urianalysisLabel.Name = "urianalysisLabel";
            urianalysisLabel.Size = new System.Drawing.Size(57, 13);
            urianalysisLabel.TabIndex = 91;
            urianalysisLabel.Text = "Urianalysis";
            // 
            // xrayLabel
            // 
            xrayLabel.AutoSize = true;
            xrayLabel.Location = new System.Drawing.Point(43, 75);
            xrayLabel.Name = "xrayLabel";
            xrayLabel.Size = new System.Drawing.Size(28, 13);
            xrayLabel.TabIndex = 93;
            xrayLabel.Text = "Xray";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Location = new System.Drawing.Point(17, 126);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(55, 13);
            birth_dateLabel.TabIndex = 112;
            birth_dateLabel.Text = "Birth date:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 55);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 118;
            nameLabel.Text = "Name:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(17, 102);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 124;
            sexLabel.Text = "Sex:";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new System.Drawing.Point(17, 29);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(28, 13);
            ssnLabel.TabIndex = 126;
            ssnLabel.Text = "Ssn:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(17, 79);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 128;
            surnameLabel.Text = "Surname:";
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(0, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(572, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "INSPECTION FORM";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(528, 23);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 31);
            this.closeButton.TabIndex = 72;
            this.toolTip1.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // patient_AdmissionBindingSource
            // 
            this.patient_AdmissionBindingSource.DataSource = typeof(Project0.Patient_Admission);
            // 
            // blood_analysisCheckBox
            // 
            this.blood_analysisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patient_AdmissionBindingSource, "Blood_analysis", true));
            this.blood_analysisCheckBox.Location = new System.Drawing.Point(18, 19);
            this.blood_analysisCheckBox.Name = "blood_analysisCheckBox";
            this.blood_analysisCheckBox.Size = new System.Drawing.Size(19, 24);
            this.blood_analysisCheckBox.TabIndex = 74;
            this.blood_analysisCheckBox.UseVisualStyleBackColor = true;
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Complaint", true));
            this.complaintTextBox.Location = new System.Drawing.Point(352, 86);
            this.complaintTextBox.Multiline = true;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.complaintTextBox.Size = new System.Drawing.Size(170, 89);
            this.complaintTextBox.TabIndex = 76;
            // 
            // date_inTextBox
            // 
            this.date_inTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Date_in", true));
            this.date_inTextBox.Location = new System.Drawing.Point(352, 57);
            this.date_inTextBox.Name = "date_inTextBox";
            this.date_inTextBox.ReadOnly = true;
            this.date_inTextBox.Size = new System.Drawing.Size(104, 20);
            this.date_inTextBox.TabIndex = 78;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(352, 187);
            this.diagnosisTextBox.Multiline = true;
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.diagnosisTextBox.Size = new System.Drawing.Size(170, 89);
            this.diagnosisTextBox.TabIndex = 82;
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Prescription", true));
            this.prescriptionTextBox.Location = new System.Drawing.Point(352, 286);
            this.prescriptionTextBox.Multiline = true;
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prescriptionTextBox.Size = new System.Drawing.Size(170, 89);
            this.prescriptionTextBox.TabIndex = 90;
            // 
            // urianalysisCheckBox
            // 
            this.urianalysisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patient_AdmissionBindingSource, "Urianalysis", true));
            this.urianalysisCheckBox.Location = new System.Drawing.Point(18, 45);
            this.urianalysisCheckBox.Name = "urianalysisCheckBox";
            this.urianalysisCheckBox.Size = new System.Drawing.Size(19, 24);
            this.urianalysisCheckBox.TabIndex = 92;
            this.urianalysisCheckBox.UseVisualStyleBackColor = true;
            // 
            // xrayCheckBox
            // 
            this.xrayCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patient_AdmissionBindingSource, "Xray", true));
            this.xrayCheckBox.Location = new System.Drawing.Point(18, 70);
            this.xrayCheckBox.Name = "xrayCheckBox";
            this.xrayCheckBox.Size = new System.Drawing.Size(19, 24);
            this.xrayCheckBox.TabIndex = 94;
            this.xrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // birth_dateTextBox
            // 
            this.birth_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Patient.Birth_date", true));
            this.birth_dateTextBox.Location = new System.Drawing.Point(92, 123);
            this.birth_dateTextBox.Name = "birth_dateTextBox";
            this.birth_dateTextBox.ReadOnly = true;
            this.birth_dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birth_dateTextBox.TabIndex = 113;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Patient.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(92, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 119;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Patient.Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(92, 99);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexTextBox.TabIndex = 125;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Patient.Ssn", true));
            this.ssnTextBox.Location = new System.Drawing.Point(92, 26);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.ReadOnly = true;
            this.ssnTextBox.Size = new System.Drawing.Size(100, 20);
            this.ssnTextBox.TabIndex = 127;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_AdmissionBindingSource, "Patient.Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(92, 76);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 129;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(birth_dateLabel);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(this.birth_dateTextBox);
            this.groupBox1.Controls.Add(surnameLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.ssnTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(ssnLabel);
            this.groupBox1.Controls.Add(sexLabel);
            this.groupBox1.Controls.Add(this.sexTextBox);
            this.groupBox1.Location = new System.Drawing.Point(25, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(blood_analysisLabel);
            this.groupBox2.Controls.Add(this.blood_analysisCheckBox);
            this.groupBox2.Controls.Add(urianalysisLabel);
            this.groupBox2.Controls.Add(this.urianalysisCheckBox);
            this.groupBox2.Controls.Add(this.xrayCheckBox);
            this.groupBox2.Controls.Add(xrayLabel);
            this.groupBox2.Location = new System.Drawing.Point(25, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analysis";
            // 
            // InspectPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(572, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(complaintLabel);
            this.Controls.Add(this.complaintTextBox);
            this.Controls.Add(date_inLabel);
            this.Controls.Add(this.date_inTextBox);
            this.Controls.Add(diagnosisLabel);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(prescriptionLabel);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.saveButton);
            this.Name = "InspectPatientForm";
            this.Text = "GetPatient";
            this.Load += new System.EventHandler(this.InspectPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patient_AdmissionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource patient_AdmissionBindingSource;
        private System.Windows.Forms.CheckBox blood_analysisCheckBox;
        private System.Windows.Forms.TextBox complaintTextBox;
        private System.Windows.Forms.TextBox date_inTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.CheckBox urianalysisCheckBox;
        private System.Windows.Forms.CheckBox xrayCheckBox;
        private System.Windows.Forms.TextBox birth_dateTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
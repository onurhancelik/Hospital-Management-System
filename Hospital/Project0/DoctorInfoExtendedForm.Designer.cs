namespace Project0
{
    partial class DoctorInfoExtendedForm
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
            System.Windows.Forms.Label doctor_nameLabel;
            System.Windows.Forms.Label doctor_surnameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label dept_idLabel1;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label user_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorInfoExtendedForm));
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctor_nameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_surnameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.dept_idTextBox1 = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.user_nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.doctorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.doctorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            doctor_nameLabel = new System.Windows.Forms.Label();
            doctor_surnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            dept_idLabel1 = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingNavigator)).BeginInit();
            this.doctorsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctor_nameLabel
            // 
            doctor_nameLabel.AutoSize = true;
            doctor_nameLabel.Location = new System.Drawing.Point(16, 18);
            doctor_nameLabel.Name = "doctor_nameLabel";
            doctor_nameLabel.Size = new System.Drawing.Size(71, 13);
            doctor_nameLabel.TabIndex = 3;
            doctor_nameLabel.Text = "Doctor name:";
            // 
            // doctor_surnameLabel
            // 
            doctor_surnameLabel.AutoSize = true;
            doctor_surnameLabel.Location = new System.Drawing.Point(16, 44);
            doctor_surnameLabel.Name = "doctor_surnameLabel";
            doctor_surnameLabel.Size = new System.Drawing.Size(85, 13);
            doctor_surnameLabel.TabIndex = 5;
            doctor_surnameLabel.Text = "Doctor surname:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(16, 71);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(16, 100);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Address:";
            // 
            // dept_idLabel1
            // 
            dept_idLabel1.AutoSize = true;
            dept_idLabel1.Location = new System.Drawing.Point(13, 23);
            dept_idLabel1.Name = "dept_idLabel1";
            dept_idLabel1.Size = new System.Drawing.Size(44, 13);
            dept_idLabel1.TabIndex = 15;
            dept_idLabel1.Text = "Dept id:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(13, 74);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(38, 13);
            e_mailLabel.TabIndex = 19;
            e_mailLabel.Text = "E mail:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(13, 48);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "Password:";
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Location = new System.Drawing.Point(13, 22);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(61, 13);
            user_nameLabel.TabIndex = 27;
            user_nameLabel.Text = "User name:";
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataSource = typeof(System.Data.Linq.EntitySet<Project0.Doctor>);
            // 
            // doctor_nameTextBox
            // 
            this.doctor_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Doctor_name", true));
            this.doctor_nameTextBox.Location = new System.Drawing.Point(107, 15);
            this.doctor_nameTextBox.Name = "doctor_nameTextBox";
            this.doctor_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_nameTextBox.TabIndex = 4;
            // 
            // doctor_surnameTextBox
            // 
            this.doctor_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Doctor_surname", true));
            this.doctor_surnameTextBox.Location = new System.Drawing.Point(107, 41);
            this.doctor_surnameTextBox.Name = "doctor_surnameTextBox";
            this.doctor_surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_surnameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(107, 67);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(107, 97);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 69);
            this.addressTextBox.TabIndex = 14;
            // 
            // dept_idTextBox1
            // 
            this.dept_idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Department.Dept_id", true));
            this.dept_idTextBox1.Location = new System.Drawing.Point(86, 20);
            this.dept_idTextBox1.Name = "dept_idTextBox1";
            this.dept_idTextBox1.ReadOnly = true;
            this.dept_idTextBox1.Size = new System.Drawing.Size(121, 20);
            this.dept_idTextBox1.TabIndex = 16;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "User.E_mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(80, 71);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(121, 20);
            this.e_mailTextBox.TabIndex = 20;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "User.Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(80, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 24;
            // 
            // user_nameTextBox
            // 
            this.user_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "User.User_name", true));
            this.user_nameTextBox.Location = new System.Drawing.Point(80, 19);
            this.user_nameTextBox.Name = "user_nameTextBox";
            this.user_nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.user_nameTextBox.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deptComboBox);
            this.groupBox1.Controls.Add(dept_idLabel1);
            this.groupBox1.Controls.Add(this.dept_idTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(287, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 75);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deparment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Dept. Name:";
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(86, 46);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(121, 21);
            this.deptComboBox.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(e_mailLabel);
            this.groupBox2.Controls.Add(this.user_nameTextBox);
            this.groupBox2.Controls.Add(user_nameLabel);
            this.groupBox2.Controls.Add(this.e_mailTextBox);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Controls.Add(passwordLabel);
            this.groupBox2.Location = new System.Drawing.Point(287, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 101);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(doctor_nameLabel);
            this.groupBox3.Controls.Add(this.addressTextBox);
            this.groupBox3.Controls.Add(addressLabel);
            this.groupBox3.Controls.Add(this.phoneTextBox);
            this.groupBox3.Controls.Add(this.doctor_nameTextBox);
            this.groupBox3.Controls.Add(phoneLabel);
            this.groupBox3.Controls.Add(doctor_surnameLabel);
            this.groupBox3.Controls.Add(this.doctor_surnameTextBox);
            this.groupBox3.Location = new System.Drawing.Point(23, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 193);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Information";
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
            this.closeButton.Location = new System.Drawing.Point(493, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 31);
            this.closeButton.TabIndex = 32;
            this.toolTip1.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // doctorsBindingNavigatorSaveItem
            // 
            this.doctorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorsBindingNavigatorSaveItem.Image")));
            this.doctorsBindingNavigatorSaveItem.Name = "doctorsBindingNavigatorSaveItem";
            this.doctorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctorsBindingNavigatorSaveItem.Text = "Save Data";
            this.doctorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorsBindingNavigatorSaveItem_Click);
            // 
            // doctorsBindingNavigator
            // 
            this.doctorsBindingNavigator.AddNewItem = null;
            this.doctorsBindingNavigator.BindingSource = this.doctorsBindingSource;
            this.doctorsBindingNavigator.CountItem = null;
            this.doctorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.doctorsBindingNavigatorSaveItem});
            this.doctorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorsBindingNavigator.MoveFirstItem = null;
            this.doctorsBindingNavigator.MoveLastItem = null;
            this.doctorsBindingNavigator.MoveNextItem = null;
            this.doctorsBindingNavigator.MovePreviousItem = null;
            this.doctorsBindingNavigator.Name = "doctorsBindingNavigator";
            this.doctorsBindingNavigator.PositionItem = null;
            this.doctorsBindingNavigator.Size = new System.Drawing.Size(530, 25);
            this.doctorsBindingNavigator.TabIndex = 0;
            this.doctorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // DoctorInfoExtendedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(530, 282);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doctorsBindingNavigator);
            this.Name = "DoctorInfoExtendedForm";
            this.Text = "Doctor Info Extended";
            this.Load += new System.EventHandler(this.DoctorInfoExtendedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingNavigator)).EndInit();
            this.doctorsBindingNavigator.ResumeLayout(false);
            this.doctorsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.TextBox doctor_nameTextBox;
        private System.Windows.Forms.TextBox doctor_surnameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox dept_idTextBox1;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox user_nameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton doctorsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator doctorsBindingNavigator;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Label label1;
    }
}
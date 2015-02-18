namespace Project0
{
    partial class AddStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.step1TabPage = new System.Windows.Forms.TabPage();
            this.close2Button = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordcontrolLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.step2TabPage = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.step1TabPage.SuspendLayout();
            this.step2TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.step1TabPage);
            this.tabControl.Controls.Add(this.step2TabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(296, 285);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // step1TabPage
            // 
            this.step1TabPage.Controls.Add(this.close2Button);
            this.step1TabPage.Controls.Add(this.continueButton);
            this.step1TabPage.Controls.Add(this.userNameTextBox);
            this.step1TabPage.Controls.Add(this.passwordTextBox);
            this.step1TabPage.Controls.Add(this.emailTextBox);
            this.step1TabPage.Controls.Add(this.password2TextBox);
            this.step1TabPage.Controls.Add(this.emailLabel);
            this.step1TabPage.Controls.Add(this.passwordcontrolLabel);
            this.step1TabPage.Controls.Add(this.passwordLabel);
            this.step1TabPage.Controls.Add(this.usernameLabel);
            this.step1TabPage.Controls.Add(this.label9);
            this.step1TabPage.Location = new System.Drawing.Point(4, 22);
            this.step1TabPage.Name = "step1TabPage";
            this.step1TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.step1TabPage.Size = new System.Drawing.Size(288, 259);
            this.step1TabPage.TabIndex = 0;
            this.step1TabPage.Text = "Step 1";
            this.step1TabPage.UseVisualStyleBackColor = true;
            // 
            // close2Button
            // 
            this.close2Button.BackColor = System.Drawing.Color.White;
            this.close2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close2Button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.close2Button.FlatAppearance.BorderSize = 0;
            this.close2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close2Button.Image = ((System.Drawing.Image)(resources.GetObject("close2Button.Image")));
            this.close2Button.Location = new System.Drawing.Point(253, 6);
            this.close2Button.Name = "close2Button";
            this.close2Button.Size = new System.Drawing.Size(32, 31);
            this.close2Button.TabIndex = 25;
            this.toolTip1.SetToolTip(this.close2Button, "Close");
            this.close2Button.UseVisualStyleBackColor = false;
            this.close2Button.Click += new System.EventHandler(this.close2Button_Click);
            // 
            // continueButton
            // 
            this.continueButton.Image = ((System.Drawing.Image)(resources.GetObject("continueButton.Image")));
            this.continueButton.Location = new System.Drawing.Point(148, 181);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(95, 23);
            this.continueButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.continueButton, "Continue to Step 2");
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(112, 45);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(112, 79);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(131, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(112, 142);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(131, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // password2TextBox
            // 
            this.password2TextBox.Location = new System.Drawing.Point(112, 109);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(131, 20);
            this.password2TextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(26, 145);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E-mail:";
            // 
            // passwordcontrolLabel
            // 
            this.passwordcontrolLabel.AutoSize = true;
            this.passwordcontrolLabel.Location = new System.Drawing.Point(26, 112);
            this.passwordcontrolLabel.Name = "passwordcontrolLabel";
            this.passwordcontrolLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordcontrolLabel.TabIndex = 3;
            this.passwordcontrolLabel.Text = "Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(26, 82);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(26, 48);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(26, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "LOGIN INFORMATION";
            // 
            // step2TabPage
            // 
            this.step2TabPage.Controls.Add(this.closeButton);
            this.step2TabPage.Controls.Add(this.previousButton);
            this.step2TabPage.Controls.Add(this.label8);
            this.step2TabPage.Controls.Add(this.label1);
            this.step2TabPage.Controls.Add(this.saveButton);
            this.step2TabPage.Controls.Add(this.label2);
            this.step2TabPage.Controls.Add(this.addressTextBox);
            this.step2TabPage.Controls.Add(this.phoneTextBox);
            this.step2TabPage.Controls.Add(this.label6);
            this.step2TabPage.Controls.Add(this.label7);
            this.step2TabPage.Controls.Add(this.nameTextBox);
            this.step2TabPage.Controls.Add(this.surnameTextBox);
            this.step2TabPage.Location = new System.Drawing.Point(4, 22);
            this.step2TabPage.Name = "step2TabPage";
            this.step2TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.step2TabPage.Size = new System.Drawing.Size(288, 259);
            this.step2TabPage.TabIndex = 1;
            this.step2TabPage.Text = "Step 2";
            this.step2TabPage.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(253, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 31);
            this.closeButton.TabIndex = 25;
            this.toolTip1.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.Location = new System.Drawing.Point(32, 218);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(28, 23);
            this.previousButton.TabIndex = 7;
            this.previousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.previousButton, "Back to Step 1");
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "DOCTOR INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(190, 218);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(53, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "SAVE";
            this.toolTip1.SetToolTip(this.saveButton, "Add New Staff");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Surname:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(116, 147);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(127, 51);
            this.addressTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(116, 112);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(127, 20);
            this.phoneTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(116, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(127, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(116, 76);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(127, 20);
            this.surnameTextBox.TabIndex = 1;
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 285);
            this.Controls.Add(this.tabControl);
            this.Name = "AddStaffForm";
            this.Text = "Add Staff";
            this.tabControl.ResumeLayout(false);
            this.step1TabPage.ResumeLayout(false);
            this.step1TabPage.PerformLayout();
            this.step2TabPage.ResumeLayout(false);
            this.step2TabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage step1TabPage;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox password2TextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordcontrolLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage step2TabPage;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button close2Button;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
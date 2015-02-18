namespace Project0
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorButton = new System.Windows.Forms.Button();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hourLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.userAccToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsInfoToolStripMenuItem,
            this.departmentInfoToolStripMenuItem,
            this.staffInfoToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.infoToolStripMenuItem.Text = "Informations";
            // 
            // doctorsInfoToolStripMenuItem
            // 
            this.doctorsInfoToolStripMenuItem.Name = "doctorsInfoToolStripMenuItem";
            this.doctorsInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.doctorsInfoToolStripMenuItem.Text = "Doctors Info";
            this.doctorsInfoToolStripMenuItem.Click += new System.EventHandler(this.doctorsInfoToolStripMenuItem_Click);
            // 
            // departmentInfoToolStripMenuItem
            // 
            this.departmentInfoToolStripMenuItem.Name = "departmentInfoToolStripMenuItem";
            this.departmentInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.departmentInfoToolStripMenuItem.Text = "Department Info";
            this.departmentInfoToolStripMenuItem.Click += new System.EventHandler(this.departmentInfoToolStripMenuItem_Click);
            // 
            // staffInfoToolStripMenuItem
            // 
            this.staffInfoToolStripMenuItem.Name = "staffInfoToolStripMenuItem";
            this.staffInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.staffInfoToolStripMenuItem.Text = "Staff Info";
            this.staffInfoToolStripMenuItem.Click += new System.EventHandler(this.staffInfoToolStripMenuItem_Click);
            // 
            // userAccToolStripMenuItem
            // 
            this.userAccToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.userAccToolStripMenuItem.Name = "userAccToolStripMenuItem";
            this.userAccToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.userAccToolStripMenuItem.Text = "User Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // addDoctorButton
            // 
            this.addDoctorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addDoctorButton.Image = ((System.Drawing.Image)(resources.GetObject("addDoctorButton.Image")));
            this.addDoctorButton.Location = new System.Drawing.Point(30, 70);
            this.addDoctorButton.Name = "addDoctorButton";
            this.addDoctorButton.Size = new System.Drawing.Size(112, 116);
            this.addDoctorButton.TabIndex = 1;
            this.addDoctorButton.TabStop = false;
            this.addDoctorButton.Text = "ADD DOCTOR";
            this.addDoctorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addDoctorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.addDoctorButton, "Add New Doctor");
            this.addDoctorButton.UseVisualStyleBackColor = true;
            this.addDoctorButton.Click += new System.EventHandler(this.addDoctorButton_Click);
            // 
            // addStaffButton
            // 
            this.addStaffButton.Image = ((System.Drawing.Image)(resources.GetObject("addStaffButton.Image")));
            this.addStaffButton.Location = new System.Drawing.Point(175, 70);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(112, 116);
            this.addStaffButton.TabIndex = 2;
            this.addStaffButton.Text = "ADD STAFF";
            this.addStaffButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.addStaffButton, "Add New Staff");
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hourLabel.Location = new System.Drawing.Point(318, 33);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(0, 13);
            this.hourLabel.TabIndex = 4;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.Location = new System.Drawing.Point(318, 55);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.Location = new System.Drawing.Point(12, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 25);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXIT";
            this.toolTip1.SetToolTip(this.exitButton, "Exit Application");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hello, Admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.addDoctorButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Admin View";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button addDoctorButton;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem departmentInfoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
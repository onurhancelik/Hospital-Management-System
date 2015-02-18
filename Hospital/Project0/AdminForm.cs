using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project0
{
    public partial class AdminForm : Form
    {
        private String username;
        public AdminForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            hourLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm logf = new LoginForm();
            logf.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is designed as hospital management system.","About App",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddDoctorForm adcf = new AddDoctorForm();
            adcf.ShowDialog();
            
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaffForm adsf = new AddStaffForm();
            adsf.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminChangePassword acpf = new AdminChangePassword(username);
            acpf.ShowDialog();
        }

        private void doctorsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorInfo di = new DoctorInfo();
            di.ShowDialog();
        }

        private void staffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffInfoForm sif = new StaffInfoForm();
            sif.ShowDialog();
        }

        private void departmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentInfoForm dif = new DepartmentInfoForm();
            dif.ShowDialog();
        }
    }
}

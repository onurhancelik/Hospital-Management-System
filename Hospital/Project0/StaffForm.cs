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
    public partial class StaffForm : Form
    {
        private String username;
        private HospitalDataContext database = new HospitalDataContext();
        public StaffForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
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
            MessageBox.Show("This program is designed as hospital management system.", "About App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            var staff= from user in database.Users
                       from stf in user.Staffs
                       where user.User_name == username
                       select stf;

            helloLabel.Text = "Hello, " + staff.First().Name + " " + staff.First().Surname;         
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

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm apf = new AddPatientForm();
            apf.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdatePatientForm upf = new UpdatePatientForm();
            upf.ShowDialog();
        }

        private void changeUserSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserSettings suf = new UserSettings(username);
            suf.ShowDialog();
        }

        private void personalInfoSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffPersonalInfoForm spif = new StaffPersonalInfoForm(username);
            spif.ShowDialog();
        }
    }
}

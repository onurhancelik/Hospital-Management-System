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
    public partial class DoctorForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private String username;
        public DoctorForm(String username)
        {
            InitializeComponent();
            this.username = username;
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
            MessageBox.Show("This program is designed as hospital management system.", "About App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            allPatients();

            var doc = from doctor in database.Doctors
                      where doctor.User.User_name == username
                      select doctor;

            helloLabel.Text = "Hello, Dr. " + doc.First().Doctor_name + " " + doc.First().Doctor_surname;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            hourLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void allPatients()
        {
            var patient = from user in database.Users
                          from doc in user.Doctors
                          from pad in doc.Patient_Admissions
                          let pat = pad.Patient
                          where user.User_name == username
                          orderby pad.Date_in, pat.Name, pat.Surname
                          select new { AdmissionID = pad.Patient_ad_id, Name = pat.Name, Surname = pat.Surname, Date = pad.Date_in };

            dataGridView1.DataSource = patient;
            label2.Text = "ALL PATIENTS";
        }

        private void todaysPatients()
        {
            var patient = from user in database.Users
                          from doc in user.Doctors
                          from pad in doc.Patient_Admissions
                          let pat = pad.Patient
                          where user.User_name == username && pad.Date_in.Equals(DateTime.Today)
                          orderby pad.Date_in, pat.Name, pat.Surname
                          select new { AdmissionID = pad.Patient_ad_id, Name = pat.Name, Surname = pat.Surname, Date = pad.Date_in };

            dataGridView1.DataSource = patient;
            label2.Text = "TODAY's PATIENTS";
        }

        private void inspectButton_Click(object sender, EventArgs e)
        {
            int selectedPatient = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
            InspectPatientForm ipf = new InspectPatientForm(selectedPatient);
            ipf.ShowDialog();
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todaysPatients();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allPatients();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeUserSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings susf = new UserSettings(username);
            susf.ShowDialog();
        }

        private void myPersonalInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorPersonalInfoForm dpif = new DoctorPersonalInfoForm(username);
            dpif.ShowDialog();
        }
       
    }
}

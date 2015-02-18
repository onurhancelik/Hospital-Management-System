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
    public partial class AddPatientForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private bool isExist;
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ssnTextBox.Text == "" || nameTextBox.Text == "" || surnameTextBox.Text == "" || birth_placeTextBox.Text == ""
                || father_nameTextBox.Text == "" || phoneTextBox.Text == "" || doctorComboBox.Text=="")
            {
                MessageBox.Show("You must enter data to fields.", "Blank fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(isExist==false)
                {
                    Patient patient = new Patient();
                    patient.Ssn = ssnTextBox1.Text;
                    patient.Name = nameTextBox.Text;
                    patient.Surname = surnameTextBox.Text;
                    patient.Father_name = father_nameTextBox.Text;
                    patient.Birth_place = birth_placeTextBox.Text;
                    patient.Birth_date = birth_dateDateTimePicker.Value;
                    patient.Sex = sexComboBox.Text;
                    patient.Phone = phoneTextBox.Text;
                    patient.Address = addressTextBox.Text;

                    database.Patients.InsertOnSubmit(patient);
                    database.SubmitChanges();
                }

                Patient_Admission patientAdm = new Patient_Admission();

                patientAdm.Patient_id = (from p in database.Patients
                                         where p.Ssn == ssnTextBox1.Text
                                         select p).First().Patient_id;

                patientAdm.Dept_id = (from dep in database.Departments
                                      where dep.Dept_name == deptComboBox.Text
                                      select dep).First().Dept_id;

                patientAdm.Doctor_id = (from doc in database.Doctors
                                        where (doc.Doctor_name + " " + doc.Doctor_surname) == doctorComboBox.Text
                                        select doc).First().Doctor_id;

                patientAdm.Date_in = inspectionDateTimePicker.Value;

                database.Patient_Admissions.InsertOnSubmit(patientAdm);
                database.SubmitChanges();

                DialogResult dialogResult = MessageBox.Show("New staff successfully added..\n Do you want to add another staff?", "Added", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                    this.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            deptComboBox.DataSource = from dept in database.Departments
                                      select dept.Dept_name;

            doctorComboBox.DataSource = from dept in database.Departments
                                        from doc in dept.Doctors
                                        where dept.Dept_name == deptComboBox.Text
                                        select (String)doc.Doctor_name + " " + doc.Doctor_surname;

            sexComboBox.Items.Add("Female");
            sexComboBox.Items.Add("Male");
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var patient = from p in database.Patients
                          where ssnTextBox.Text == p.Ssn
                          select p;

            if (patient.Count() > 0)
            {
                messageLabel.Text = "The patient has the record. Enter the other admission informations of the patient.";
                patientBindingSource.DataSource = patient;
                isExist = true;
            }
            else
            {
                messageLabel.Text = "There is no patient record. Enter the admission informations of the patient.";
                isExist = false;
            }
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doctors = from dept in database.Departments
                                        from doc in dept.Doctors
                                        where dept.Dept_name == deptComboBox.Text
                                        select (String)doc.Doctor_name+" "+doc.Doctor_surname;

            if (doctors.Count() > 0)
                doctorComboBox.DataSource = doctors;
            else doctorComboBox.ResetText();
        }
    }
}

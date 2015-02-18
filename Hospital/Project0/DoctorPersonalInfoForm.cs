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
    public partial class DoctorPersonalInfoForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private String username;
        public DoctorPersonalInfoForm(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData()
        {
            var doc = from user in database.Users
                      from doctor in user.Doctors
                      where user.User_name == username
                      select doctor;

            doctorBindingSource.DataSource = doc;
        }
        
        private void DoctorPersonalInfoForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (doctor_nameTextBox.Text == "" || doctor_surnameTextBox.Text == "" || phoneTextBox.Text == "" || addressTextBox.Text == "")
                MessageBox.Show("You must enter data to fields.", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                Validate();
                doctorBindingSource.EndEdit();
                database.SubmitChanges();

                MessageBox.Show("Your changes have been saved successfully.", "Changed", MessageBoxButtons.OK);
            }
        }

    }
}

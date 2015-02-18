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
    public partial class UserSettings : Form
    {
        private String username;
        private HospitalDataContext database = new HospitalDataContext();
        public UserSettings(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void StaffUserSettings_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            userBindingSource.DataSource = from user in database.Users
                                           where user.User_name == username
                                           select user;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text=="")
                MessageBox.Show("Password field cannot be blank.", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (user_nameTextBox.Text == "")
                MessageBox.Show("Username field cannot be blank.", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Validate();
                userBindingSource.EndEdit();
                database.SubmitChanges();
                loadData();

                MessageBox.Show("Your changes have been saved successfully.","Changed",MessageBoxButtons.OK);
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
        }
    }
}

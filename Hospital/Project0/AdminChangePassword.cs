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
    public partial class AdminChangePassword : Form
    {
        private String username;
        private HospitalDataContext database = new HospitalDataContext();
        public AdminChangePassword(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void AdminChangePassword_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            var admin = from user in database.Users
                        where user.User_name == username
                        select user;
            if (admin.First().Password.Equals(passwordTextBox.Text))
            {
                if (!(newPasswordTextBox.Text.Equals(newPassword2TextBox.Text)))
                {
                    MessageBox.Show("New passwords are not equal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (newPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Password fields cannot be blank.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (User user in admin)
                    {
                        user.Password = newPasswordTextBox.Text;
                    }
                    database.SubmitChanges();
                    MessageBox.Show("Password successfully is changed.", "Password Changed", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("Wrong password, please type again your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

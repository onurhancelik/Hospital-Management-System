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
    public partial class LoginForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private int jobIndex; 

        public LoginForm()
        {
            InitializeComponent();
        }


        private bool ValidateLogin()
        {
            var inputLogin = from login in database.Users
                             where (login.Password == passwordTextBox.Text  && login.User_name == userNameTextBox.Text)
                             select login;

                if (inputLogin.Count() != 0)
                {
                    if (inputLogin.First().Job.Equals("Admin"))
                        jobIndex = 0;
                    else if (inputLogin.First().Job.Equals("Doctor"))
                        jobIndex = 1;
                    else if (inputLogin.First().Job == "Staff")
                        jobIndex = 2;

                    return true;
                }
                else return false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool flag;
            flag=ValidateLogin();

            if (flag == true)
            {
                if (jobIndex == 0)
                {
                    AdminForm admf = new AdminForm(userNameTextBox.Text);
                    admf.Show();
                }
                else if (jobIndex == 1)
                {
                    DoctorForm docf = new DoctorForm(userNameTextBox.Text);
                    docf.Show();
                }
                else if (jobIndex == 2)
                {
                    StaffForm stf = new StaffForm(userNameTextBox.Text);
                    stf.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is wrong, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

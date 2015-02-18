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
    public partial class StaffPersonalInfoForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private String username;
        public StaffPersonalInfoForm(String username)
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
            staffBindingSource.DataSource = from user in database.Users
                                            from staff in user.Staffs
                                            where user.User_name == username
                                            select staff;
        }

        private void StaffPersonalInfoForm_Load(object sender, EventArgs e)
        {
            loadData();                     
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || surnameTextBox.Text == "" || phoneTextBox.Text == "" || addressTextBox.Text == "")
                MessageBox.Show("You must enter data to fields.", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Validate();
                staffBindingSource.EndEdit();
                database.SubmitChanges();

                MessageBox.Show("Your changes have been saved successfully.", "Changed", MessageBoxButtons.OK);
            }
        }
    }
}

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
    public partial class StaffInfoExtendedForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private int staffID;
        public StaffInfoExtendedForm(int staffID)
        {
            InitializeComponent();
            this.staffID = staffID;
        }

        private void staffsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            staffsBindingSource.EndEdit();
            database.SubmitChanges();
        }

        private void StaffInfoExtendedForm_Load(object sender, EventArgs e)
        {
            staffsBindingSource.DataSource = from user in database.Users
                                             from staff in user.Staffs
                                             where staff.Staff_id == staffID
                                             select staff;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            User deletedUser = (from user in database.Users
                                from staff in user.Staffs
                                where staff.Staff_id == staffID
                                select user).First();

            database.Users.DeleteOnSubmit(deletedUser);
            database.SubmitChanges();
        }
    }
}

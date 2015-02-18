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
    public partial class DoctorInfoExtendedForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private int doctorID;
        public DoctorInfoExtendedForm(int doctorID)
        {
            InitializeComponent();
            this.doctorID = doctorID;
        }
        
        private void DoctorInfoExtendedForm_Load(object sender, EventArgs e)
        {

            var doc = from user in database.Users
                                              from doctor in user.Doctors
                                              where doctor.Doctor_id == doctorID
                                              select doctor;
            doctorsBindingSource.DataSource = doc;

            deptComboBox.DataSource = from dept in database.Departments
                                   select dept.Dept_name;

            deptComboBox.Text = "";
            deptComboBox.SelectedText = doc.First().Department.Dept_name;
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            doctorsBindingSource.EndEdit();
            database.SubmitChanges();

            var doctor = from doc in database.Doctors
                         where doc.Doctor_id == doctorID
                         select doc;
            if (doctor.Count() > 0)
            {
                if (!deptComboBox.Text.Equals(doctor.First().Department.Dept_name))
                {
                    Doctor myDoctor = (Doctor)doctor.First();

                    Department newDep = (from dept in database.Departments
                                         where dept.Dept_name == deptComboBox.Text
                                         select dept).First();

                    myDoctor.Department = newDep;
                    database.SubmitChanges();

                    doctorsBindingSource.DataSource = from user in database.Users
                                                      from doct in user.Doctors
                                                      where doct.Doctor_id == doctorID
                                                      select doct;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
                try
                {

                    User deletedUser = (from user in database.Users
                                         from doc in user.Doctors
                                        where doc.Doctor_id == doctorID
                                        select user).First();

                     database.Users.DeleteOnSubmit(deletedUser);
                     database.SubmitChanges();
                }

                catch (System.Exception exp)
                {
                    exp.ToString();
                    // handle generic exception
                }
        }
    }
}

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
    public partial class DepartmentInfoForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        public DepartmentInfoForm()
        {
            InitializeComponent();
        }

        public void count()
        {
            var doctorCounts = from dep in database.Departments
                               from doc in dep.Doctors
                               group doc by doc.Dept_id into d
                               select new { Department_ID = d.Key, DepartmentName=d.First().Department.Dept_name,NumberOfDoctors = d.Count() };

            dataGridView1.DataSource = doctorCounts;
        }

        private void DepartmentInfoForm_Load(object sender, EventArgs e)
        {
            count();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

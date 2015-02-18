using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project0
{
    public partial class DoctorInfo : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        public DoctorInfo()
        {
            InitializeComponent();
        }

        private void DoctorInfo_Load(object sender, EventArgs e)
        {
            doctorBindingSource.DataSource = from doctor in database.Doctors
                                             orderby doctor.Doctor_name, doctor.Doctor_surname
                                             select doctor;
            
        }

        private void doctorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedDoctorID = (int)doctorDataGridView[0, doctorDataGridView.CurrentRow.Index].Value;
            DoctorInfoExtendedForm dief = new DoctorInfoExtendedForm(selectedDoctorID);
            dief.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.DoctorInfo_Load(sender, e);
        }

    }
}

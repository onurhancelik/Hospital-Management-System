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
    public partial class InspectPatientForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private int admissionID;
        public InspectPatientForm(int admissionID)
        {
            InitializeComponent();
            this.admissionID = admissionID;
        }

        private void loadData()
        {
            patient_AdmissionBindingSource.DataSource = from patient in database.Patient_Admissions
                                                        where patient.Patient_ad_id == admissionID
                                                        select patient;
        }

        private void InspectPatientForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Validate();
            patient_AdmissionBindingSource.EndEdit();
            database.SubmitChanges();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

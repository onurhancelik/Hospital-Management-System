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
    public partial class StaffInfoForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        public StaffInfoForm()
        {
            InitializeComponent();
        }

        private void StaffInfoForm_Load(object sender, EventArgs e)
        {
            staffBindingSource.DataSource = from staff in database.Staffs
                                            orderby staff.Name,staff.Surname
                                            select staff;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.StaffInfoForm_Load(sender, e);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffInfoExtendedForm sief = new StaffInfoExtendedForm((int)staffDataGridView[0,staffDataGridView.CurrentRow.Index].Value);
            sief.ShowDialog();
        }
    }
}

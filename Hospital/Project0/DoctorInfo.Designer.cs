namespace Project0
{
    partial class DoctorInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorInfo));
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.doctoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AllowUserToAddRows = false;
            this.doctorDataGridView.AllowUserToDeleteRows = false;
            this.doctorDataGridView.AutoGenerateColumns = false;
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctoridDataGridViewTextBoxColumn,
            this.doctornameDataGridViewTextBoxColumn,
            this.doctorsurnameDataGridViewTextBoxColumn});
            this.doctorDataGridView.DataSource = this.doctorBindingSource;
            this.doctorDataGridView.Location = new System.Drawing.Point(23, 52);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.ReadOnly = true;
            this.doctorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorDataGridView.Size = new System.Drawing.Size(398, 197);
            this.doctorDataGridView.TabIndex = 0;
            this.doctorDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGridView_CellDoubleClick);
            // 
            // doctoridDataGridViewTextBoxColumn
            // 
            this.doctoridDataGridViewTextBoxColumn.DataPropertyName = "Doctor_id";
            this.doctoridDataGridViewTextBoxColumn.HeaderText = "Doctor_id";
            this.doctoridDataGridViewTextBoxColumn.Name = "doctoridDataGridViewTextBoxColumn";
            this.doctoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctornameDataGridViewTextBoxColumn
            // 
            this.doctornameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_name";
            this.doctornameDataGridViewTextBoxColumn.HeaderText = "Doctor_name";
            this.doctornameDataGridViewTextBoxColumn.Name = "doctornameDataGridViewTextBoxColumn";
            this.doctornameDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctornameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorsurnameDataGridViewTextBoxColumn
            // 
            this.doctorsurnameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_surname";
            this.doctorsurnameDataGridViewTextBoxColumn.HeaderText = "Doctor_surname";
            this.doctorsurnameDataGridViewTextBoxColumn.Name = "doctorsurnameDataGridViewTextBoxColumn";
            this.doctorsurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorsurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Project0.Doctor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL DOCTORS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please double click row that you would like to see and update information of doct" +
    "or.";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(406, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 31);
            this.closeButton.TabIndex = 33;
            this.toolTip1.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(369, 15);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(31, 32);
            this.refreshButton.TabIndex = 34;
            this.toolTip1.SetToolTip(this.refreshButton, "Refresh");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // DoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 293);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorDataGridView);
            this.Name = "DoctorInfo";
            this.Text = "Doctor Information";
            this.Load += new System.EventHandler(this.DoctorInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}
namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.worldSkillsDataSet = new Project.WorldSkillsDataSet();
            this.worldSkillsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTTableAdapter = new Project.WorldSkillsDataSetTableAdapters.EmployeeTTableAdapter();
            this.txtEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxPositionID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldSkillsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldSkillsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEmployeeID,
            this.txtName,
            this.cbxPositionID,
            this.txtOffice,
            this.txtAge});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // worldSkillsDataSet
            // 
            this.worldSkillsDataSet.DataSetName = "WorldSkillsDataSet";
            this.worldSkillsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worldSkillsDataSetBindingSource
            // 
            this.worldSkillsDataSetBindingSource.DataSource = this.worldSkillsDataSet;
            this.worldSkillsDataSetBindingSource.Position = 0;
            // 
            // employeeTBindingSource
            // 
            this.employeeTBindingSource.DataMember = "EmployeeT";
            this.employeeTBindingSource.DataSource = this.worldSkillsDataSetBindingSource;
            // 
            // employeeTTableAdapter
            // 
            this.employeeTTableAdapter.ClearBeforeFill = true;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.DataPropertyName = "EmployeeID";
            this.txtEmployeeID.HeaderText = "EmployeeID";
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            // 
            // cbxPositionID
            // 
            this.cbxPositionID.DataPropertyName = "PositionID";
            this.cbxPositionID.HeaderText = "PositionID";
            this.cbxPositionID.Name = "cbxPositionID";
            // 
            // txtOffice
            // 
            this.txtOffice.DataPropertyName = "Office";
            this.txtOffice.HeaderText = "Office";
            this.txtOffice.Name = "txtOffice";
            // 
            // txtAge
            // 
            this.txtAge.DataPropertyName = "Age";
            this.txtAge.HeaderText = "Age";
            this.txtAge.Name = "txtAge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldSkillsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldSkillsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource worldSkillsDataSetBindingSource;
        private WorldSkillsDataSet worldSkillsDataSet;
        private System.Windows.Forms.BindingSource employeeTBindingSource;
        private WorldSkillsDataSetTableAdapters.EmployeeTTableAdapter employeeTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxPositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAge;
    }
}


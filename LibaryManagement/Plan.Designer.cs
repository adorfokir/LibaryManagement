namespace LibaryManagement
{
    partial class Plan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.txtHand = new System.Windows.Forms.TextBox();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.dateValidity = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libary_ManagementDataSet3 = new LibaryManagement.Libary_ManagementDataSet3();
            this.planMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_MasterTableAdapter = new LibaryManagement.Libary_ManagementDataSet3TableAdapters.Plan_MasterTableAdapter();
            this.planIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateValidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plan Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Creation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book Can Hand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Validity:";
            // 
            // txtPlanID
            // 
            this.txtPlanID.Enabled = false;
            this.txtPlanID.Location = new System.Drawing.Point(171, 47);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.ReadOnly = true;
            this.txtPlanID.Size = new System.Drawing.Size(200, 20);
            this.txtPlanID.TabIndex = 6;
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(171, 86);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(200, 20);
            this.txtPlanName.TabIndex = 7;
            // 
            // txtHand
            // 
            this.txtHand.Location = new System.Drawing.Point(586, 49);
            this.txtHand.Name = "txtHand";
            this.txtHand.Size = new System.Drawing.Size(200, 20);
            this.txtHand.TabIndex = 10;
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(171, 118);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(200, 20);
            this.dateCreate.TabIndex = 12;
            // 
            // dateValidity
            // 
            this.dateValidity.Location = new System.Drawing.Point(586, 86);
            this.dateValidity.Name = "dateValidity";
            this.dateValidity.Size = new System.Drawing.Size(200, 20);
            this.dateValidity.TabIndex = 13;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(84, 185);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 31);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(244, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 31);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(419, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(575, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status:";
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.ddlStatus.Location = new System.Drawing.Point(586, 121);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(200, 21);
            this.ddlStatus.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planIDDataGridViewTextBoxColumn,
            this.planNameDataGridViewTextBoxColumn,
            this.dateCreateDataGridViewTextBoxColumn,
            this.bookHandDataGridViewTextBoxColumn,
            this.dateValidityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planMasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(94, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 169);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // libary_ManagementDataSet3
            // 
            this.libary_ManagementDataSet3.DataSetName = "Libary_ManagementDataSet3";
            this.libary_ManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planMasterBindingSource
            // 
            this.planMasterBindingSource.DataMember = "Plan_Master";
            this.planMasterBindingSource.DataSource = this.libary_ManagementDataSet3;
            // 
            // plan_MasterTableAdapter
            // 
            this.plan_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // planIDDataGridViewTextBoxColumn
            // 
            this.planIDDataGridViewTextBoxColumn.DataPropertyName = "Plan_ID";
            this.planIDDataGridViewTextBoxColumn.HeaderText = "Plan_ID";
            this.planIDDataGridViewTextBoxColumn.Name = "planIDDataGridViewTextBoxColumn";
            // 
            // planNameDataGridViewTextBoxColumn
            // 
            this.planNameDataGridViewTextBoxColumn.DataPropertyName = "Plan_Name";
            this.planNameDataGridViewTextBoxColumn.HeaderText = "Plan_Name";
            this.planNameDataGridViewTextBoxColumn.Name = "planNameDataGridViewTextBoxColumn";
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "Date_Create";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "Date_Create";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            // 
            // bookHandDataGridViewTextBoxColumn
            // 
            this.bookHandDataGridViewTextBoxColumn.DataPropertyName = "Book_Hand";
            this.bookHandDataGridViewTextBoxColumn.HeaderText = "Book_Hand";
            this.bookHandDataGridViewTextBoxColumn.Name = "bookHandDataGridViewTextBoxColumn";
            // 
            // dateValidityDataGridViewTextBoxColumn
            // 
            this.dateValidityDataGridViewTextBoxColumn.DataPropertyName = "Date_Validity";
            this.dateValidityDataGridViewTextBoxColumn.HeaderText = "Date_Validity";
            this.dateValidityDataGridViewTextBoxColumn.Name = "dateValidityDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(306, 251);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 21;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 498);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dateValidity);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.txtHand);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.txtPlanID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Plan";
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.TextBox txtHand;
        private System.Windows.Forms.DateTimePicker dateValidity;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Libary_ManagementDataSet3 libary_ManagementDataSet3;
        private System.Windows.Forms.BindingSource planMasterBindingSource;
        private Libary_ManagementDataSet3TableAdapters.Plan_MasterTableAdapter plan_MasterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateValidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblResult;
    }
}
namespace LibaryManagement
{
    partial class Sec_Rack_Map
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
            this.txtSecId = new System.Windows.Forms.TextBox();
            this.txtSecName = new System.Windows.Forms.TextBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libary_ManagementDataSet2 = new LibaryManagement.Libary_ManagementDataSet2();
            this.sectionRackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.section_RackTableAdapter = new LibaryManagement.Libary_ManagementDataSet2TableAdapters.Section_RackTableAdapter();
            this.secidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // txtSecId
            // 
            this.txtSecId.Enabled = false;
            this.txtSecId.Location = new System.Drawing.Point(156, 76);
            this.txtSecId.Name = "txtSecId";
            this.txtSecId.Size = new System.Drawing.Size(171, 20);
            this.txtSecId.TabIndex = 3;
            // 
            // txtSecName
            // 
            this.txtSecName.Location = new System.Drawing.Point(156, 113);
            this.txtSecName.Name = "txtSecName";
            this.txtSecName.Size = new System.Drawing.Size(171, 20);
            this.txtSecName.TabIndex = 4;
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.ddlStatus.Location = new System.Drawing.Point(156, 152);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(171, 21);
            this.ddlStatus.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(347, 76);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 38);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(347, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(442, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(442, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secidDataGridViewTextBoxColumn,
            this.secnameDataGridViewTextBoxColumn,
            this.secstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sectionRackBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // libary_ManagementDataSet2
            // 
            this.libary_ManagementDataSet2.DataSetName = "Libary_ManagementDataSet2";
            this.libary_ManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionRackBindingSource
            // 
            this.sectionRackBindingSource.DataMember = "Section_Rack";
            this.sectionRackBindingSource.DataSource = this.libary_ManagementDataSet2;
            // 
            // section_RackTableAdapter
            // 
            this.section_RackTableAdapter.ClearBeforeFill = true;
            // 
            // secidDataGridViewTextBoxColumn
            // 
            this.secidDataGridViewTextBoxColumn.DataPropertyName = "Sec_id";
            this.secidDataGridViewTextBoxColumn.HeaderText = "Sec_id";
            this.secidDataGridViewTextBoxColumn.Name = "secidDataGridViewTextBoxColumn";
            // 
            // secnameDataGridViewTextBoxColumn
            // 
            this.secnameDataGridViewTextBoxColumn.DataPropertyName = "Sec_name";
            this.secnameDataGridViewTextBoxColumn.HeaderText = "Sec_name";
            this.secnameDataGridViewTextBoxColumn.Name = "secnameDataGridViewTextBoxColumn";
            // 
            // secstatusDataGridViewTextBoxColumn
            // 
            this.secstatusDataGridViewTextBoxColumn.DataPropertyName = "Sec_status";
            this.secstatusDataGridViewTextBoxColumn.HeaderText = "Sec_status";
            this.secstatusDataGridViewTextBoxColumn.Name = "secstatusDataGridViewTextBoxColumn";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(207, 205);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 12;
            // 
            // Sec_Rack_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 419);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.txtSecName);
            this.Controls.Add(this.txtSecId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sec_Rack_Map";
            this.Text = "Sec_Rack_Map";
            this.Load += new System.EventHandler(this.Sec_Rack_Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRackBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecId;
        private System.Windows.Forms.TextBox txtSecName;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Libary_ManagementDataSet2 libary_ManagementDataSet2;
        private System.Windows.Forms.BindingSource sectionRackBindingSource;
        private Libary_ManagementDataSet2TableAdapters.Section_RackTableAdapter section_RackTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn secidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblResult;
    }
}
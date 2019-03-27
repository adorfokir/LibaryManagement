namespace LibaryManagement
{
    partial class Role
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddl_status = new System.Windows.Forms.ComboBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.libary_ManagementDataSet1 = new LibaryManagement.Libary_ManagementDataSet();
            this.lblResult = new System.Windows.Forms.Label();
            this.libaryManagementDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libary_ManagementDataSet11 = new LibaryManagement.Libary_ManagementDataSet1();
            this.roleMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.role_MasterTableAdapter = new LibaryManagement.Libary_ManagementDataSet1TableAdapters.Role_MasterTableAdapter();
            this.roleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libaryManagementDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(156, 45);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(211, 20);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name:";
            // 
            // txt_book_name
            // 
            this.txt_book_name.Location = new System.Drawing.Point(156, 90);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(211, 20);
            this.txt_book_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // ddl_status
            // 
            this.ddl_status.FormattingEnabled = true;
            this.ddl_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.ddl_status.Location = new System.Drawing.Point(156, 131);
            this.ddl_status.Name = "ddl_status";
            this.ddl_status.Size = new System.Drawing.Size(211, 21);
            this.ddl_status.TabIndex = 5;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(426, 41);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 47);
            this.btn_new.TabIndex = 6;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(534, 41);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 47);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(426, 109);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 44);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(534, 109);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 44);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // libary_ManagementDataSet1
            // 
            this.libary_ManagementDataSet1.DataSetName = "Libary_ManagementDataSet";
            this.libary_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(233, 188);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 10;
            // 
            // libaryManagementDataSet1BindingSource
            // 
            this.libaryManagementDataSet1BindingSource.DataSource = this.libary_ManagementDataSet1;
            this.libaryManagementDataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleidDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.rolestatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roleMasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(179, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 175);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // libary_ManagementDataSet11
            // 
            this.libary_ManagementDataSet11.DataSetName = "Libary_ManagementDataSet1";
            this.libary_ManagementDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleMasterBindingSource
            // 
            this.roleMasterBindingSource.DataMember = "Role_Master";
            this.roleMasterBindingSource.DataSource = this.libary_ManagementDataSet11;
            // 
            // role_MasterTableAdapter
            // 
            this.role_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // roleidDataGridViewTextBoxColumn
            // 
            this.roleidDataGridViewTextBoxColumn.DataPropertyName = "Role_id";
            this.roleidDataGridViewTextBoxColumn.HeaderText = "Role_id";
            this.roleidDataGridViewTextBoxColumn.Name = "roleidDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // rolestatusDataGridViewTextBoxColumn
            // 
            this.rolestatusDataGridViewTextBoxColumn.DataPropertyName = "Role_status";
            this.rolestatusDataGridViewTextBoxColumn.HeaderText = "Role_status";
            this.rolestatusDataGridViewTextBoxColumn.Name = "rolestatusDataGridViewTextBoxColumn";
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.ddl_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_book_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libaryManagementDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddl_status;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private Libary_ManagementDataSet libary_ManagementDataSet1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.BindingSource libaryManagementDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Libary_ManagementDataSet1 libary_ManagementDataSet11;
        private System.Windows.Forms.BindingSource roleMasterBindingSource;
        private Libary_ManagementDataSet1TableAdapters.Role_MasterTableAdapter role_MasterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolestatusDataGridViewTextBoxColumn;
    }
}
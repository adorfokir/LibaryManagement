namespace LibaryManagement
{
    partial class Book_In_Register
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
            this.ddlBook = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlSection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.libary_ManagementDataSet5 = new LibaryManagement.Libary_ManagementDataSet5();
            this.roleMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.role_MasterTableAdapter = new LibaryManagement.Libary_ManagementDataSet5TableAdapters.Role_MasterTableAdapter();
            this.libary_ManagementDataSet6 = new LibaryManagement.Libary_ManagementDataSet6();
            this.sectionRackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.section_RackTableAdapter = new LibaryManagement.Libary_ManagementDataSet6TableAdapters.Section_RackTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libary_ManagementDataSet7 = new LibaryManagement.Libary_ManagementDataSet7();
            this.bookInRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_In_RegisterTableAdapter = new LibaryManagement.Libary_ManagementDataSet7TableAdapters.Book_In_RegisterTableAdapter();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.libary_ManagementDataSet8 = new LibaryManagement.Libary_ManagementDataSet8();
            this.bookInRegisterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.book_In_RegisterTableAdapter1 = new LibaryManagement.Libary_ManagementDataSet8TableAdapters.Book_In_RegisterTableAdapter();
            this.libary_ManagementDataSet9 = new LibaryManagement.Libary_ManagementDataSet9();
            this.bookInRegisterBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.book_In_RegisterTableAdapter2 = new LibaryManagement.Libary_ManagementDataSet9TableAdapters.Book_In_RegisterTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInRegisterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInRegisterBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // ddlBook
            // 
            this.ddlBook.DataSource = this.roleMasterBindingSource;
            this.ddlBook.DisplayMember = "Role";
            this.ddlBook.FormattingEnabled = true;
            this.ddlBook.Location = new System.Drawing.Point(134, 101);
            this.ddlBook.Name = "ddlBook";
            this.ddlBook.Size = new System.Drawing.Size(198, 21);
            this.ddlBook.TabIndex = 2;
            this.ddlBook.ValueMember = "Role_id";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(134, 139);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(198, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Section:";
            // 
            // ddlSection
            // 
            this.ddlSection.DataSource = this.sectionRackBindingSource;
            this.ddlSection.DisplayMember = "Sec_name";
            this.ddlSection.FormattingEnabled = true;
            this.ddlSection.Location = new System.Drawing.Point(520, 56);
            this.ddlSection.Name = "ddlSection";
            this.ddlSection.Size = new System.Drawing.Size(198, 21);
            this.ddlSection.TabIndex = 5;
            this.ddlSection.ValueMember = "Sec_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book In Date:";
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(520, 102);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(200, 20);
            this.dateIn.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(49, 180);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 35);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(200, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(353, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(507, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // libary_ManagementDataSet5
            // 
            this.libary_ManagementDataSet5.DataSetName = "Libary_ManagementDataSet5";
            this.libary_ManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleMasterBindingSource
            // 
            this.roleMasterBindingSource.DataMember = "Role_Master";
            this.roleMasterBindingSource.DataSource = this.libary_ManagementDataSet5;
            // 
            // role_MasterTableAdapter
            // 
            this.role_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // libary_ManagementDataSet6
            // 
            this.libary_ManagementDataSet6.DataSetName = "Libary_ManagementDataSet6";
            this.libary_ManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionRackBindingSource
            // 
            this.sectionRackBindingSource.DataMember = "Section_Rack";
            this.sectionRackBindingSource.DataSource = this.libary_ManagementDataSet6;
            // 
            // section_RackTableAdapter
            // 
            this.section_RackTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.inDateDataGridViewTextBoxColumn,
            this.id});
            this.dataGridView1.DataSource = this.bookInRegisterBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(146, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // libary_ManagementDataSet7
            // 
            this.libary_ManagementDataSet7.DataSetName = "Libary_ManagementDataSet7";
            this.libary_ManagementDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookInRegisterBindingSource
            // 
            this.bookInRegisterBindingSource.DataMember = "Book_In_Register";
            this.bookInRegisterBindingSource.DataSource = this.libary_ManagementDataSet7;
            // 
            // book_In_RegisterTableAdapter
            // 
            this.book_In_RegisterTableAdapter.ClearBeforeFill = true;
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            this.bookDataGridViewTextBoxColumn.HeaderText = "Book";
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // inDateDataGridViewTextBoxColumn
            // 
            this.inDateDataGridViewTextBoxColumn.DataPropertyName = "In_Date";
            this.inDateDataGridViewTextBoxColumn.HeaderText = "In_Date";
            this.inDateDataGridViewTextBoxColumn.Name = "inDateDataGridViewTextBoxColumn";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(277, 229);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(134, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 15;
            // 
            // libary_ManagementDataSet8
            // 
            this.libary_ManagementDataSet8.DataSetName = "Libary_ManagementDataSet8";
            this.libary_ManagementDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookInRegisterBindingSource1
            // 
            this.bookInRegisterBindingSource1.DataMember = "Book_In_Register";
            this.bookInRegisterBindingSource1.DataSource = this.libary_ManagementDataSet8;
            // 
            // book_In_RegisterTableAdapter1
            // 
            this.book_In_RegisterTableAdapter1.ClearBeforeFill = true;
            // 
            // libary_ManagementDataSet9
            // 
            this.libary_ManagementDataSet9.DataSetName = "Libary_ManagementDataSet9";
            this.libary_ManagementDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookInRegisterBindingSource2
            // 
            this.bookInRegisterBindingSource2.DataMember = "Book_In_Register";
            this.bookInRegisterBindingSource2.DataSource = this.libary_ManagementDataSet9;
            // 
            // book_In_RegisterTableAdapter2
            // 
            this.book_In_RegisterTableAdapter2.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Book_In_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 462);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlSection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.ddlBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Book_In_Register";
            this.Text = "Book_In_Register";
            this.Load += new System.EventHandler(this.Book_In_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInRegisterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInRegisterBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlBook;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlSection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private Libary_ManagementDataSet5 libary_ManagementDataSet5;
        private System.Windows.Forms.BindingSource roleMasterBindingSource;
        private Libary_ManagementDataSet5TableAdapters.Role_MasterTableAdapter role_MasterTableAdapter;
        private Libary_ManagementDataSet6 libary_ManagementDataSet6;
        private System.Windows.Forms.BindingSource sectionRackBindingSource;
        private Libary_ManagementDataSet6TableAdapters.Section_RackTableAdapter section_RackTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Libary_ManagementDataSet7 libary_ManagementDataSet7;
        private System.Windows.Forms.BindingSource bookInRegisterBindingSource;
        private Libary_ManagementDataSet7TableAdapters.Book_In_RegisterTableAdapter book_In_RegisterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private Libary_ManagementDataSet8 libary_ManagementDataSet8;
        private System.Windows.Forms.BindingSource bookInRegisterBindingSource1;
        private Libary_ManagementDataSet8TableAdapters.Book_In_RegisterTableAdapter book_In_RegisterTableAdapter1;
        private Libary_ManagementDataSet9 libary_ManagementDataSet9;
        private System.Windows.Forms.BindingSource bookInRegisterBindingSource2;
        private Libary_ManagementDataSet9TableAdapters.Book_In_RegisterTableAdapter book_In_RegisterTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
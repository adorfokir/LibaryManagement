namespace LibaryManagement
{
    partial class Books_Outside
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
            this.ddlBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlSection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlMember = new System.Windows.Forms.ComboBox();
            this.ddlName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.libary_ManagementDataSet18 = new LibaryManagement.Libary_ManagementDataSet18();
            this.roleMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.role_MasterTableAdapter = new LibaryManagement.Libary_ManagementDataSet18TableAdapters.Role_MasterTableAdapter();
            this.libary_ManagementDataSet19 = new LibaryManagement.Libary_ManagementDataSet19();
            this.sectionRackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.section_RackTableAdapter = new LibaryManagement.Libary_ManagementDataSet19TableAdapters.Section_RackTableAdapter();
            this.libary_ManagementDataSet20 = new LibaryManagement.Libary_ManagementDataSet20();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ProfileTableAdapter = new LibaryManagement.Libary_ManagementDataSet20TableAdapters.User_ProfileTableAdapter();
            this.libary_ManagementDataSet21 = new LibaryManagement.Libary_ManagementDataSet21();
            this.planMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_MasterTableAdapter = new LibaryManagement.Libary_ManagementDataSet21TableAdapters.Plan_MasterTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libary_ManagementDataSet22 = new LibaryManagement.Libary_ManagementDataSet22();
            this.bookOutsideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_OutsideTableAdapter = new LibaryManagement.Libary_ManagementDataSet22TableAdapters.Book_OutsideTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOutsideBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book:";
            // 
            // ddlBook
            // 
            this.ddlBook.DataSource = this.roleMasterBindingSource;
            this.ddlBook.DisplayMember = "Role";
            this.ddlBook.FormattingEnabled = true;
            this.ddlBook.Location = new System.Drawing.Point(93, 94);
            this.ddlBook.Name = "ddlBook";
            this.ddlBook.Size = new System.Drawing.Size(199, 21);
            this.ddlBook.TabIndex = 1;
            this.ddlBook.ValueMember = "Role_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Section:";
            // 
            // ddlSection
            // 
            this.ddlSection.DataSource = this.sectionRackBindingSource;
            this.ddlSection.DisplayMember = "Sec_name";
            this.ddlSection.FormattingEnabled = true;
            this.ddlSection.Location = new System.Drawing.Point(93, 131);
            this.ddlSection.Name = "ddlSection";
            this.ddlSection.Size = new System.Drawing.Size(199, 21);
            this.ddlSection.TabIndex = 3;
            this.ddlSection.ValueMember = "Sec_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Member:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Plan Name:";
            // 
            // ddlMember
            // 
            this.ddlMember.DataSource = this.userProfileBindingSource;
            this.ddlMember.DisplayMember = "Name";
            this.ddlMember.FormattingEnabled = true;
            this.ddlMember.Location = new System.Drawing.Point(484, 55);
            this.ddlMember.Name = "ddlMember";
            this.ddlMember.Size = new System.Drawing.Size(200, 21);
            this.ddlMember.TabIndex = 6;
            this.ddlMember.ValueMember = "User_ID";
            // 
            // ddlName
            // 
            this.ddlName.DataSource = this.planMasterBindingSource;
            this.ddlName.DisplayMember = "Plan_Name";
            this.ddlName.FormattingEnabled = true;
            this.ddlName.Location = new System.Drawing.Point(484, 94);
            this.ddlName.Name = "ddlName";
            this.ddlName.Size = new System.Drawing.Size(200, 21);
            this.ddlName.TabIndex = 7;
            this.ddlName.ValueMember = "Plan_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Book Out Date:";
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(484, 132);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(200, 20);
            this.dateOut.TabIndex = 9;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(41, 184);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 32);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(170, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(306, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(437, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(93, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 15;
            // 
            // libary_ManagementDataSet18
            // 
            this.libary_ManagementDataSet18.DataSetName = "Libary_ManagementDataSet18";
            this.libary_ManagementDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleMasterBindingSource
            // 
            this.roleMasterBindingSource.DataMember = "Role_Master";
            this.roleMasterBindingSource.DataSource = this.libary_ManagementDataSet18;
            // 
            // role_MasterTableAdapter
            // 
            this.role_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // libary_ManagementDataSet19
            // 
            this.libary_ManagementDataSet19.DataSetName = "Libary_ManagementDataSet19";
            this.libary_ManagementDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionRackBindingSource
            // 
            this.sectionRackBindingSource.DataMember = "Section_Rack";
            this.sectionRackBindingSource.DataSource = this.libary_ManagementDataSet19;
            // 
            // section_RackTableAdapter
            // 
            this.section_RackTableAdapter.ClearBeforeFill = true;
            // 
            // libary_ManagementDataSet20
            // 
            this.libary_ManagementDataSet20.DataSetName = "Libary_ManagementDataSet20";
            this.libary_ManagementDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userProfileBindingSource
            // 
            this.userProfileBindingSource.DataMember = "User_Profile";
            this.userProfileBindingSource.DataSource = this.libary_ManagementDataSet20;
            // 
            // user_ProfileTableAdapter
            // 
            this.user_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // libary_ManagementDataSet21
            // 
            this.libary_ManagementDataSet21.DataSetName = "Libary_ManagementDataSet21";
            this.libary_ManagementDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planMasterBindingSource
            // 
            this.planMasterBindingSource.DataMember = "Plan_Master";
            this.planMasterBindingSource.DataSource = this.libary_ManagementDataSet21;
            // 
            // plan_MasterTableAdapter
            // 
            this.plan_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.memberDataGridViewTextBoxColumn,
            this.planNameDataGridViewTextBoxColumn,
            this.bookOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookOutsideBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // libary_ManagementDataSet22
            // 
            this.libary_ManagementDataSet22.DataSetName = "Libary_ManagementDataSet22";
            this.libary_ManagementDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookOutsideBindingSource
            // 
            this.bookOutsideBindingSource.DataMember = "Book_Outside";
            this.bookOutsideBindingSource.DataSource = this.libary_ManagementDataSet22;
            // 
            // book_OutsideTableAdapter
            // 
            this.book_OutsideTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // memberDataGridViewTextBoxColumn
            // 
            this.memberDataGridViewTextBoxColumn.DataPropertyName = "Member";
            this.memberDataGridViewTextBoxColumn.HeaderText = "Member";
            this.memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            // 
            // planNameDataGridViewTextBoxColumn
            // 
            this.planNameDataGridViewTextBoxColumn.DataPropertyName = "Plan_Name";
            this.planNameDataGridViewTextBoxColumn.HeaderText = "Plan_Name";
            this.planNameDataGridViewTextBoxColumn.Name = "planNameDataGridViewTextBoxColumn";
            // 
            // bookOutDataGridViewTextBoxColumn
            // 
            this.bookOutDataGridViewTextBoxColumn.DataPropertyName = "Book_Out";
            this.bookOutDataGridViewTextBoxColumn.HeaderText = "Book_Out";
            this.bookOutDataGridViewTextBoxColumn.Name = "bookOutDataGridViewTextBoxColumn";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(186, 240);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 17;
            // 
            // Books_Outside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 439);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlName);
            this.Controls.Add(this.ddlMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlBook);
            this.Controls.Add(this.label1);
            this.Name = "Books_Outside";
            this.Text = "Books_Outside";
            this.Load += new System.EventHandler(this.Books_Outside_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOutsideBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlMember;
        private System.Windows.Forms.ComboBox ddlName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private Libary_ManagementDataSet18 libary_ManagementDataSet18;
        private System.Windows.Forms.BindingSource roleMasterBindingSource;
        private Libary_ManagementDataSet18TableAdapters.Role_MasterTableAdapter role_MasterTableAdapter;
        private Libary_ManagementDataSet19 libary_ManagementDataSet19;
        private System.Windows.Forms.BindingSource sectionRackBindingSource;
        private Libary_ManagementDataSet19TableAdapters.Section_RackTableAdapter section_RackTableAdapter;
        private Libary_ManagementDataSet20 libary_ManagementDataSet20;
        private System.Windows.Forms.BindingSource userProfileBindingSource;
        private Libary_ManagementDataSet20TableAdapters.User_ProfileTableAdapter user_ProfileTableAdapter;
        private Libary_ManagementDataSet21 libary_ManagementDataSet21;
        private System.Windows.Forms.BindingSource planMasterBindingSource;
        private Libary_ManagementDataSet21TableAdapters.Plan_MasterTableAdapter plan_MasterTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Libary_ManagementDataSet22 libary_ManagementDataSet22;
        private System.Windows.Forms.BindingSource bookOutsideBindingSource;
        private Libary_ManagementDataSet22TableAdapters.Book_OutsideTableAdapter book_OutsideTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblResult;
    }
}
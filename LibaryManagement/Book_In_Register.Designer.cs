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
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libary_ManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 103);
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
            this.ddlBook.Location = new System.Drawing.Point(134, 56);
            this.ddlBook.Name = "ddlBook";
            this.ddlBook.Size = new System.Drawing.Size(198, 21);
            this.ddlBook.TabIndex = 2;
            this.ddlBook.ValueMember = "Role_id";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(134, 102);
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
            this.btnNew.Location = new System.Drawing.Point(49, 165);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 35);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(191, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(332, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(472, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
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
            // Book_In_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 419);
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
    }
}
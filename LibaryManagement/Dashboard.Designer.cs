namespace LibaryManagement
{
    partial class Dashboard
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secttionRackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberTransectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksOutsideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.inventToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(815, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleToolStripMenuItem,
            this.secttionRackToolStripMenuItem,
            this.protfolioToolStripMenuItem,
            this.planToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.roleToolStripMenuItem.Text = "Book Add";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // secttionRackToolStripMenuItem
            // 
            this.secttionRackToolStripMenuItem.Name = "secttionRackToolStripMenuItem";
            this.secttionRackToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.secttionRackToolStripMenuItem.Text = "Section Rack Add";
            this.secttionRackToolStripMenuItem.Click += new System.EventHandler(this.secttionRackToolStripMenuItem_Click);
            // 
            // protfolioToolStripMenuItem
            // 
            this.protfolioToolStripMenuItem.Name = "protfolioToolStripMenuItem";
            this.protfolioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.protfolioToolStripMenuItem.Text = "Member Profile";
            this.protfolioToolStripMenuItem.Click += new System.EventHandler(this.protfolioToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.planToolStripMenuItem.Text = "Plan Add";
            this.planToolStripMenuItem.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // inventToolStripMenuItem
            // 
            this.inventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInRegisterToolStripMenuItem,
            this.memberTransectionToolStripMenuItem,
            this.booksOutsideToolStripMenuItem});
            this.inventToolStripMenuItem.Name = "inventToolStripMenuItem";
            this.inventToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.inventToolStripMenuItem.Text = "Inventry";
            // 
            // bookInRegisterToolStripMenuItem
            // 
            this.bookInRegisterToolStripMenuItem.Name = "bookInRegisterToolStripMenuItem";
            this.bookInRegisterToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.bookInRegisterToolStripMenuItem.Text = "Book In Register";
            this.bookInRegisterToolStripMenuItem.Click += new System.EventHandler(this.bookInRegisterToolStripMenuItem_Click);
            // 
            // memberTransectionToolStripMenuItem
            // 
            this.memberTransectionToolStripMenuItem.Name = "memberTransectionToolStripMenuItem";
            this.memberTransectionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.memberTransectionToolStripMenuItem.Text = "Book Out Register";
            this.memberTransectionToolStripMenuItem.Click += new System.EventHandler(this.memberTransectionToolStripMenuItem_Click);
            // 
            // booksOutsideToolStripMenuItem
            // 
            this.booksOutsideToolStripMenuItem.Name = "booksOutsideToolStripMenuItem";
            this.booksOutsideToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.booksOutsideToolStripMenuItem.Text = "Books Outside";
            this.booksOutsideToolStripMenuItem.Click += new System.EventHandler(this.booksOutsideToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(815, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(57, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Libray Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "For Using This System Go To Menu";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secttionRackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberTransectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksOutsideToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}




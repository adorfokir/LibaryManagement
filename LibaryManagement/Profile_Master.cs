﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibaryManagement
{
    public partial class Profile_Master : Form
    {
        public Profile_Master()
        {
            InitializeComponent();
            CreateNew();
        }
        
        //New Button
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            ddlStatus.SelectedIndex = -1;
            CreateNew();
        }

        //Random Number Generate
        void CreateNew()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_User", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
        }
        //Data Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            txtID.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            ddlStatus.SelectedIndex = -1;
            CreateNew();
            lblResult.Text = "Data Save Successfully!!";
        }

        //Add Data In Database
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[User_Profile]
           ([User_ID]
           ,[Name]
           ,[Email]
           ,[Mobile]
           ,[Address]
           ,[Status])
     VALUES
           ('" + txtID.Text + "','" + txtName.Text + "','" + txtEmail.Text + "','"+txtMobile.Text+"','"+txtAddress.Text+"','"+ddlStatus.Text+"')", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from User_Profile", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
        }

        private void Profile_Master_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet4.User_Profile' table. You can move, or remove it, as needed.
            this.user_ProfileTableAdapter.Fill(this.libary_ManagementDataSet4.User_Profile);

        }
        //Data Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[User_Profile]
   SET[Name] = '" + txtName.Text + "',[Email] = '" + txtEmail.Text + "',[Mobile] = '"+txtMobile.Text+"',[Address] = '"+txtAddress.Text+"',[Status] = '"+ddlStatus.Text+ "'WHERE [User_ID] = '" + txtID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from User_Profile", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Update Successfully!!";
            txtID.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            ddlStatus.SelectedIndex = -1;
            CreateNew();
        }
        //Duble Click Show Data
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            txtID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            txtMobile.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            ddlStatus.SelectedItem = dataGridView1.Rows[n].Cells[5].Value.ToString();
        }
        //Data Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From[User_Profile] WHERE [User_ID] = '" + txtID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from User_Profile", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Delete Successfully!!";
            txtID.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            ddlStatus.SelectedIndex = -1;
            CreateNew();
        }
    }
}

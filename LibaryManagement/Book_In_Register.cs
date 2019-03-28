using System;
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
    public partial class Book_In_Register : Form
    {
        public Book_In_Register()
        {
            InitializeComponent();
        }

        private void Book_In_Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet9.Book_In_Register' table. You can move, or remove it, as needed.
            this.book_In_RegisterTableAdapter2.Fill(this.libary_ManagementDataSet9.Book_In_Register);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet8.Book_In_Register' table. You can move, or remove it, as needed.
            this.book_In_RegisterTableAdapter1.Fill(this.libary_ManagementDataSet8.Book_In_Register);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet7.Book_In_Register' table. You can move, or remove it, as needed.
            this.book_In_RegisterTableAdapter.Fill(this.libary_ManagementDataSet7.Book_In_Register);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet6.Section_Rack' table. You can move, or remove it, as needed.
            this.section_RackTableAdapter.Fill(this.libary_ManagementDataSet6.Section_Rack);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet5.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter.Fill(this.libary_ManagementDataSet5.Role_Master);

        }
        //For New
        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }
        //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            lblResult.Text = "Data Save Successfully!!";

        }
        //Add Data In Database
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Book_In_Register]
           ([Book]
           ,[Section]
           ,[Quantity]
           ,[In_Date])
     VALUES
           ('" + ddlBook.Text + "','" + ddlSection.Text + "','" + txtQuantity.Text + "','"+dateIn.Text+"')", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_In_Register", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
        }
        //Double Click Data Show
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            ddlBook.SelectedItem = dataGridView1.Rows[n].Cells[0].Value.ToString();
            ddlSection.SelectedItem = dataGridView1.Rows[n].Cells[1].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            dateIn.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
           txtID.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
        }
        //Data Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Book_In_Register]
   SET[Book] = '" + ddlBook.Text + "',[Section] = '" + ddlSection.Text + "',[Quantity] = '"+txtQuantity.Text+ "',[In_Date] = '"+dateIn.Text+"' WHERE [id] = '" + txtID.Text.ToString() + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_In_Register", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Update Successfully!!";
        }
        //Data Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From[Book_In_Register] WHERE [id] = '" + txtID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_In_Register", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Delete Successfully!!";
        }
    }
}

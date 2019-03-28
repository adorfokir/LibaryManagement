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
    public partial class Book_Out_Register : Form
    {
        public Book_Out_Register()
        {
            InitializeComponent();
        }
        //Data New
        private void btnNew_Click(object sender, EventArgs e)
        {

        }
        //Data From Database
        private void Book_Out_Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet17.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter3.Fill(this.libary_ManagementDataSet17.Role_Master);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet16.Section_Rack' table. You can move, or remove it, as needed.
            this.section_RackTableAdapter2.Fill(this.libary_ManagementDataSet16.Section_Rack);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet15.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter2.Fill(this.libary_ManagementDataSet15.Role_Master);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet14.Section_Rack' table. You can move, or remove it, as needed.
            this.section_RackTableAdapter1.Fill(this.libary_ManagementDataSet14.Section_Rack);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet13.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter1.Fill(this.libary_ManagementDataSet13.Role_Master);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet12.Book_Out_Register' table. You can move, or remove it, as needed.
            this.book_Out_RegisterTableAdapter.Fill(this.libary_ManagementDataSet12.Book_Out_Register);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet11.Section_Rack' table. You can move, or remove it, as needed.
            this.section_RackTableAdapter.Fill(this.libary_ManagementDataSet11.Section_Rack);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet10.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter.Fill(this.libary_ManagementDataSet10.Role_Master);

        }
        //Data Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            lblResult.Text = "Data Save Successfully!!";
        }
        //Add Data In Database
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Book_Out_Register]
           ([Book]
           ,[Section]
           ,[Quantity]
           ,[Out_Date])
     VALUES
           ('" + ddlBook.Text + "','" + ddlSection.Text + "','" + txtQuantity.Text + "','" + dateOut.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_Out_Register", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
        }
        //DOuble Click Data Show
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            txtID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            ddlBook.SelectedItem = dataGridView1.Rows[n].Cells[1].Value.ToString();
            ddlSection.SelectedItem = dataGridView1.Rows[n].Cells[2].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            dateOut.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            
        }
        //Data Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Book_Out_Register]
   SET[Book] = '" + ddlBook.Text + "',[Section] = '" + ddlSection.Text + "',[Quantity] = '" + txtQuantity.Text + "',[Out_Date] = '" + dateOut.Text + "' WHERE [id] = '" + txtID.Text.ToString() + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_Out_Register", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Update Successfully!!";
        }
        //Data Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From[Book_Out_Register] WHERE [id] = '" + txtID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_Out_Register", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Delete Successfully!!";
        }
    }
}

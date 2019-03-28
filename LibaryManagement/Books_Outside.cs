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
    public partial class Books_Outside : Form
    {
        public Books_Outside()
        {
            InitializeComponent();
        }
        //New
        private void btnNew_Click(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Book_Outside]
           ([Book]
           ,[Section]
           ,[Member]
           ,[Plan_Name]
            ,[Book_Out])
     VALUES
           ('" + ddlBook.Text + "','" + ddlSection.Text + "','" + ddlMember.Text + "','" + ddlName.Text + "','"+dateOut.Text+"')", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_Outside", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
        }

        private void Books_Outside_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet22.Book_Outside' table. You can move, or remove it, as needed.
            this.book_OutsideTableAdapter.Fill(this.libary_ManagementDataSet22.Book_Outside);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet21.Plan_Master' table. You can move, or remove it, as needed.
            this.plan_MasterTableAdapter.Fill(this.libary_ManagementDataSet21.Plan_Master);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet20.User_Profile' table. You can move, or remove it, as needed.
            this.user_ProfileTableAdapter.Fill(this.libary_ManagementDataSet20.User_Profile);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet19.Section_Rack' table. You can move, or remove it, as needed.
            this.section_RackTableAdapter.Fill(this.libary_ManagementDataSet19.Section_Rack);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet18.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter.Fill(this.libary_ManagementDataSet18.Role_Master);

        }
        //Double Click Data Show
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            txtID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            ddlBook.SelectedItem = dataGridView1.Rows[n].Cells[1].Value.ToString();
            ddlSection.SelectedItem = dataGridView1.Rows[n].Cells[2].Value.ToString();
            ddlMember.SelectedItem = dataGridView1.Rows[n].Cells[3].Value.ToString();
            ddlName.SelectedItem = dataGridView1.Rows[n].Cells[4].Value.ToString();
            dateOut.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
        }
        //Data Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Book_Outside]
   SET[Book] = '" + ddlBook.Text + "',[Section] = '" + ddlSection.Text + "',[Member] = '" + ddlMember.Text + "',[Plan_Name] = '" + ddlName.Text + "',[Book_Out] = '"+dateOut.Text+"' WHERE [id] = '" + txtID.Text.ToString() + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_Outside", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Update Successfully!!";
        }
        //Data Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From[Book_Outside] WHERE [id] = '" + txtID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Book_Outside", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Delete Successfully!!";
        }
    }
}

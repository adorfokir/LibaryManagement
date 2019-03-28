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
    public partial class Sec_Rack_Map : Form
    {
        public Sec_Rack_Map()
        {
            InitializeComponent();
            CreateNew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sec_Rack_Map_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet2.Section_Rack' table. You can move, or remove it, as needed.
            this.section_RackTableAdapter.Fill(this.libary_ManagementDataSet2.Section_Rack);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSecId.Clear();
            txtSecName.Clear();
            ddlStatus.SelectedIndex = -1;
            CreateNew();
            txtSecName.Focus();
        }

        //Random Number Generate
        void CreateNew()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Section_Rack", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtSecId.Text = dt.Rows[0][0].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            txtSecId.Clear();
            txtSecName.Clear();
            ddlStatus.SelectedIndex = -1;
            lblResult.Text = "Save Successfully !!";
        }

        //Add Data In Database
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Section_Rack]
           ([Sec_id]
           ,[Sec_name]
           ,[Sec_status])
     VALUES
           ('" + txtSecId.Text + "','" + txtSecName.Text + "','" + ddlStatus.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Section_Rack", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
        }

        //Double Click Show Data
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            txtSecId.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            txtSecName.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            ddlStatus.SelectedItem = dataGridView1.Rows[n].Cells[2].Value.ToString();
        }

        //Update Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Section_Rack]
   SET[Sec_name] = '" + txtSecName.Text + "',[Sec_status] = '" + ddlStatus.Text + "'WHERE [Sec_id] = '" + txtSecId.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Section_Rack", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Update Successfully!!";
            txtSecId.Clear();
            txtSecName.Clear();
            ddlStatus.SelectedIndex = -1;
        }

        //Delete Data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From[Section_Rack] WHERE [Sec_id] = '" + txtSecId.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Section_Rack", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Delete Successfully!!";
            txtSecId.Clear();
            txtSecName.Clear();
            ddlStatus.SelectedIndex = -1;
        }
    }
}

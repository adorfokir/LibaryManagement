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
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
        }
        //New For Data
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPlanID.Clear();
            txtPlanName.Clear();
            txtHand.Clear();
            ddlStatus.SelectedIndex = -1;
            CreateNew();
        }
        //Random Number Generate
        void CreateNew()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Plan", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtPlanID.Text = dt.Rows[0][0].ToString();
        }
        //Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            lblResult.Text = "Plan Save Successfully!!";
        }

        //Add Data In Database
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Plan_Master]
           ([Plan_ID]
           ,[Plan_Name]
           ,[Date_Create]
           ,[Book_Hand]
           ,[Date_Validity]
,[Status])
     VALUES
           ('" + txtPlanID.Text + "','" + txtPlanName.Text + "','" + dateCreate.Text + "','"+txtHand.Text+"','"+dateValidity.Text+"','"+ddlStatus.Text+"')", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Plan_Master", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet3.Plan_Master' table. You can move, or remove it, as needed.
            this.plan_MasterTableAdapter.Fill(this.libary_ManagementDataSet3.Plan_Master);

        }
        //Update Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Plan_Master]
   SET[Plan_Name] = '" + txtPlanName.Text + "',[Date_Create] = '" + dateCreate.Text + "',[Book_Hand] = '"+txtHand.Text+ "',[Date_Validity] = '"+dateValidity.Text+ "',[Status] = '"+ddlStatus.Text+ "'WHERE [Plan_ID] = '" + txtPlanID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Plan_Master", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Update Successfully!!";
        }
        //Double Click Data Show
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            txtPlanID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            txtPlanName.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            dateCreate.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            txtHand.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            dateValidity.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            ddlStatus.SelectedItem = dataGridView1.Rows[n].Cells[5].Value.ToString();
        }
        //Delete Data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From[Plan_Master] WHERE [Plan_ID] = '" + txtPlanID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Plan_Master", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Delete Successfully!!";
        }
    }
}

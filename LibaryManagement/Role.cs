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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
                       
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_book_name.Clear();
            ddl_status.SelectedIndex = -1;            
            CreateNew();
            txt_id.Focus();
            lblResult.Text = "";
        }

        //Random Number Generate
        void CreateNew()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Role",con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            AddRecords();
            txt_id.Clear();
            txt_book_name.Clear();
            ddl_status.SelectedIndex = -1;
            lblResult.Text = "Data Save Successfully!!";


            
        }
        //Add Data In Database
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Role_Master]
           ([Role_id]
           ,[Role]
           ,[Role_status])
     VALUES
           ('"+txt_id.Text+"','"+txt_book_name.Text+"','"+ddl_status.Text+"')",con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Role_Master", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
        }

       

        private void Role_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet11.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter.Fill(this.libary_ManagementDataSet11.Role_Master);

        }
        //Data Double Click Show On Box
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            txt_id.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            txt_book_name.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            ddl_status.SelectedItem = dataGridView1.Rows[n].Cells[2].Value.ToString();
        }
        //Update Data
        private void btn_update_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Role_Master]
   SET[Role] = '"+txt_book_name.Text+"',[Role_status] = '"+ddl_status.Text+ "'WHERE [Role_id] = '" + txt_id.Text + "'",con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Role_Master", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Update Successfully!!";
        }
        //Delete Data
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From[Role_Master] WHERE [Role_id] = '" + txt_id.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
            DataTable bt = new DataTable();
            SqlDataAdapter br = new SqlDataAdapter("select * from Role_Master", con.ActiveCon());
            br.Fill(bt);
            dataGridView1.DataSource = bt;
            lblResult.Text = "Delete Successfully!!";
        }
    }
}

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
    }
}

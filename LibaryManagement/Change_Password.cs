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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }
        Login lg = new Login();
        //Password Change
        private void btnChange_Click(object sender, EventArgs e)
        {
            String ID = lg.getID();
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Profile_Master]
   SET [Pro_Password] = '" + txtNew.Text + "' WHERE [id] =" + ID, con.ActiveCon());
            cmd.ExecuteNonQuery();
            lblResult.Text = "Password Update Successfully !!";


        }
    }
}

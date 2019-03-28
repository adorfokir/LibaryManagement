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
    public partial class Login : Form
    {
        //sql connection 
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-BJS3K5M;Initial Catalog=Libary_Management;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string ID_BY_LOGIN;
        public string getID()
        {
            return ID_BY_LOGIN;
        }
        private void btnLogin(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Profile_Master where Pro_User_id='"+txtName.Text+ "' and Pro_Password='"+txtPass.Text+"'",con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                SqlCommand cmd = new SqlCommand("select ID from Profile_Master where Pro_User_id='" + txtName.Text + "' and Pro_Password='" + txtPass.Text + "'", con.ActiveCon());

                ID_BY_LOGIN = cmd.ExecuteScalar().ToString();
                //Click Button Show The Dashboard
                Dashboard obj = new Dashboard();
                obj.Show();
                //Hide The Login Form
                this.Hide();
            }
            else
            {
                //MessageBox.Show("Invalid UserName Or Password","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
				 MessageBox.Show("Invalid UserName Or Password!","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
				// ------------------------------ change sometings
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            //Click Button Show The Dashboard
            Dashboard obj = new Dashboard();
            obj.Show();
            //Hide The Login Form
            this.Hide();
        }
    }
}

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
    public partial class Book_In_Register : Form
    {
        public Book_In_Register()
        {
            InitializeComponent();
        }

        private void Book_In_Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libary_ManagementDataSet6.Section_Rack' table. You can move, or remove it, as needed.
            this.section_RackTableAdapter.Fill(this.libary_ManagementDataSet6.Section_Rack);
            // TODO: This line of code loads data into the 'libary_ManagementDataSet5.Role_Master' table. You can move, or remove it, as needed.
            this.role_MasterTableAdapter.Fill(this.libary_ManagementDataSet5.Role_Master);

        }
    }
}

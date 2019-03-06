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
    public partial class Dashboard : Form
    {
        private int childFormNumber = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }  

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role obj = new Role();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Whole Application Will Be Closed
            Application.Exit();            
        }

        private void protfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile_Master obj = new Profile_Master();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Master obj = new Member_Master();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan obj = new Plan();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rack obj = new Rack();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section obj = new Section();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void secttionRackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sec_Rack_Map obj = new Sec_Rack_Map();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password obj = new Change_Password();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase obj = new Purchase();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void bookInRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_In_Register obj = new Book_In_Register();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void memberTransectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Out_Register obj = new Book_Out_Register();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void memberTransectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Member_Transection obj = new Member_Transection();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }
    }
}

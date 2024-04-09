using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form
{
    public partial class MainForm : Form


    {
        ToolClass tool = new ToolClass();
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();

        }

        //create a function to display tool count
        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Teljes készlet : " + tool.totalTools();
            label_maleStd.Text = "Szerszám : " + tool.toolCount();
            label_femaleStd.Text = "Egyéb : " + tool.etcCount();

        }


        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
        
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        #region StdSubmenu
        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageToolForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintTool());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        #endregion StdSubmenu

        //to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show($"Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void button_registration_Click(object sender, EventArgs e)
		{
			openChildForm(new RegisterForm());
			//...
			//..Your code
			//...
			hideSubmenu();
		}
	}
}
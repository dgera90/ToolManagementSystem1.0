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
        StudentClass student = new StudentClass();
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();

        }

        //create a function to display student count
        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Teljes készlet : " + student.totalStudent();
            label_maleStd.Text = "Szerszám : " + student.maleStudent();
            label_femaleStd.Text = "Egyéb : " + student.femaleStudent();

        }


        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
        
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
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
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //...
            //..Your code
            //...
            hideSubmenu();
            
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
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
            openChildForm(new PrintStudent());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        #endregion StdSubmenu
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

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
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

	}
}
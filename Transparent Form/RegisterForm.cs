using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Security.Policy;

namespace Transparent_Form
{
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();
        public RegisterForm()
        {
            InitializeComponent();

        }

 

        //create a function to verify
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == ""))
            {
                return false;
            }
            else

                return true;
        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show student list in DatagridView
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `eszkozok`"));
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // add new student
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Szerszám" : "Egyéb";


            if (verify())
            {
                string eszkozadatok = ($"Biztosan hozzá kívánja adni a következő eszközt?\nNév: {fname}\nMéret: {lname}\nDarabszám: {phone}\nTípus: {gender}\nRészletek: {address}");
                DialogResult result = MessageBox.Show($"{eszkozadatok}", "Eszköz felvétele", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    try
                    {
                        // to get photo from picture box
                        if (student.InsertStudent(fname, lname, gender, phone, address))
                        {
                            showTable();
                            MessageBox.Show("Új bejegyzés hozzáadva!", "Sikeres hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Üres mező", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
        }
    }
}

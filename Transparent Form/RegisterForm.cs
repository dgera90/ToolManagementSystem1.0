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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Transparent_Form
{
    public partial class RegisterForm : Form
    {
        ToolClass tool = new ToolClass();
        DBconnect connect = new DBconnect();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void radioButton_tool_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton_tool.Checked)
            {
                try
                {
                    comboBox_name.Items.Clear();

                    string selectQuery = "SELECT `name` FROM `szerszam`";
                    connect.openConnect();
                    MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox_name.Items.Add(reader.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    comboBox_name.Items.Clear();

                    string selectQuery = "SELECT `name` FROM `egyeb`";
                    connect.openConnect();
                    MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox_name.Items.Add(reader.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            connect.closeConnect();

        }

        //create a function to verify
        bool verify()
        {
            if ((comboBox_name.Text == "") || (textBox_size.Text == "") ||
                (textBox_quantity.Text == ""))
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
        // To show tool list in DatagridView
        public void showTable()
        {
            DataGridView_tool.DataSource = tool.getToollist(new MySqlCommand("SELECT * FROM `eszkozok`"));
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // add new tool
            string name = comboBox_name.Text;
            string size = textBox_size.Text.Replace(",", "."); ;
            string quantity = textBox_quantity.Text;
            string details = textBox_details.Text;
            string type = radioButton_tool.Checked ? "Szerszám" : "Egyéb";


            if (verify())
            {

                string eszkozadatok = ($"Biztosan hozzá kívánja adni a következő eszközt?\nNév: {name}\nMéret: {size}\nDarabszám: {quantity}\nTípus: {type}\nRészletek: {details}");
                DialogResult result = MessageBox.Show($"{eszkozadatok}", "Eszköz felvétele", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    try
                    {
                       
                        if (tool.InsertTool(name, size, type, quantity, details))
                        {
                            showTable();
                            MessageBox.Show("Új bejegyzés hozzáadva!", "Sikeres hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox_size.Clear();
                            textBox_quantity.Clear();
                            textBox_details.Clear();
                            radioButton_tool.Checked = false;
                            radioButton_etc.Checked = false;
                            comboBox_name.Items.Clear();
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
            textBox_size.Clear();
            textBox_quantity.Clear();
            textBox_details.Clear();
            radioButton_tool.Checked = false;
            radioButton_etc.Checked = false;
            comboBox_name.Items.Clear();

        }

        private void button_addName_Click(object sender, EventArgs e)
        {
            ModifyName myForm = new ModifyName();            
            myForm.Show();
        }

        private void textBox_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (textBox_size.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

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

        public RegisterForm()
        {
            InitializeComponent();
            radioButton_tool.Checked = false;
        }

        private void radioButton_tool_CheckedChanged(object sender, EventArgs e)
        {
            string[] tools = {};
            string[] etc = {};

            if (radioButton_tool.Checked)
            {
                comboBox_name.Items.Clear();
                comboBox_name.Items.AddRange(tools);
                
            }
            else
            {
                comboBox_name.Items.Clear();
                comboBox_name.Items.AddRange(etc);
            }
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
            radioButton_tool.Checked = true;
        }

        private void button_addName_Click(object sender, EventArgs e)
        {
            ModifyName myForm = new ModifyName();            
            myForm.Show();
        }
    }
}

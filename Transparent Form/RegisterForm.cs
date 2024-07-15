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
            comboBox_forg.Enabled = false;
		}

        private void radioButton_tool_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton_tool.Checked)
            {
                try
                {
                    comboBox_name.Items.Clear();
					getForg();

					comboBox_forg.Enabled = true;
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
                    getForg();
					comboBox_forg.Enabled = true;

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
            if ((comboBox_forg.Text == "") || (textBox_cikkszam.Text == "") || (comboBox_name.Text == "") || (textBox_size.Text == "") ||
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
            int limit = Convert.ToInt32(numericUpDown_limit.Value);
            string forgalmazo = comboBox_forg.Text;
            double cikkszam = Convert.ToDouble(textBox_cikkszam.Text);


            if (verify())
            {

                string eszkozadatok = ($"Biztosan hozzá kívánja adni a következő eszközt?\nForgalmazó: {forgalmazo}\nCikkszám: {cikkszam}\nNév: {name}\nMéret: {size}\nDarabszám: {quantity}\nTípus: {type}\nRészletek: {details}\nLimit: {limit}");
                DialogResult result = MessageBox.Show($"{eszkozadatok}", "Eszköz felvétele", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    try
                    {
                       
                        if (tool.InsertTool(forgalmazo, cikkszam, name, size, type, quantity, details, limit))
                        {
                            showTable();
                            MessageBox.Show("Új bejegyzés hozzáadva!", "Sikeres hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox_size.Clear();
                            textBox_quantity.Clear();
                            textBox_details.Clear();
                            radioButton_tool.Checked = false;
                            radioButton_etc.Checked = false;
                            comboBox_name.Items.Clear();
                            numericUpDown_limit.Value = 1;
                            textBox_cikkszam.Clear();
                            comboBox_forg.SelectedIndex = 0;
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
            numericUpDown_limit.Value = 1;
        }

        private void button_addName_Click(object sender, EventArgs e)
        {
            ModifyName myForm = new ModifyName();            
            myForm.Show();
            radioButton_etc.Checked = false;
            radioButton_tool.Checked = false;
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

		private void textBox_quantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void button_forg_Click(object sender, EventArgs e)
		{
			Forgalmazo myForm = new Forgalmazo();
			myForm.Show();
			radioButton_etc.Checked = false;
			radioButton_tool.Checked = false;
		}

		private void RegisterForm_Layout(object sender, LayoutEventArgs e)
		{
			
		}

		private void RegisterForm_Shown(object sender, EventArgs e)
		{

				
			
		}
        public void getForg ()
        {
			try
			{
				comboBox_forg.Items.Clear();

				string selectQuery = "SELECT `name` FROM `forgalmazo`";
				connect.openConnect();
				MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox_forg.Items.Add(reader.GetString("name"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			connect.closeConnect();

		}

	}
}

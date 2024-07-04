using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form
{
    public partial class ModifyName : Form
    {
        DBconnect connect = new DBconnect();

        public ModifyName()
        {
            InitializeComponent();
        }
        private void radioButton_tool_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton_tool.Checked)
            {
                try
                {
                    comboBox_list.Items.Clear();

                    string selectQuery = "SELECT `name` FROM `szerszam`";
                    connect.openConnect();
                    MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox_list.Items.Add(reader.GetString("name"));
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
                    comboBox_list.Items.Clear();

                    string selectQuery = "SELECT `name` FROM `egyeb`";
                    connect.openConnect();
                    MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox_list.Items.Add(reader.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            connect.closeConnect();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {

         
                DialogResult result = MessageBox.Show("Valóban hozzá kívánja adni az eszközt?", "Hozzáadás", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (radioButton_tool.Checked)
                {
                    try
                    {

                        string selectQuery = ("INSERT INTO `szerszam`(name) VALUES (@name)");
                        connect.openConnect();
                        MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                        command.Parameters.AddWithValue("@name", textBox1.Text);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBox_list.Items.Add(reader.GetString("name"));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connect.closeConnect();
                    textBox1.Clear();
                    radioButton_etc.Checked = false;
                    radioButton_tool.Checked = false;
                    comboBox_list.Items.Clear();

                }
                else if (radioButton_etc.Checked)
                {
                    try
                    {

                        string selectQuery = ("INSERT INTO `egyeb`(name) VALUES (@name)");
                        connect.openConnect();
                        MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                        command.Parameters.AddWithValue("@name", textBox1.Text);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBox_list.Items.Add(reader.GetString("name"));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connect.closeConnect();
                    comboBox_list.Items.Clear();
                    textBox1.Clear();
                    radioButton_etc.Checked = false;
                    radioButton_tool.Checked = false;
                }
                MessageBox.Show("Sikeres hozzáadás!", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            comboBox_list.Items.Clear();
            }
            else
            {
                MessageBox.Show("Üres mező!","Hiba",MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void button_deleteTool_Click(object sender, EventArgs e)
        {
            if (comboBox_list.SelectedItem!=null)
            {

            
            if (radioButton_tool.Checked)
            {
                DialogResult result = MessageBox.Show("Valóban törölni kívánja az eszközt?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        string selectQuery = ("DELETE FROM `szerszam` WHERE @name=`name`");
                        connect.openConnect();
                        MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                        command.Parameters.AddWithValue("@name", comboBox_list.Text);
                        MySqlDataReader reader = command.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connect.closeConnect();

                    MessageBox.Show("Sikeres törlés!", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radioButton_etc.Checked = false;
                    radioButton_tool.Checked = false;
                }

                radioButton_etc.Checked = false;
                radioButton_tool.Checked = false;
                comboBox_list.Items.Clear();
                textBox1.Clear();
            }
            else if (radioButton_etc.Checked) {
                DialogResult result = MessageBox.Show("Valóban törölni kívánja a szerszámot?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        string selectQuery = ("DELETE FROM `egyeb` WHERE @name=`name`");
                        connect.openConnect();
                        MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                        command.Parameters.AddWithValue("@name", comboBox_list.Text);
                        MySqlDataReader reader = command.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connect.closeConnect();

                    MessageBox.Show("Sikeres törlés!", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radioButton_etc.Checked = false;
                    radioButton_tool.Checked = false;
                }

                radioButton_etc.Checked = false;
                radioButton_tool.Checked = false;
                comboBox_list.Items.Clear();
                textBox1.Clear();
            }
            }
            else
            {
                MessageBox.Show("Üres mező!","Hiba",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

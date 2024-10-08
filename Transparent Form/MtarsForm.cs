﻿using MySql.Data.MySqlClient;
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
    public partial class MtarsForm : Form
    {
        DBconnect connect = new DBconnect();

        public MtarsForm()
        {
            InitializeComponent();
            try
            {
                comboBox_lista.Items.Clear();

                string selectQuery = "SELECT `name` FROM `munkatars`";
                connect.openConnect();
                MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_lista.Items.Add(reader.GetString("name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.closeConnect();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (comboBox_lista.SelectedItem != null)
            {



                DialogResult result = MessageBox.Show("Valóban törölni kívánja a munkatársat?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        string selectQuery = ("DELETE FROM `munkatars` WHERE @name=`name`");
                        connect.openConnect();
                        MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                        command.Parameters.AddWithValue("@name", comboBox_lista.Text);
                        MySqlDataReader reader = command.ExecuteReader();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connect.closeConnect();

                    MessageBox.Show("Sikeres törlés!", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                comboBox_lista.Items.Clear();
                textBox1.Clear();
                try
                {
                    comboBox_lista.Items.Clear();

                    string selectQuery = "SELECT `name` FROM `munkatars`";
                    connect.openConnect();
                    MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox_lista.Items.Add(reader.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connect.closeConnect();
            }
            else
            {
                MessageBox.Show("Üres mező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {


                DialogResult result = MessageBox.Show("Valóban hozzá kívánja adni a munkatársat?", "Hozzáadás", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                        try
                        {

                            string selectQuery = ("INSERT INTO `munkatars`(name) VALUES (@name)");
                            connect.openConnect();
                            MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                            command.Parameters.AddWithValue("@name", textBox1.Text);
                            MySqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                comboBox_lista.Items.Add(reader.GetString("name"));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        connect.closeConnect();
                        textBox1.Clear();
                        comboBox_lista.Items.Clear();

                 }
                   
                    MessageBox.Show("Sikeres hozzáadás!", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_lista.Items.Clear();
                try
                {
                    comboBox_lista.Items.Clear();

                    string selectQuery = "SELECT `name` FROM `munkatars`";
                    connect.openConnect();
                    MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox_lista.Items.Add(reader.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connect.closeConnect();
            }
            else
            {
                MessageBox.Show("Üres mező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

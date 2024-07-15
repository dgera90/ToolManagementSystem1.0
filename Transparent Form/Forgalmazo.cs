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
	public partial class Forgalmazo : Form
	{
		DBconnect connect = new DBconnect();

		public Forgalmazo()
		{
			InitializeComponent();
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

		private void button_del_Click(object sender, EventArgs e)
		{
			if (comboBox_forg.SelectedItem != null)
			{



				DialogResult result = MessageBox.Show("Valóban törölni kívánja a forgalmazót?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					try
					{

						string selectQuery = ("DELETE FROM `forgalmazo` WHERE @name=`name`");
						connect.openConnect();
						MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
						command.Parameters.AddWithValue("@name", comboBox_forg.Text);
						MySqlDataReader reader = command.ExecuteReader();

					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					connect.closeConnect();

					MessageBox.Show("Sikeres törlés!", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}

				comboBox_forg.Items.Clear();
				textBox_forg.Clear();
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
			else
			{
				MessageBox.Show("Üres mező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			if (textBox_forg.Text != "")
			{


				DialogResult result = MessageBox.Show("Valóban hozzá kívánja adni a forgalmazót?", "Hozzáadás", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					try
					{

						string selectQuery = ("INSERT INTO `forgalmazo`(name) VALUES (@name)");
						connect.openConnect();
						MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
						command.Parameters.AddWithValue("@name", textBox_forg.Text);
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
					textBox_forg.Clear();
					comboBox_forg.Items.Clear();

				}

				MessageBox.Show("Sikeres hozzáadás!", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
				comboBox_forg.Items.Clear();
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
			else
			{
				MessageBox.Show("Üres mező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
	}


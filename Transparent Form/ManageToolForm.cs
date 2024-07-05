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
using System.Reflection.Emit;

namespace Transparent_Form
{
	public partial class ManageToolForm : Form

	{
        DBconnect connect = new DBconnect();

        ToolClass tool = new ToolClass();
		public ManageToolForm()
		{
			InitializeComponent();
			button_update.Visible = false;
			button_delete.Visible = false;
			button_clear.Visible = false;
		}

		private void ManageToolForm_Load(object sender, EventArgs e)
		{
			showTable();
			
		}
		// To show student list in DatagridView
		public void showTable()
		{
			DataGridView_tool.DataSource = tool.getToollist(new MySqlCommand("SELECT `id` AS Azonosító, `toolName` AS Név, `toolSize` AS Méret, `inDate` AS 'Felvétel ideje', `type` AS Típus, `quantity` AS Darabszám, `description` AS Részletek FROM `eszkozok`"));
			DataGridView_tool.ReadOnly = true;
			DataGridView_tool.Columns["Azonosító"].Visible = true;
        }

		//Display student data from student to textbox
		private void DataGridView_tool_Click(object sender, EventArgs e)
		{
			if (DataGridView_tool.Rows.Count>0)
			{

			
			textBox_id.Text = DataGridView_tool.CurrentRow.Cells[0].Value.ToString();
			textBox_name.Text = DataGridView_tool.CurrentRow.Cells[1].Value.ToString();
			textBox_size.Text = DataGridView_tool.CurrentRow.Cells[2].Value.ToString();

			dateTimePicker1.Value = (DateTime)DataGridView_tool.CurrentRow.Cells[3].Value;

                textBox_quantity.Text = DataGridView_tool.CurrentRow.Cells[5].Value.ToString();
			textBox_details.Text = DataGridView_tool.CurrentRow.Cells[6].Value.ToString();

			if (textBox_name.Text != "")
			{
				button_history.Visible = true;
				button_update.Visible = true;
				button_delete.Visible = true;
				button_clear.Visible = true;

				}
			}

            try
            {
                comboBox_mtars.Items.Clear();

                string selectQuery = "SELECT `name` FROM `munkatars`";
                connect.openConnect();
                MySqlCommand command = new MySqlCommand(selectQuery, connect.getconnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_mtars.Items.Add(reader.GetString("name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.closeConnect();
        }

		private void button_clear_Click(object sender, EventArgs e)
		{
			textBox_id.Clear();
			textBox_name.Clear();
			textBox_size.Clear();
			textBox_quantity.Clear();
			textBox_details.Clear();
			comboBox_mtars.Items.Clear();
			dateTimePicker1.Value = DateTime.Now;
			button_history.Visible = false;
            button_delete.Visible = false;
            button_update.Visible = false;
			button_clear.Visible = false;
        }

		private void button_search_Click(object sender, EventArgs e)
		{
			DataGridView_tool.DataSource = tool.searchTool(textBox_search.Text);
		}
		//create a function to verify
		bool verify()
		{
			if ((textBox_name.Text == "") || (textBox_size.Text == "") ||
				(textBox_quantity.Text == ""))
			{
				return false;
			}
			else
				return true;
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			// update student record
			int id = Convert.ToInt32(textBox_id.Text);
			string name = textBox_name.Text;
			string size = textBox_size.Text;
			string quantity = textBox_quantity.Text;
			string details = textBox_details.Text;
			string mtars = comboBox_mtars.Text;


			if (verify())
			{
					string eszkozadatok = ($"Biztosan módosítani kívánja a következő eszközt?\nNév: {name}\nMéret: {size}\nDarabszám: {quantity}\nRészletek: {details}\nMunkatárs: {mtars}");
					DialogResult result = MessageBox.Show($"{eszkozadatok}", "Eszköz felvétele", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						try
						{
							if (comboBox_mtars.Text != "")
							{

						
								if (tool.updateTool(id, name, size, quantity, details, mtars))
								{
									showTable();
									MessageBox.Show("Bejegyzés adatainak módosítása", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
									button_clear.PerformClick();
								}
							}
							else
							{
								MessageBox.Show("Munkatárs mező üres!","Hiba", MessageBoxButtons.OK);

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
				MessageBox.Show("Üres mező", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_size.Clear();
            textBox_quantity.Clear();
            textBox_details.Clear();
            dateTimePicker1.Value = DateTime.Now;
            button_history.Visible = false;
            button_update.Visible = false;
            button_delete.Visible = false;
			button_clear.Visible = false;
			comboBox_mtars.Items.Clear();

        }

        private void button_delete_Click(object sender, EventArgs e)
		{
			//remove the selected tool
			int id = Convert.ToInt32(textBox_id.Text);
			//Show a confirmation message before delete the tool
			if (MessageBox.Show("Biztosan eltávolítod a bejegyzést?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (tool.deleteTool(id))
				{
					showTable();
					MessageBox.Show("Bejegyzés eltávolítva.", "Sikeres törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
					button_clear.PerformClick();
				}
			}
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_size.Clear();
            textBox_quantity.Clear();
            textBox_details.Clear();
            dateTimePicker1.Value = DateTime.Now;
            button_history.Visible = false;
            button_update.Visible = false;
            button_delete.Visible = false;
            button_clear.Visible = false;
            comboBox_mtars.Items.Clear();
        }

		private void button_history_Click(object sender, EventArgs e)
		{
			ToolClass.toolid = textBox_id.Text;
			History myForm = new History();
			int toolid = Convert.ToInt32(textBox_id.Text);
			myForm.Show();
		}
	}
	
	
	}


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
		ToolClass tool = new ToolClass();
		public ManageToolForm()
		{
			InitializeComponent();
			button_update.Enabled = false;
			button_delete.Enabled = false;
		}

		private void ManageToolForm_Load(object sender, EventArgs e)
		{
			showTable();
			
		}
		// To show student list in DatagridView
		public void showTable()
		{
			DataGridView_tool.DataSource = tool.getToollist(new MySqlCommand("SELECT `id` AS Azonosító, `toolName` AS Név, `toolSize` AS Méret, `inDate` AS 'Felvétel ideje', `type` AS Típus, `quantity` AS Mennyiség, `description` AS Részletek FROM `eszkozok`"));
			DataGridView_tool.ReadOnly = true;
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
			if (DataGridView_tool.CurrentRow.Cells[4].Value.ToString() == "Szerszám")
				radioButton_tool.Checked = true;
             if (DataGridView_tool.CurrentRow.Cells[4].Value.ToString() == "Egyéb")
                radioButton_etc.Checked = true;

                textBox_quantity.Text = DataGridView_tool.CurrentRow.Cells[5].Value.ToString();
			textBox_details.Text = DataGridView_tool.CurrentRow.Cells[6].Value.ToString();

			if (textBox_name.Text != "")
			{
				button_history.Visible = true;
				button_update.Enabled = true;
				button_delete.Enabled = true;
			}
            }
        }

		private void button_clear_Click(object sender, EventArgs e)
		{
			textBox_id.Clear();
			textBox_name.Clear();
			textBox_size.Clear();
			textBox_quantity.Clear();
			textBox_details.Clear();
			radioButton_tool.Checked = true;
			dateTimePicker1.Value = DateTime.Now;
			button_history.Visible = false;
            button_delete.Enabled = false;
            button_update.Enabled = false;
        }

		private void button_search_Click(object sender, EventArgs e)
		{
			DataGridView_tool.DataSource = tool.searchTool(textBox_search.Text);
		}
		//create a function to verify
		bool verify()
		{
			if ((textBox_name.Text == "") || (textBox_size.Text == "") ||
				(textBox_quantity.Text == "") || (textBox_details.Text == ""))
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
			string type = radioButton_tool.Checked ? "Szerszám" : "Egyéb";
			string mtars = textBox_mtars.Text;


			if (verify())
			{
                string eszkozadatok = ($"Biztosan módosítani kívánja a következő eszközt?\nNév: {name}\nMéret: {size}\nDarabszám: {quantity}\nTípus: {type}\nRészletek: {details}\nMunkatárs: {mtars}");
                DialogResult result = MessageBox.Show($"{eszkozadatok}", "Eszköz felvétele", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					try
					{
						if (tool.updateTool(id, name, size, type, quantity, details, mtars))
						{
							showTable();
							MessageBox.Show("Bejegyzés adatainak módosítása", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
							button_clear.PerformClick();
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
            radioButton_tool.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            button_history.Visible = false;
            button_update.Enabled = false;
            button_delete.Enabled = false;
			textBox_mtars.Clear();

        }

        private void button_delete_Click(object sender, EventArgs e)
		{
			//remove the selected Student
			int id = Convert.ToInt32(textBox_id.Text);
			//Show a confirmation message before delete the student
			if (MessageBox.Show("Biztosan eltávolítod a bejegyzést?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (tool.deleteTool(id))
				{
					showTable();
					MessageBox.Show("Bejegyzés eltávolítva.", "Sikeres törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
					button_clear.PerformClick();
				}
			}
            button_delete.Enabled = false;
            button_update.Enabled = false;

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


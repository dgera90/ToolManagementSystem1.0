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
using Microsoft.VisualBasic;
using Guna.UI2.WinForms.Suite;
using System.Web.Configuration;
using System.Management;

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
			button_out.Visible = false;
			numericUpDown_qua.Visible = false;
            showTable();
            numericUpDown_limit.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
			label3.Visible = false;
			label9.Visible = false;
			comboBox_mtars.Visible = false;
            textBox_details.Visible = false;
            button_update.Visible = false;
            DataGridView_tool.ReadOnly = true;
			button_addQua.Visible = false;
			checkBox1.Enabled = false;
		}

		// To show tool list in DatagridView
		public void showTable()
		{

			DataGridView_tool.DataSource = tool.getToollist(new MySqlCommand("SELECT `id` AS Azonosító, `toolName` AS Név, `toolSize` AS Méret, `inDate` AS 'Felvétel ideje', `type` AS Típus, `quantity` AS Darabszám, `description` AS Részletek, `limit` AS Figyelmeztetés FROM `eszkozok`"));
			DataGridView_tool.ReadOnly = true;
			DataGridView_tool.Columns[7].Visible = false;

		}
		//Display data from tool to textbox
		private void DataGridView_tool_Click(object sender, EventArgs e)
		{



			if (DataGridView_tool.Rows.Count>0)
			{

			
			textBox_id.Text = DataGridView_tool.CurrentRow.Cells[0].Value.ToString();
			textBox_name.Text = DataGridView_tool.CurrentRow.Cells[1].Value.ToString();
			textBox_size.Text = DataGridView_tool.CurrentRow.Cells[2].Value.ToString();


            textBox_quantity.Text = DataGridView_tool.CurrentRow.Cells[5].Value.ToString();
			textBox_details.Text = DataGridView_tool.CurrentRow.Cells[6].Value.ToString();
			numericUpDown_limit.Value=Convert.ToInt32(DataGridView_tool.CurrentRow.Cells[7].Value);
			if (textBox_name.Text != "")
			{
				button_history.Visible = true;
				button_delete.Visible = true;
				button_clear.Visible = true;
                button_out.Visible = true;
				button_addQua.Visible = true;
                numericUpDown_qua.Visible = true;
				label3.Visible = true;
					label9.Visible = true;
				comboBox_mtars.Visible = true;
					checkBox1.Enabled = true;
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
            changeState();

        }

        private void button_clear_Click(object sender, EventArgs e)
		{
			textBox_id.Clear();
			textBox_name.Clear();
			textBox_size.Clear();
			textBox_quantity.Clear();
			textBox_details.Clear();
			comboBox_mtars.Items.Clear();
			button_history.Visible = false;
            button_delete.Visible = false;
            button_update.Visible = false;
			button_clear.Visible = false;
			numericUpDown_limit.Value = 1;
            button_out.Visible = false;
			button_addQua.Visible = false;
            numericUpDown_limit.Visible = false;
            numericUpDown_qua.Visible = false;
            label2.Visible = false;
			label3.Visible = false;
            label5.Visible = false;
			label9.Visible = false;
			comboBox_mtars.Visible = false;
			hideInfo();
            changeState();


		}

		private void button_search_Click(object sender, EventArgs e)
		{
			DataGridView_tool.DataSource = tool.searchTool(textBox_search.Text);
			changeState();
			DataGridView_tool.Columns["Figyelmeztetés"].Visible = false;
			hideInfo() ;
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
			// update tool record
			int id = Convert.ToInt32(textBox_id.Text);
			string name = textBox_name.Text;
			string quantity = textBox_quantity.Text;
			string details = textBox_details.Text;
			string mtars = comboBox_mtars.Text;
			int limit = Convert.ToInt32(numericUpDown_limit.Value);

			if (verify())
			{
				string eszkozadatok = ($"Biztosan módosítani kívánja a következő eszközt?\nNév: {name}\nDarabszám: {quantity}\nRészletek: {details}\nMunkatárs: {mtars}\nLimit: {limit}");
				DialogResult result = MessageBox.Show($"{eszkozadatok}", "Eszköz felvétele", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					try
					{

							
								if (tool.updateTool(id, name, quantity, details, mtars, limit))
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


			changeState();
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_size.Clear();
            textBox_quantity.Clear();
            textBox_details.Clear();
            hideInfo();
            comboBox_mtars.Items.Clear();
            numericUpDown_qua.Value = 1;
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
            hideInfo();
            changeState();

		}

		private void button_history_Click(object sender, EventArgs e)
		{
			ToolClass.toolid = textBox_id.Text;
			History myForm = new History();
			int toolid = Convert.ToInt32(textBox_id.Text);
			myForm.Show();
			changeState();
        }


		private void DataGridView_tool_Layout(object sender, LayoutEventArgs e)
		{
			changeState();
		}

		public void changeState()
		{
			foreach (DataGridViewRow r in DataGridView_tool.Rows)
			{
				int cellQuantity = Convert.ToInt32(r.Cells[5].Value);
				int cellLimit = Convert.ToInt32(r.Cells[7].Value);
				if (cellLimit >= cellQuantity)
				{
					r.DefaultCellStyle.BackColor = Color.Red;
					r.DefaultCellStyle.ForeColor = Color.White;
					r.DefaultCellStyle.SelectionForeColor = Color.White;
					r.DefaultCellStyle.SelectionBackColor = Color.Brown;
				}
			}
		}


        private void button_out_Click(object sender, EventArgs e)
        {
            string mtars = comboBox_mtars.Text;
			DateTime dateTime = DateTime.Now;
            int kiadott = Convert.ToInt32(numericUpDown_qua.Value);
            int id = Convert.ToInt32(textBox_id.Text);
			int quantity = Convert.ToInt32(textBox_quantity.Text);
			string name = textBox_name.Text;
			double size = Convert.ToDouble(textBox_size.Text);

			if (quantity>=kiadott)
			{
				if (comboBox_mtars.Text!="")
				{
                    if (MessageBox.Show("Biztosan kiadod a szerszámot?", "Kiadás", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (tool.kiadasTool(id, name, size, mtars, kiadott, quantity))
                        {
                            showTable();
                            MessageBox.Show("Eszköz kiadva.", "Sikeres kiadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_clear.PerformClick();
                            hideInfo();
                        }
                    }
                }
				else
				{
					MessageBox.Show("Munkatárs mező üres!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
                
            }
			else
			{
				MessageBox.Show("Nincs elég darabszám!", "Hiba", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

            numericUpDown_qua.Value = 1;

            changeState();

        }

        private void button_addQua_Click(object sender, EventArgs e)
        {
            string mtars = comboBox_mtars.Text;
            DateTime dateTime = DateTime.Now;
            int kiadott = Convert.ToInt32(numericUpDown_qua.Value);
            int id = Convert.ToInt32(textBox_id.Text);
            int quantity = Convert.ToInt32(textBox_quantity.Text);
			string name = textBox_name.Text;
			double size = Convert.ToDouble(textBox_size.Text);
			if (comboBox_mtars.Text != "")
			{
				if (MessageBox.Show("Biztosan hozzáadod a darabszámot?", "Hozzáadás", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (tool.hozzaadTool(id, name, size, mtars, kiadott, quantity))
					{
						showTable();
						MessageBox.Show("Eszköz hozzáadva.", "Sikeres hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
						button_clear.PerformClick();
                        hideInfo();
                    }
				}
			}
			else
			{
                MessageBox.Show("Munkatárs mező üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
			numericUpDown_qua.Value = 1;

            changeState();
        }


        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
			if (checkBox1.Checked)
			{
				numericUpDown_limit.Visible = true;
				label2.Visible = true;
				label5.Visible = true;
				textBox_details.Visible = true;
				button_update.Visible = true;
			}
			else {
                numericUpDown_limit.Visible = false;
                label2.Visible = false;
				label5.Visible = false;
                textBox_details.Visible = false;
                button_update.Visible = false;
            }

        }
		public void hideInfo()
		{
            button_delete.Visible = false;
            button_update.Visible = false;
            button_clear.Visible = false;
            button_out.Visible = false;
			button_addQua.Visible = false;
			button_history.Visible = false;
            numericUpDown_limit.Value = 1;
            numericUpDown_qua.Visible = false;
            numericUpDown_limit.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
			label9.Visible = false;
			comboBox_mtars.Visible = false;
            textBox_details.Visible = false;
			checkBox1.Checked = false;
			checkBox1.Enabled = false;
        }



    }
		}
	
	
	
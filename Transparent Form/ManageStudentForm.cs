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
	public partial class ManageStudentForm : Form
	{
		StudentClass student = new StudentClass();
		public ManageStudentForm()
		{
			InitializeComponent();
			button_update.Enabled = false;
			button_delete.Enabled = false;
		}

		private void ManageStudentForm_Load(object sender, EventArgs e)
		{
			showTable();
			
		}
		// To show student list in DatagridView
		public void showTable()
		{
			DataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT `id` AS Azonosító, `toolName` AS Név, `toolSize` AS Méret, `inDate` AS 'Felvétel ideje', `type` AS Típus, `quantity` AS Mennyiség, `description` AS Részletek FROM `eszkozok`"));
			DataGridView_student.ReadOnly = true;
		}

		//Display student data from student to textbox
		private void DataGridView_student_Click(object sender, EventArgs e)
		{
			textBox_id.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
			textBox_Fname.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
			textBox_Lname.Text = DataGridView_student.CurrentRow.Cells[2].Value.ToString();

			dateTimePicker1.Value = (DateTime)DataGridView_student.CurrentRow.Cells[3].Value;
			if (DataGridView_student.CurrentRow.Cells[4].Value.ToString() == "Szerszám")
				radioButton_male.Checked = true;

			textBox_phone.Text = DataGridView_student.CurrentRow.Cells[5].Value.ToString();
			textBox_address.Text = DataGridView_student.CurrentRow.Cells[6].Value.ToString();

			if (textBox_Fname.Text != "")
			{
				button_history.Visible = true;
				button_update.Enabled = true;
				button_delete.Enabled = true;
			}
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			textBox_id.Clear();
			textBox_Fname.Clear();
			textBox_Lname.Clear();
			textBox_phone.Clear();
			textBox_address.Clear();
			radioButton_male.Checked = true;
			dateTimePicker1.Value = DateTime.Now;
			button_history.Visible = false;
            button_delete.Enabled = false;
            button_update.Enabled = false;
        }

		private void button_search_Click(object sender, EventArgs e)
		{
			DataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
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

		private void button_update_Click(object sender, EventArgs e)
		{
			// update student record
			int id = Convert.ToInt32(textBox_id.Text);
			string fname = textBox_Fname.Text;
			string lname = textBox_Lname.Text;
			string phone = textBox_phone.Text;
			string address = textBox_address.Text;
			string gender = radioButton_male.Checked ? "Szerszám" : "Egyéb";
			string mtars = textBox_mtars.Text;


			if (verify())
			{
                string eszkozadatok = ($"Biztosan módosítani kívánja a következő eszközt?\nNév: {fname}\nMéret: {lname}\nDarabszám: {phone}\nTípus: {gender}\nRészletek: {address}\nMunkatárs: {mtars}");
                DialogResult result = MessageBox.Show($"{eszkozadatok}", "Eszköz felvétele", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					try
					{
						if (student.updateStudent(id, fname, lname, gender, phone, address, mtars))
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
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
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
				if (student.deleteStudent(id))
				{
					showTable();
					MessageBox.Show("Bejegyzés eltávolítva.", "Sikeres törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
					button_clear.PerformClick();
				}
			}
            button_delete.Enabled = false;
            button_update.Enabled = false;

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
		{

		}

		private void button_history_Click(object sender, EventArgs e)
		{
			StudentClass.toolid = textBox_id.Text;
			History myForm = new History();
			int toolid = Convert.ToInt32(textBox_id.Text);
			myForm.Show();
		}
	}
	
	
	}


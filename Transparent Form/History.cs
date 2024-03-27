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
	public partial class History : Form
	{
		StudentClass student = new StudentClass();
		public History()
		{
			InitializeComponent();
			DataGridView_history.DataSource = student.getHistory(new MySqlCommand("SELECT `modified_date` AS 'Módosítva',`quantity` AS Darabszám, `munkatars` AS Munkatárs FROM `history` WHERE `tool_id`=@toolid"));
			DataGridView_history.ReadOnly = true;
		}
		private void History_Load(object sender, EventArgs e)
		{
			string toolid = StudentClass.toolid;
		}
	}
}

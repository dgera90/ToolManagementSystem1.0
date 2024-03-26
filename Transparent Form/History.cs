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
		DBconnect connect = new DBconnect();

		public History()
		{
			InitializeComponent();
		}
		private void History_Load(object sender, EventArgs e)
		{
			showTable();

		}
		// To show student list in DatagridView
		public void showTable()
		{
			DataGridView_history.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `history`"));
			DataGridView_history.ReadOnly = true;

		}
			
	}
}

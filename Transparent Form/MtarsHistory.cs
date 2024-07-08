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
    public partial class MtarsHistory : Form
    {
        ToolClass tool = new ToolClass();
        DBconnect connect = new DBconnect();

        public MtarsHistory()
        {
            InitializeComponent();
            showTable();
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
        public void showTable()
        {

            DataGridView_mtars.DataSource = tool.getMtarslist(new MySqlCommand("SELECT `tool_name` AS Név, `tool_size` AS Méret, `modified_date` AS Dátum, `munkatars` AS Munkatárs, `kiadott` AS Kiadott, `hozzaadott` AS Hozzáadott FROM `history`"));
            DataGridView_mtars.ReadOnly = true;

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_mtars.DataSource = tool.searchSzerszam(textBox_search.Text);
            comboBox_mtars.SelectedIndex = -1;

            textBox_search.Clear();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_search.Clear();
            comboBox_mtars.SelectedIndex = -1;

            showTable();
        }

        private void button_mtarsSearch_Click(object sender, EventArgs e)
        {
            DataGridView_mtars.DataSource = tool.searchMtars(comboBox_mtars.Text);
            textBox_search.Clear();
        }
    }
}

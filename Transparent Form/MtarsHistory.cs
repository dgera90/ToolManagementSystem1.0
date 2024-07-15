using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

            DataGridView_mtars.DataSource = tool.getMtarslist(new MySqlCommand("SELECT `forg` AS Forgalmazó, `cikkszam` AS Cikkszám, `tool_name` AS Név, `tool_size` AS Méret, `modified_date` AS Dátum, `munkatars` AS Munkatárs, `kiadott` AS Kiadott, `hozzaadott` AS Hozzáadott, `egysegar` AS Egységár, `osszar` AS 'Össz érték' FROM `history`"));
            DataGridView_mtars.ReadOnly = true;
			DataGridView_mtars.Columns["Egységár"].DefaultCellStyle.Format = "c";
			DataGridView_mtars.Columns["Össz érték"].DefaultCellStyle.Format = "c";
		}

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_mtars.DataSource = tool.searchSzerszam(textBox_search.Text);
            comboBox_mtars.SelectedIndex = -1;
			DataGridView_mtars.Columns["Egységár"].DefaultCellStyle.Format = "c";
			DataGridView_mtars.Columns["Össz érték"].DefaultCellStyle.Format = "c";
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
			DataGridView_mtars.Columns["Egységár"].DefaultCellStyle.Format = "c";
			DataGridView_mtars.Columns["Össz érték"].DefaultCellStyle.Format = "c";
		}

		private void button_print_Click(object sender, EventArgs e)
		{
			// Create document
			PrintDocument _document = new PrintDocument();
			// Add print handler
			_document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
			// Create the dialog to display results
			PrintPreviewDialog _dlg = new PrintPreviewDialog();
			_dlg.ClientSize = new System.Drawing.Size(Width /2, Height/2);
			_dlg.Location = new System.Drawing.Point(Left, Top);
			_dlg.MinimumSize = new System.Drawing.Size(375, 250);
			_dlg.UseAntiAlias = true;
			_document.DefaultPageSettings.Landscape = true;

			_document.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 900, 1400);
			// Setting up our document
			_dlg.Document = _document;
			// Show it
			_dlg.ShowDialog(this);
			// Dispose document
			_document.Dispose();
		}
		private void Document_PrintPage(object sender, PrintPageEventArgs e)
		{
			// Create Bitmap according form size
			Bitmap _bitmap = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
			// Draw from into Bitmap DC

			this.DrawToBitmap(_bitmap, this.DisplayRectangle);
			// Draw Bitmap into Printer DC
			e.Graphics.DrawImage(_bitmap, 0, 0);
			// No longer deeded - dispose it
			_bitmap.Dispose();
		}
	}
}

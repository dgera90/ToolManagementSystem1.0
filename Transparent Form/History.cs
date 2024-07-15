using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Transparent_Form
{
	public partial class History : Form
	{
		ToolClass tool = new ToolClass();


        public History()
        {
            InitializeComponent();
            DataGridView_history.DataSource = tool.getHistory(new MySqlCommand("SELECT `modified_date` AS 'Módosítva', `munkatars` AS Munkatárs, `kiadott` AS Kiadva, `hozzaadott` AS Hozzáadva FROM `history` WHERE `tool_id`=@toolid"));
            DataGridView_history.ReadOnly = true;
            string toolid = ToolClass.toolid;
            
            DataOrigin.DataSource = tool.originTool(new MySqlCommand("SELECT `toolName` AS 'Név',`forg` AS Forgalmazó, `cikkszam` AS Cikkszám, `toolSize` AS 'Méret', `inDate` AS 'Felvétel ideje', `type` AS 'Típus', `quantity` AS Darabszám,`egysegar` AS Egységár, `description` AS 'Részletek' FROM `felvetel` WHERE `id`=@toolid"));
            DataOrigin.ReadOnly = true;
            DataOrigin.Columns[7].DefaultCellStyle.Format = "c";


        }

        private void History_Load(object sender, EventArgs e)
		{
            

           
		}

        // Handler for print call
        private void printButton_Click(object sender, EventArgs e)
        {
            // Create document
            PrintDocument _document = new PrintDocument();
            // Add print handler
            _document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            // Create the dialog to display results
            PrintPreviewDialog _dlg = new PrintPreviewDialog();
            _dlg.ClientSize = new System.Drawing.Size(Width/2, Height/2);
            _dlg.Location = new System.Drawing.Point(Left, Top);
            _dlg.MinimumSize = new System.Drawing.Size(375, 250);
            _dlg.UseAntiAlias = true;
            _document.DefaultPageSettings.Landscape = true;
            // Setting up our document
            _dlg.Document = _document;
            // Show it
            _dlg.ShowDialog(this);
            // Dispose document
            _document.Dispose();
        }
        // Print handler
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

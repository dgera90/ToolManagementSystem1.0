﻿
namespace Transparent_Form
{
    partial class ManageToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox_quantity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button_delete = new System.Windows.Forms.Button();
			this.button_update = new System.Windows.Forms.Button();
			this.textBox_details = new System.Windows.Forms.TextBox();
			this.radioButton_etc = new System.Windows.Forms.RadioButton();
			this.radioButton_tool = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox_size = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DataGridView_tool = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox_mtars = new System.Windows.Forms.TextBox();
			this.button_history = new System.Windows.Forms.Button();
			this.button_clear = new System.Windows.Forms.Button();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_search = new System.Windows.Forms.Button();
			this.textBox_search = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_tool)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(69)))), ((int)(((byte)(107)))));
			this.panel3.Location = new System.Drawing.Point(13, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1109, 10);
			this.panel3.TabIndex = 32;
			// 
			// textBox_quantity
			// 
			this.textBox_quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_quantity.Location = new System.Drawing.Point(647, 18);
			this.textBox_quantity.Name = "textBox_quantity";
			this.textBox_quantity.Size = new System.Drawing.Size(77, 32);
			this.textBox_quantity.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label6.Location = new System.Drawing.Point(539, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "Darabszám:";
			// 
			// button_delete
			// 
			this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(25)))), ((int)(((byte)(67)))));
			this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_delete.ForeColor = System.Drawing.Color.White;
			this.button_delete.Location = new System.Drawing.Point(967, 187);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(155, 39);
			this.button_delete.TabIndex = 29;
			this.button_delete.Text = "Törlés";
			this.button_delete.UseVisualStyleBackColor = false;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// button_update
			// 
			this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_update.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_update.ForeColor = System.Drawing.Color.White;
			this.button_update.Location = new System.Drawing.Point(806, 187);
			this.button_update.Name = "button_update";
			this.button_update.Size = new System.Drawing.Size(155, 39);
			this.button_update.TabIndex = 28;
			this.button_update.Text = "Módosítás";
			this.button_update.UseVisualStyleBackColor = false;
			this.button_update.Click += new System.EventHandler(this.button_update_Click);
			// 
			// textBox_details
			// 
			this.textBox_details.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_details.Location = new System.Drawing.Point(145, 102);
			this.textBox_details.Multiline = true;
			this.textBox_details.Name = "textBox_details";
			this.textBox_details.Size = new System.Drawing.Size(445, 50);
			this.textBox_details.TabIndex = 25;
			// 
			// radioButton_etc
			// 
			this.radioButton_etc.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButton_etc.AutoSize = true;
			this.radioButton_etc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_etc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.radioButton_etc.Location = new System.Drawing.Point(715, 63);
			this.radioButton_etc.Name = "radioButton_etc";
			this.radioButton_etc.Size = new System.Drawing.Size(92, 27);
			this.radioButton_etc.TabIndex = 24;
			this.radioButton_etc.Text = "Egyéb";
			this.radioButton_etc.UseVisualStyleBackColor = true;
			// 
			// radioButton_tool
			// 
			this.radioButton_tool.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButton_tool.AutoSize = true;
			this.radioButton_tool.Checked = true;
			this.radioButton_tool.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_tool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.radioButton_tool.Location = new System.Drawing.Point(612, 63);
			this.radioButton_tool.Name = "radioButton_tool";
			this.radioButton_tool.Size = new System.Drawing.Size(119, 27);
			this.radioButton_tool.TabIndex = 23;
			this.radioButton_tool.TabStop = true;
			this.radioButton_tool.Text = "Szerszám";
			this.radioButton_tool.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePicker1.Location = new System.Drawing.Point(145, 61);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(291, 32);
			this.dateTimePicker1.TabIndex = 22;
			this.dateTimePicker1.Visible = false;
			// 
			// textBox_size
			// 
			this.textBox_size.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_size.Location = new System.Drawing.Point(369, 18);
			this.textBox_size.Name = "textBox_size";
			this.textBox_size.Size = new System.Drawing.Size(135, 32);
			this.textBox_size.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label4.Location = new System.Drawing.Point(291, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Méret:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label2.Location = new System.Drawing.Point(525, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Típus:";
			// 
			// textBox_name
			// 
			this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_name.Location = new System.Drawing.Point(102, 18);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(140, 32);
			this.textBox_name.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label5.Location = new System.Drawing.Point(60, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Részletek:";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label3.Location = new System.Drawing.Point(28, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Felvétel ideje:";
			this.label3.Visible = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label1.Location = new System.Drawing.Point(41, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Név:";
			// 
			// DataGridView_tool
			// 
			this.DataGridView_tool.AllowUserToAddRows = false;
			this.DataGridView_tool.AllowUserToDeleteRows = false;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.DataGridView_tool.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.DataGridView_tool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridView_tool.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DataGridView_tool.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(69)))), ((int)(((byte)(107)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_tool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.DataGridView_tool.ColumnHeadersHeight = 24;
			this.DataGridView_tool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DataGridView_tool.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_tool.DefaultCellStyle = dataGridViewCellStyle15;
			this.DataGridView_tool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.Location = new System.Drawing.Point(13, 93);
			this.DataGridView_tool.Margin = new System.Windows.Forms.Padding(1);
			this.DataGridView_tool.Name = "DataGridView_tool";
			this.DataGridView_tool.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DataGridView_tool.RowHeadersVisible = false;
			this.DataGridView_tool.RowHeadersWidth = 51;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.DataGridView_tool.RowsDefaultCellStyle = dataGridViewCellStyle16;
			this.DataGridView_tool.RowTemplate.Height = 80;
			this.DataGridView_tool.Size = new System.Drawing.Size(1109, 281);
			this.DataGridView_tool.TabIndex = 15;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.DataGridView_tool.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.DataGridView_tool.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DataGridView_tool.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_tool.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.DataGridView_tool.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DataGridView_tool.ThemeStyle.HeaderStyle.Height = 24;
			this.DataGridView_tool.ThemeStyle.ReadOnly = false;
			this.DataGridView_tool.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_tool.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DataGridView_tool.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_tool.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_tool.ThemeStyle.RowsStyle.Height = 80;
			this.DataGridView_tool.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_tool.Click += new System.EventHandler(this.DataGridView_tool_Click);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(470, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(185, 32);
			this.label7.TabIndex = 0;
			this.label7.Text = "Eszközkészlet";
			// 
			// panel2
			// 
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.textBox_mtars);
			this.panel2.Controls.Add(this.button_history);
			this.panel2.Controls.Add(this.button_clear);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.textBox_id);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.textBox_quantity);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.button_delete);
			this.panel2.Controls.Add(this.button_update);
			this.panel2.Controls.Add(this.textBox_details);
			this.panel2.Controls.Add(this.radioButton_etc);
			this.panel2.Controls.Add(this.radioButton_tool);
			this.panel2.Controls.Add(this.dateTimePicker1);
			this.panel2.Controls.Add(this.textBox_size);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox_name);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 378);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1134, 235);
			this.panel2.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label9.Location = new System.Drawing.Point(616, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 23);
			this.label9.TabIndex = 36;
			this.label9.Text = "Munkatárs:";
			// 
			// textBox_mtars
			// 
			this.textBox_mtars.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_mtars.Location = new System.Drawing.Point(715, 114);
			this.textBox_mtars.Name = "textBox_mtars";
			this.textBox_mtars.Size = new System.Drawing.Size(168, 32);
			this.textBox_mtars.TabIndex = 35;
			// 
			// button_history
			// 
			this.button_history.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_history.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_history.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_history.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.button_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_history.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_history.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button_history.Location = new System.Drawing.Point(484, 187);
			this.button_history.Name = "button_history";
			this.button_history.Size = new System.Drawing.Size(155, 39);
			this.button_history.TabIndex = 34;
			this.button_history.Text = "Történet";
			this.button_history.UseVisualStyleBackColor = false;
			this.button_history.Visible = false;
			this.button_history.Click += new System.EventHandler(this.button_history_Click);
			// 
			// button_clear
			// 
			this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_clear.ForeColor = System.Drawing.Color.White;
			this.button_clear.Location = new System.Drawing.Point(645, 187);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(155, 39);
			this.button_clear.TabIndex = 33;
			this.button_clear.Text = "Mezők törlése";
			this.button_clear.UseVisualStyleBackColor = false;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// textBox_id
			// 
			this.textBox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_id.Location = new System.Drawing.Point(225, 183);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.Size = new System.Drawing.Size(85, 32);
			this.textBox_id.TabIndex = 31;
			this.textBox_id.Visible = false;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label8.Location = new System.Drawing.Point(151, 187);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 23);
			this.label8.TabIndex = 30;
			this.label8.Text = "Id No :";
			this.label8.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(69)))), ((int)(((byte)(107)))));
			this.panel1.Controls.Add(this.label7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1134, 51);
			this.panel1.TabIndex = 16;
			// 
			// button_search
			// 
			this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_search.ForeColor = System.Drawing.Color.White;
			this.button_search.Location = new System.Drawing.Point(1004, 51);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(118, 39);
			this.button_search.TabIndex = 33;
			this.button_search.Text = "Keresés";
			this.button_search.UseVisualStyleBackColor = false;
			this.button_search.Click += new System.EventHandler(this.button_search_Click);
			// 
			// textBox_search
			// 
			this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_search.Location = new System.Drawing.Point(842, 58);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(156, 32);
			this.textBox_search.TabIndex = 31;
			// 
			// ManageToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 613);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.DataGridView_tool);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "ManageToolForm";
			this.Text = "ManageStudentForm";
			this.Load += new System.EventHandler(this.ManageToolForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_tool)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_details;
        private System.Windows.Forms.RadioButton radioButton_etc;
        private System.Windows.Forms.RadioButton radioButton_tool;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_tool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
		private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.TextBox textBox_mtars;
        private System.Windows.Forms.Label label9;
    }
}
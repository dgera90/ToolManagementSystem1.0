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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_details = new System.Windows.Forms.TextBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_tool = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_ar = new System.Windows.Forms.TextBox();
            this.textBox_ossz = new System.Windows.Forms.TextBox();
            this.textBox_cikkszam = new System.Windows.Forms.TextBox();
            this.textBox_forg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addQua = new System.Windows.Forms.Button();
            this.button_out = new System.Windows.Forms.Button();
            this.numericUpDown_qua = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_limit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_mtars = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_history = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_ar = new System.Windows.Forms.Label();
            this.button_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_tool)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_limit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(13, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1403, 10);
            this.panel3.TabIndex = 32;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_quantity.Location = new System.Drawing.Point(136, 96);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.ReadOnly = true;
            this.textBox_quantity.Size = new System.Drawing.Size(77, 26);
            this.textBox_quantity.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(28, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Darabszám:";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(1223, 187);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(155, 39);
            this.button_delete.TabIndex = 29;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_update.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(740, 58);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(130, 46);
            this.button_update.TabIndex = 28;
            this.button_update.Text = "Módosítás";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_details
            // 
            this.textBox_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_details.Location = new System.Drawing.Point(430, 50);
            this.textBox_details.Multiline = true;
            this.textBox_details.Name = "textBox_details";
            this.textBox_details.Size = new System.Drawing.Size(156, 30);
            this.textBox_details.TabIndex = 25;
            // 
            // textBox_size
            // 
            this.textBox_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_size.Location = new System.Drawing.Point(102, 54);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.ReadOnly = true;
            this.textBox_size.Size = new System.Drawing.Size(140, 26);
            this.textBox_size.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(24, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Méret:";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_name.Location = new System.Drawing.Point(102, 18);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(140, 26);
            this.textBox_name.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(315, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Részletek:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Név:";
            // 
            // DataGridView_tool
            // 
            this.DataGridView_tool.AllowUserToAddRows = false;
            this.DataGridView_tool.AllowUserToDeleteRows = false;
            this.DataGridView_tool.AllowUserToResizeColumns = false;
            this.DataGridView_tool.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataGridView_tool.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.DataGridView_tool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_tool.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView_tool.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_tool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DataGridView_tool.ColumnHeadersHeight = 24;
            this.DataGridView_tool.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_tool.DefaultCellStyle = dataGridViewCellStyle19;
            this.DataGridView_tool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_tool.Location = new System.Drawing.Point(13, 93);
            this.DataGridView_tool.Margin = new System.Windows.Forms.Padding(1);
            this.DataGridView_tool.Name = "DataGridView_tool";
            this.DataGridView_tool.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView_tool.RowHeadersVisible = false;
            this.DataGridView_tool.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataGridView_tool.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DataGridView_tool.RowTemplate.Height = 80;
            this.DataGridView_tool.Size = new System.Drawing.Size(1365, 464);
            this.DataGridView_tool.TabIndex = 15;
            this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_tool.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_tool.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_tool.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_tool.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_tool.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_tool.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_tool.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView_tool.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_tool.ThemeStyle.ReadOnly = false;
            this.DataGridView_tool.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_tool.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_tool.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_tool.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_tool.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_tool.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_tool.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_tool.Click += new System.EventHandler(this.DataGridView_tool_Click);
            this.DataGridView_tool.Layout += new System.Windows.Forms.LayoutEventHandler(this.DataGridView_tool_Layout);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(598, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Eszközkészlet";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label_ar);
            this.panel2.Controls.Add(this.textBox_ar);
            this.panel2.Controls.Add(this.textBox_ossz);
            this.panel2.Controls.Add(this.textBox_cikkszam);
            this.panel2.Controls.Add(this.textBox_forg);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_addQua);
            this.panel2.Controls.Add(this.button_out);
            this.panel2.Controls.Add(this.numericUpDown_qua);
            this.panel2.Controls.Add(this.numericUpDown_limit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_mtars);
            this.panel2.Controls.Add(this.label9);
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
            this.panel2.Controls.Add(this.textBox_size);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1390, 235);
            this.panel2.TabIndex = 17;
            // 
            // textBox_ar
            // 
            this.textBox_ar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_ar.Location = new System.Drawing.Point(630, 54);
            this.textBox_ar.Name = "textBox_ar";
            this.textBox_ar.Size = new System.Drawing.Size(100, 26);
            this.textBox_ar.TabIndex = 52;
            // 
            // textBox_ossz
            // 
            this.textBox_ossz.Location = new System.Drawing.Point(893, 41);
            this.textBox_ossz.Name = "textBox_ossz";
            this.textBox_ossz.Size = new System.Drawing.Size(100, 26);
            this.textBox_ossz.TabIndex = 51;
            this.textBox_ossz.Visible = false;
            // 
            // textBox_cikkszam
            // 
            this.textBox_cikkszam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_cikkszam.Location = new System.Drawing.Point(165, 191);
            this.textBox_cikkszam.Name = "textBox_cikkszam";
            this.textBox_cikkszam.ReadOnly = true;
            this.textBox_cikkszam.Size = new System.Drawing.Size(229, 26);
            this.textBox_cikkszam.TabIndex = 50;
            // 
            // textBox_forg
            // 
            this.textBox_forg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_forg.Location = new System.Drawing.Point(165, 146);
            this.textBox_forg.Name = "textBox_forg";
            this.textBox_forg.ReadOnly = true;
            this.textBox_forg.Size = new System.Drawing.Size(229, 26);
            this.textBox_forg.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(28, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 48;
            this.label11.Text = "Cikkszám:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(28, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Forgalmazó:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(429, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(258, 24);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Limit, ár és részletek módosítása";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(795, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Darabszám módosítása ennyivel:";
            // 
            // button_addQua
            // 
            this.button_addQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addQua.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_addQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addQua.ForeColor = System.Drawing.Color.White;
            this.button_addQua.Location = new System.Drawing.Point(1224, 76);
            this.button_addQua.Name = "button_addQua";
            this.button_addQua.Size = new System.Drawing.Size(100, 40);
            this.button_addQua.TabIndex = 44;
            this.button_addQua.Text = "Hozzáad";
            this.button_addQua.UseVisualStyleBackColor = false;
            this.button_addQua.Click += new System.EventHandler(this.button_addQua_Click);
            // 
            // button_out
            // 
            this.button_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_out.AutoSize = true;
            this.button_out.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_out.ForeColor = System.Drawing.Color.White;
            this.button_out.Location = new System.Drawing.Point(1224, 30);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(100, 40);
            this.button_out.TabIndex = 43;
            this.button_out.Text = "Kivétel";
            this.button_out.UseVisualStyleBackColor = false;
            this.button_out.Click += new System.EventHandler(this.button_out_Click);
            // 
            // numericUpDown_qua
            // 
            this.numericUpDown_qua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_qua.Location = new System.Drawing.Point(1098, 58);
            this.numericUpDown_qua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_qua.Name = "numericUpDown_qua";
            this.numericUpDown_qua.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_qua.TabIndex = 42;
            this.numericUpDown_qua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_limit
            // 
            this.numericUpDown_limit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_limit.Location = new System.Drawing.Point(609, 96);
            this.numericUpDown_limit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_limit.Name = "numericUpDown_limit";
            this.numericUpDown_limit.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_limit.TabIndex = 39;
            this.numericUpDown_limit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(315, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Figyelmeztető limit módosítása:";
            // 
            // comboBox_mtars
            // 
            this.comboBox_mtars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_mtars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mtars.FormattingEnabled = true;
            this.comboBox_mtars.Location = new System.Drawing.Point(1114, 140);
            this.comboBox_mtars.Name = "comboBox_mtars";
            this.comboBox_mtars.Size = new System.Drawing.Size(206, 28);
            this.comboBox_mtars.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(994, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Munkatárs:";
            // 
            // button_history
            // 
            this.button_history.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_history.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_history.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_history.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_history.FlatAppearance.BorderSize = 0;
            this.button_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_history.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_history.Location = new System.Drawing.Point(579, 187);
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
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(740, 187);
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
            this.textBox_id.Location = new System.Drawing.Point(217, 128);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(85, 26);
            this.textBox_id.TabIndex = 31;
            this.textBox_id.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(143, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Id No :";
            this.label8.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 51);
            this.panel1.TabIndex = 16;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(941, 50);
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
            this.textBox_search.Location = new System.Drawing.Point(779, 57);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 26);
            this.textBox_search.TabIndex = 31;
            // 
            // label_ar
            // 
            this.label_ar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ar.AutoSize = true;
            this.label_ar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_ar.Location = new System.Drawing.Point(588, 54);
            this.label_ar.Name = "label_ar";
            this.label_ar.Size = new System.Drawing.Size(36, 19);
            this.label_ar.TabIndex = 53;
            this.label_ar.Text = "Ár:";
            // 
            // button_reload
            // 
            this.button_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reload.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reload.ForeColor = System.Drawing.Color.White;
            this.button_reload.Location = new System.Drawing.Point(1236, 51);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(118, 39);
            this.button_reload.TabIndex = 34;
            this.button_reload.Text = "Visszaállít";
            this.button_reload.UseVisualStyleBackColor = false;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // ManageToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 796);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.DataGridView_tool);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageToolForm";
            this.Text = "ManageStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_tool)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_limit)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_mtars;
        private System.Windows.Forms.NumericUpDown numericUpDown_limit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_qua;
        private System.Windows.Forms.Button button_out;
        private System.Windows.Forms.Button button_addQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox_cikkszam;
		private System.Windows.Forms.TextBox textBox_forg;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_ossz;
        private System.Windows.Forms.TextBox textBox_ar;
        private System.Windows.Forms.Label label_ar;
        private System.Windows.Forms.Button button_reload;
    }
}
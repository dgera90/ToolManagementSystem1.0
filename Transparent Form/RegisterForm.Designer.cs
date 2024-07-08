
namespace Transparent_Form
{
    partial class RegisterForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.DataGridView_tool = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button_addName = new System.Windows.Forms.Button();
			this.comboBox_name = new System.Windows.Forms.ComboBox();
			this.textBox_quantity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button_add = new System.Windows.Forms.Button();
			this.button_clear = new System.Windows.Forms.Button();
			this.textBox_details = new System.Windows.Forms.TextBox();
			this.radioButton_etc = new System.Windows.Forms.RadioButton();
			this.radioButton_tool = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox_size = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDown_limit = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_tool)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_limit)).BeginInit();
			this.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1134, 51);
			this.panel1.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(517, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(228, 31);
			this.label7.TabIndex = 0;
			this.label7.Text = "Eszköz felvétele";
			// 
			// DataGridView_tool
			// 
			this.DataGridView_tool.AllowUserToAddRows = false;
			this.DataGridView_tool.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.DataGridView_tool.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DataGridView_tool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridView_tool.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_tool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView_tool.ColumnHeadersHeight = 24;
			this.DataGridView_tool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_tool.DefaultCellStyle = dataGridViewCellStyle3;
			this.DataGridView_tool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.Location = new System.Drawing.Point(13, 57);
			this.DataGridView_tool.Name = "DataGridView_tool";
			this.DataGridView_tool.RowHeadersVisible = false;
			this.DataGridView_tool.RowHeadersWidth = 51;
			this.DataGridView_tool.RowTemplate.Height = 80;
			this.DataGridView_tool.Size = new System.Drawing.Size(1109, 20);
			this.DataGridView_tool.TabIndex = 3;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.DataGridView_tool.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.DataGridView_tool.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.DataGridView_tool.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DataGridView_tool.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_tool.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.DataGridView_tool.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DataGridView_tool.ThemeStyle.HeaderStyle.Height = 24;
			this.DataGridView_tool.ThemeStyle.ReadOnly = false;
			this.DataGridView_tool.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_tool.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DataGridView_tool.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_tool.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_tool.ThemeStyle.RowsStyle.Height = 80;
			this.DataGridView_tool.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_tool.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_tool.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Controls.Add(this.numericUpDown_limit);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.button_addName);
			this.panel2.Controls.Add(this.comboBox_name);
			this.panel2.Controls.Add(this.textBox_quantity);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.button_add);
			this.panel2.Controls.Add(this.button_clear);
			this.panel2.Controls.Add(this.textBox_details);
			this.panel2.Controls.Add(this.radioButton_etc);
			this.panel2.Controls.Add(this.radioButton_tool);
			this.panel2.Controls.Add(this.dateTimePicker1);
			this.panel2.Controls.Add(this.textBox_size);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(0, 122);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1134, 491);
			this.panel2.TabIndex = 14;
			// 
			// button_addName
			// 
			this.button_addName.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button_addName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_addName.ForeColor = System.Drawing.Color.White;
			this.button_addName.Location = new System.Drawing.Point(489, 59);
			this.button_addName.Name = "button_addName";
			this.button_addName.Size = new System.Drawing.Size(182, 43);
			this.button_addName.TabIndex = 34;
			this.button_addName.Text = "Módosítás";
			this.button_addName.UseVisualStyleBackColor = false;
			this.button_addName.Click += new System.EventHandler(this.button_addName_Click);
			// 
			// comboBox_name
			// 
			this.comboBox_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_name.FormattingEnabled = true;
			this.comboBox_name.Location = new System.Drawing.Point(194, 65);
			this.comboBox_name.Name = "comboBox_name";
			this.comboBox_name.Size = new System.Drawing.Size(206, 33);
			this.comboBox_name.TabIndex = 33;
			// 
			// textBox_quantity
			// 
			this.textBox_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_quantity.Location = new System.Drawing.Point(194, 253);
			this.textBox_quantity.Name = "textBox_quantity";
			this.textBox_quantity.Size = new System.Drawing.Size(156, 30);
			this.textBox_quantity.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label6.Location = new System.Drawing.Point(32, 258);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "Darabszám:";
			// 
			// button_add
			// 
			this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_add.ForeColor = System.Drawing.Color.White;
			this.button_add.Location = new System.Drawing.Point(1008, 444);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(118, 39);
			this.button_add.TabIndex = 29;
			this.button_add.Text = "Hozzáad";
			this.button_add.UseVisualStyleBackColor = false;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_clear
			// 
			this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_clear.ForeColor = System.Drawing.Color.White;
			this.button_clear.Location = new System.Drawing.Point(863, 444);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(139, 39);
			this.button_clear.TabIndex = 28;
			this.button_clear.Text = "Mezők törlése";
			this.button_clear.UseVisualStyleBackColor = false;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// textBox_details
			// 
			this.textBox_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_details.Location = new System.Drawing.Point(194, 171);
			this.textBox_details.Multiline = true;
			this.textBox_details.Name = "textBox_details";
			this.textBox_details.Size = new System.Drawing.Size(378, 53);
			this.textBox_details.TabIndex = 25;
			// 
			// radioButton_etc
			// 
			this.radioButton_etc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_etc.AutoSize = true;
			this.radioButton_etc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.radioButton_etc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.radioButton_etc.Location = new System.Drawing.Point(319, 14);
			this.radioButton_etc.Name = "radioButton_etc";
			this.radioButton_etc.Size = new System.Drawing.Size(86, 27);
			this.radioButton_etc.TabIndex = 24;
			this.radioButton_etc.Text = "Egyéb";
			this.radioButton_etc.UseVisualStyleBackColor = true;
			this.radioButton_etc.CheckedChanged += new System.EventHandler(this.radioButton_tool_CheckedChanged);
			// 
			// radioButton_tool
			// 
			this.radioButton_tool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_tool.AutoSize = true;
			this.radioButton_tool.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.radioButton_tool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.radioButton_tool.Location = new System.Drawing.Point(194, 14);
			this.radioButton_tool.Name = "radioButton_tool";
			this.radioButton_tool.Size = new System.Drawing.Size(119, 27);
			this.radioButton_tool.TabIndex = 23;
			this.radioButton_tool.Text = "Szerszám";
			this.radioButton_tool.UseVisualStyleBackColor = true;
			this.radioButton_tool.CheckedChanged += new System.EventHandler(this.radioButton_tool_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.Location = new System.Drawing.Point(757, 365);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(291, 30);
			this.dateTimePicker1.TabIndex = 22;
			this.dateTimePicker1.Visible = false;
			// 
			// textBox_size
			// 
			this.textBox_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_size.Location = new System.Drawing.Point(194, 114);
			this.textBox_size.Name = "textBox_size";
			this.textBox_size.Size = new System.Drawing.Size(135, 30);
			this.textBox_size.TabIndex = 21;
			this.textBox_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_size_KeyPress);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(32, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Méret:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(32, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Típus:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new System.Drawing.Point(32, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Részletek:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(468, 365);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Felvétel ideje:";
			this.label3.Visible = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(32, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Név:";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label8.Location = new System.Drawing.Point(32, 338);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(252, 23);
			this.label8.TabIndex = 35;
			this.label8.Text = "Figyelmeztetési limit:";
			// 
			// numericUpDown_limit
			// 
			this.numericUpDown_limit.Location = new System.Drawing.Point(300, 334);
			this.numericUpDown_limit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_limit.Name = "numericUpDown_limit";
			this.numericUpDown_limit.Size = new System.Drawing.Size(120, 30);
			this.numericUpDown_limit.TabIndex = 36;
			this.numericUpDown_limit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1134, 613);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.DataGridView_tool);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_tool)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_limit)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_tool;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_details;
        private System.Windows.Forms.RadioButton radioButton_etc;
        private System.Windows.Forms.RadioButton radioButton_tool;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_name;
        private System.Windows.Forms.Button button_addName;
		private System.Windows.Forms.NumericUpDown numericUpDown_limit;
		private System.Windows.Forms.Label label8;
	}
}
﻿
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
			this.DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox_phone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button_add = new System.Windows.Forms.Button();
			this.button_clear = new System.Windows.Forms.Button();
			this.textBox_address = new System.Windows.Forms.TextBox();
			this.radioButton_female = new System.Windows.Forms.RadioButton();
			this.radioButton_male = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox_Lname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_Fname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(934, 51);
			this.panel1.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(417, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(169, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Eszköz felvétele";
			// 
			// DataGridView_student
			// 
			this.DataGridView_student.AllowUserToAddRows = false;
			this.DataGridView_student.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DataGridView_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridView_student.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView_student.ColumnHeadersHeight = 24;
			this.DataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
			this.DataGridView_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_student.Location = new System.Drawing.Point(13, 57);
			this.DataGridView_student.Name = "DataGridView_student";
			this.DataGridView_student.RowHeadersVisible = false;
			this.DataGridView_student.RowTemplate.Height = 80;
			this.DataGridView_student.Size = new System.Drawing.Size(909, 20);
			this.DataGridView_student.TabIndex = 3;
			this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.DataGridView_student.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.DataGridView_student.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_student.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DataGridView_student.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_student.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.DataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DataGridView_student.ThemeStyle.HeaderStyle.Height = 24;
			this.DataGridView_student.ThemeStyle.ReadOnly = false;
			this.DataGridView_student.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_student.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DataGridView_student.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_student.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_student.ThemeStyle.RowsStyle.Height = 80;
			this.DataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_student.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.textBox_phone);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.button_add);
			this.panel2.Controls.Add(this.button_clear);
			this.panel2.Controls.Add(this.textBox_address);
			this.panel2.Controls.Add(this.radioButton_female);
			this.panel2.Controls.Add(this.radioButton_male);
			this.panel2.Controls.Add(this.dateTimePicker1);
			this.panel2.Controls.Add(this.textBox_Lname);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox_Fname);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 122);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(934, 491);
			this.panel2.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(69)))), ((int)(((byte)(107)))));
			this.panel4.Location = new System.Drawing.Point(13, 265);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(909, 10);
			this.panel4.TabIndex = 33;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(69)))), ((int)(((byte)(107)))));
			this.panel3.Location = new System.Drawing.Point(13, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(909, 10);
			this.panel3.TabIndex = 32;
			// 
			// textBox_phone
			// 
			this.textBox_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_phone.Location = new System.Drawing.Point(627, 64);
			this.textBox_phone.Name = "textBox_phone";
			this.textBox_phone.Size = new System.Drawing.Size(156, 27);
			this.textBox_phone.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label6.Location = new System.Drawing.Point(519, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 19);
			this.label6.TabIndex = 30;
			this.label6.Text = "Darabszám:";
			// 
			// button_add
			// 
			this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_add.ForeColor = System.Drawing.Color.White;
			this.button_add.Location = new System.Drawing.Point(808, 444);
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
			this.button_clear.BackColor = System.Drawing.Color.Orange;
			this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_clear.ForeColor = System.Drawing.Color.White;
			this.button_clear.Location = new System.Drawing.Point(663, 444);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(139, 39);
			this.button_clear.TabIndex = 28;
			this.button_clear.Text = "Mezők törlése";
			this.button_clear.UseVisualStyleBackColor = false;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// textBox_address
			// 
			this.textBox_address.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_address.Location = new System.Drawing.Point(125, 167);
			this.textBox_address.Multiline = true;
			this.textBox_address.Name = "textBox_address";
			this.textBox_address.Size = new System.Drawing.Size(624, 50);
			this.textBox_address.TabIndex = 25;
			// 
			// radioButton_female
			// 
			this.radioButton_female.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButton_female.AutoSize = true;
			this.radioButton_female.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.radioButton_female.Location = new System.Drawing.Point(695, 117);
			this.radioButton_female.Name = "radioButton_female";
			this.radioButton_female.Size = new System.Drawing.Size(76, 23);
			this.radioButton_female.TabIndex = 24;
			this.radioButton_female.Text = "Egyéb";
			this.radioButton_female.UseVisualStyleBackColor = true;
			// 
			// radioButton_male
			// 
			this.radioButton_male.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButton_male.AutoSize = true;
			this.radioButton_male.Checked = true;
			this.radioButton_male.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.radioButton_male.Location = new System.Drawing.Point(592, 117);
			this.radioButton_male.Name = "radioButton_male";
			this.radioButton_male.Size = new System.Drawing.Size(97, 23);
			this.radioButton_male.TabIndex = 23;
			this.radioButton_male.TabStop = true;
			this.radioButton_male.Text = "Szerszám";
			this.radioButton_male.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePicker1.Location = new System.Drawing.Point(125, 115);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(291, 27);
			this.dateTimePicker1.TabIndex = 22;
			this.dateTimePicker1.Visible = false;
			// 
			// textBox_Lname
			// 
			this.textBox_Lname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_Lname.Location = new System.Drawing.Point(375, 64);
			this.textBox_Lname.Name = "textBox_Lname";
			this.textBox_Lname.Size = new System.Drawing.Size(135, 27);
			this.textBox_Lname.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label4.Location = new System.Drawing.Point(271, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 19);
			this.label4.TabIndex = 20;
			this.label4.Text = "Méret:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label2.Location = new System.Drawing.Point(505, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 19);
			this.label2.TabIndex = 19;
			this.label2.Text = "Típus:";
			// 
			// textBox_Fname
			// 
			this.textBox_Fname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_Fname.Location = new System.Drawing.Point(125, 64);
			this.textBox_Fname.Name = "textBox_Fname";
			this.textBox_Fname.Size = new System.Drawing.Size(140, 27);
			this.textBox_Fname.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label5.Location = new System.Drawing.Point(40, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 19);
			this.label5.TabIndex = 16;
			this.label5.Text = "Részletek:";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
			this.label3.Location = new System.Drawing.Point(8, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 19);
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
			this.label1.Location = new System.Drawing.Point(21, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 19);
			this.label1.TabIndex = 15;
			this.label1.Text = "Név:";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(934, 613);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.DataGridView_student);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
	}
}
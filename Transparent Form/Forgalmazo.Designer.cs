namespace Transparent_Form
{
	partial class Forgalmazo
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox_forg = new System.Windows.Forms.TextBox();
			this.comboBox_forg = new System.Windows.Forms.ComboBox();
			this.button_add = new System.Windows.Forms.Button();
			this.button_del = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1329, 75);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 577);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1329, 100);
			this.panel2.TabIndex = 1;
			// 
			// textBox_forg
			// 
			this.textBox_forg.Location = new System.Drawing.Point(282, 184);
			this.textBox_forg.Name = "textBox_forg";
			this.textBox_forg.Size = new System.Drawing.Size(214, 22);
			this.textBox_forg.TabIndex = 2;
			// 
			// comboBox_forg
			// 
			this.comboBox_forg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_forg.FormattingEnabled = true;
			this.comboBox_forg.Location = new System.Drawing.Point(824, 182);
			this.comboBox_forg.Name = "comboBox_forg";
			this.comboBox_forg.Size = new System.Drawing.Size(216, 24);
			this.comboBox_forg.TabIndex = 3;
			// 
			// button_add
			// 
			this.button_add.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_add.Location = new System.Drawing.Point(310, 253);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(160, 52);
			this.button_add.TabIndex = 4;
			this.button_add.Text = "Hozzáad";
			this.button_add.UseVisualStyleBackColor = false;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_del
			// 
			this.button_del.BackColor = System.Drawing.Color.Brown;
			this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_del.Location = new System.Drawing.Point(857, 253);
			this.button_del.Name = "button_del";
			this.button_del.Size = new System.Drawing.Size(160, 52);
			this.button_del.TabIndex = 5;
			this.button_del.Text = "Törlés";
			this.button_del.UseVisualStyleBackColor = false;
			this.button_del.Click += new System.EventHandler(this.button_del_Click);
			// 
			// Forgalmazo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1329, 677);
			this.Controls.Add(this.button_del);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.comboBox_forg);
			this.Controls.Add(this.textBox_forg);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Forgalmazo";
			this.Text = "Forgalmazo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox_forg;
		private System.Windows.Forms.ComboBox comboBox_forg;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_del;
	}
}
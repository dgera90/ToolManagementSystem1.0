namespace Transparent_Form
{
    partial class ModifyName
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.radioButton_tool = new System.Windows.Forms.RadioButton();
            this.radioButton_etc = new System.Windows.Forms.RadioButton();
            this.comboBox_list = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_deleteTool = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(199, 261);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(153, 52);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Hozzáad";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // radioButton_tool
            // 
            this.radioButton_tool.AutoSize = true;
            this.radioButton_tool.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_tool.Location = new System.Drawing.Point(195, 57);
            this.radioButton_tool.Name = "radioButton_tool";
            this.radioButton_tool.Size = new System.Drawing.Size(161, 35);
            this.radioButton_tool.TabIndex = 2;
            this.radioButton_tool.TabStop = true;
            this.radioButton_tool.Text = "Szerszám";
            this.radioButton_tool.UseVisualStyleBackColor = true;
            this.radioButton_tool.CheckedChanged += new System.EventHandler(this.radioButton_tool_CheckedChanged);
            // 
            // radioButton_etc
            // 
            this.radioButton_etc.AutoSize = true;
            this.radioButton_etc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_etc.Location = new System.Drawing.Point(488, 57);
            this.radioButton_etc.Name = "radioButton_etc";
            this.radioButton_etc.Size = new System.Drawing.Size(114, 35);
            this.radioButton_etc.TabIndex = 3;
            this.radioButton_etc.TabStop = true;
            this.radioButton_etc.Text = "Egyéb";
            this.radioButton_etc.UseVisualStyleBackColor = true;
            this.radioButton_etc.CheckedChanged += new System.EventHandler(this.radioButton_tool_CheckedChanged);
            // 
            // comboBox_list
            // 
            this.comboBox_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_list.FormattingEnabled = true;
            this.comboBox_list.Location = new System.Drawing.Point(446, 202);
            this.comboBox_list.Name = "comboBox_list";
            this.comboBox_list.Size = new System.Drawing.Size(198, 21);
            this.comboBox_list.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 51);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 98);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(191, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eszköz hozzáadása";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 26);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(482, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eszköz törlése";
            // 
            // button_deleteTool
            // 
            this.button_deleteTool.BackColor = System.Drawing.Color.Brown;
            this.button_deleteTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_deleteTool.ForeColor = System.Drawing.Color.White;
            this.button_deleteTool.Location = new System.Drawing.Point(469, 261);
            this.button_deleteTool.Name = "button_deleteTool";
            this.button_deleteTool.Size = new System.Drawing.Size(153, 52);
            this.button_deleteTool.TabIndex = 10;
            this.button_deleteTool.Text = "Törlés";
            this.button_deleteTool.UseVisualStyleBackColor = false;
            this.button_deleteTool.Click += new System.EventHandler(this.button_deleteTool_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(292, 21);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(188, 54);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Vissza";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // ModifyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_deleteTool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_list);
            this.Controls.Add(this.radioButton_etc);
            this.Controls.Add(this.radioButton_tool);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox1);
            this.Name = "ModifyName";
            this.Text = "Módosítás";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.RadioButton radioButton_tool;
        private System.Windows.Forms.RadioButton radioButton_etc;
        private System.Windows.Forms.ComboBox comboBox_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_deleteTool;
        private System.Windows.Forms.Button button_close;
    }
}
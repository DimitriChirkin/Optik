﻿namespace WindowsFormsApplication5
{
    partial class Form17
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.ID_or = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizv_o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 73;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 26);
            this.button2.TabIndex = 72;
            this.button2.Text = "Обновление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 71;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Продавец";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 31);
            this.button3.TabIndex = 69;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_or,
            this.ID_l,
            this.IS_l,
            this.ID_c,
            this.Proizv_o,
            this.Model_o,
            this.Column2,
            this.ID_a,
            this.Column1,
            this.Column5,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(63, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 259);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(646, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 24);
            this.button4.TabIndex = 74;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ID_or
            // 
            this.ID_or.HeaderText = "ID_b";
            this.ID_or.Name = "ID_or";
            // 
            // ID_l
            // 
            this.ID_l.HeaderText = "Proizv_l";
            this.ID_l.Name = "ID_l";
            // 
            // IS_l
            // 
            this.IS_l.HeaderText = "Model_l";
            this.IS_l.Name = "IS_l";
            // 
            // ID_c
            // 
            this.ID_c.HeaderText = "Price_l";
            this.ID_c.Name = "ID_c";
            // 
            // Proizv_o
            // 
            this.Proizv_o.HeaderText = "Proizv_o";
            this.Proizv_o.Name = "Proizv_o";
            // 
            // Model_o
            // 
            this.Model_o.HeaderText = "Model_o";
            this.Model_o.Name = "Model_o";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price_o";
            this.Column2.Name = "Column2";
            // 
            // ID_a
            // 
            this.ID_a.HeaderText = "Famyly_e ";
            this.ID_a.Name = "ID_a";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Famyly_c";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data_or";
            this.Column5.MaxInputLength = 10;
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prodano";
            this.Column3.Name = "Column3";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(719, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 75;
            this.button5.Text = "Продать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form17";
            this.Text = "Проданные линзы и оправы";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_or;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizv_o;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_o;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button5;
    }
}
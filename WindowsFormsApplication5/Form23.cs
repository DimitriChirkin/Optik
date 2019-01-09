using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form23 : Form
    {
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private TextBox textBox1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox5;
        private TextBox textBox2;

        public Form23()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select accessories.Model_a from accessories where ID_a='" + Form12.ind + " '   ;");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                textBox1.Text = line;
            }

            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select accessories.Proizv_a from accessories where ID_a='" + Form12.ind + " '   ;");
            foreach (string line1 in Rows1)
            {
                string[] columns = line1.Split(';');
                textBox2.Text = line1;
            }

            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb2.GetData("select accessories.Price_a from accessories where ID_a='" + Form12.ind + " '   ;");
            foreach (string line2 in Rows2)
            {
                string[] columns = line2.Split(';');
                maskedTextBox1.Text = line2;
            }

            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb3.GetData("select accessories.Kol_a from accessories where ID_a='" + Form12.ind + " '   ;");
            foreach (string line3 in Rows3)
            {
                string[] columns = line3.Split(';');
                maskedTextBox2.Text = line3;
            }

            QueryDataBase qb4 = new QueryDataBase();
            string[] Rows4 = qb4.GetData("select accessories.Material_a from accessories where ID_a='" + Form12.ind + " '   ;");
            foreach (string line4 in Rows4)
            {
                string[] columns = line4.Split(';');
                comboBox5.Text = line4;
            }
            QueryDataBase qb5 = new QueryDataBase();
            string[] Rows5 = qb5.GetData("select accessories.Categori_a from accessories where ID_a='" + Form12.ind + " '   ;");
            foreach (string line5 in Rows5)
            {
                string[] columns = line5.Split(';');
                comboBox2.Text = line5;
            }
        }

        private void InitializeComponent()
        {
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(62, 200);
            this.maskedTextBox2.Mask = "00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(198, 20);
            this.maskedTextBox2.TabIndex = 85;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(62, 164);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(198, 20);
            this.maskedTextBox1.TabIndex = 84;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Модель*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 81;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Категория*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Материал*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Количество*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Цена*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Производитель*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 74;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Изменить";
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(156, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 25);
            this.button2.TabIndex = 90;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(41, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 89;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Футляр",
            "салфетка для протирания",
            "Цепочка"});
            this.comboBox2.Location = new System.Drawing.Point(61, 281);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 21);
            this.comboBox2.TabIndex = 91;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Метал",
            "Метало-пластик",
            "Пластик",
            "Ткань",
            "Резина",
            "Ткань"});
            this.comboBox5.Location = new System.Drawing.Point(62, 242);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(198, 21);
            this.comboBox5.TabIndex = 92;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // Form23
            // 
            this.ClientSize = new System.Drawing.Size(300, 373);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Name = "Form23";
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.Form23_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0)
                {

                    QueryDataBase qb = new QueryDataBase();


                    qb.GetData("UPDATE `optik`.`accessories` SET `Model_a`='" + textBox1.Text + "', `Proizv_a`='" + textBox2.Text + "', `Price_a`='" + maskedTextBox1.Text + "', `Kol_a`='" + maskedTextBox2.Text + "', `Material_a`='" + comboBox5.Text + "', `Categori_a`='" + comboBox2.Text + "' WHERE `ID_a`='" + Form12.ind + "';");

                }
                else
                {
                    MessageBox.Show("Изменение не выполнено");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Неверны формат данных"); }
        }

        private void Form23_Load(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length != 0 && textBox2.Text.Length != 0 && comboBox1.Text.Length != 0 && maskedTextBox1.Text.Length != 0)
            {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO optik.employes (Famyly_e,Name_e,Position,Phon_e)  VALUES ('" + textBox2.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + maskedTextBox1.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }
                
            }
            else
               { MessageBox.Show("Заполните поля");}
    }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }
    }
}

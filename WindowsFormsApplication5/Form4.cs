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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked == true)
                {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `optik`.`linzi` (`Model_l`, `Proizv_l`, `Price_l`, `Kol_l`, `Material_l`, `OsSmesh`, `Categor_l`, `Diopt`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + maskedTextBox1.Text + "', '" + maskedTextBox2.Text + "', '" + comboBox4.Text + "', '" + maskedTextBox3.Text + "', '" + comboBox1.Text + "', '" + maskedTextBox4.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }


                
                }
                else
                if (radioButton2.Checked == true)
                {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `optik`.`opr` (`Model_o`, `Proizv_o`, `Price_o`, `Kol_o`, `Material_o`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + maskedTextBox1 + "', '" + maskedTextBox2.Text + "', '" + comboBox3.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }
                
                }

                else
                if (radioButton3.Checked == true)
                {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `optik`.`accessories` (`Model_a`, `Proizv_a`, `Price_a`, `Kol_a`, `Material_a`, `Categori_a`)  VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + maskedTextBox1.Text + "', '" + maskedTextBox2.Text + "', '" + comboBox5.Text + "', '" + comboBox2.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }

                
                }

                else
               if (radioButton4.Checked == true)
                {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `optik`.`spectacles` (`Model_s`, `Proizv_s`, `Price_s`, `Kol_s`, `Material_s`, `OsSmesh`, `Categor_s`, `Diopt`)  VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + maskedTextBox1.Text + "', '" + maskedTextBox2.Text + "', '" + comboBox6.Text + "', '" + maskedTextBox3.Text + "', '" + comboBox1.Text + "', '" + maskedTextBox4.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }

                
                }
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                maskedTextBox4.Visible = true;
                maskedTextBox3.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                comboBox4.Visible = true;
                comboBox3.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                maskedTextBox4.Visible = false;
                maskedTextBox3.Visible = false;
                label7.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                comboBox4.Visible = false;
                comboBox3.Visible = true;
                comboBox5.Visible = false;
                comboBox6.Visible = false;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                maskedTextBox4.Visible = false;
                maskedTextBox3.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = true;
                label7.Visible = true;
                comboBox4.Visible = false;
                comboBox3.Visible = false;
                comboBox5.Visible = true;
                comboBox6.Visible = false;
            }
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = false;
            maskedTextBox4.Visible = true;
            maskedTextBox3.Visible = true;
            label7.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            comboBox4.Visible = false;
            comboBox3.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

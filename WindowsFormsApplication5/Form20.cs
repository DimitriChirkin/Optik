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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select spectacles.model_s from spectacles where ID_s='"+Form9.ind+" '   ;");
            foreach (string line in Rows)
            {
            string[] columns = line.Split(';');
                textBox1.Text = line; 
            }

            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select spectacles.Proizv_s from spectacles where ID_s='" + Form9.ind + " '   ;");
            foreach (string line1 in Rows1)
            {
                string[] columns = line1.Split(';');
                textBox2.Text = line1;
            }

            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb2.GetData("select spectacles.Price_s from spectacles where ID_s='" + Form9.ind + " '   ;");
            foreach (string line2 in Rows2)
            {
                string[] columns = line2.Split(';');
                maskedTextBox1.Text = line2;
            }

            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb3.GetData("select spectacles.Kol_s from spectacles where ID_s='" + Form9.ind + " '   ;");
            foreach (string line3 in Rows3)
            {
                string[] columns = line3.Split(';');
                maskedTextBox2.Text = line3;
            }

            QueryDataBase qb4 = new QueryDataBase();
            string[] Rows4 = qb4.GetData("select spectacles.Material_s from spectacles where ID_s='" + Form9.ind + " '   ;");
            foreach (string line4 in Rows4)
            {
                string[] columns = line4.Split(';');
                comboBox6.Text = line4;
            }
            QueryDataBase qb5 = new QueryDataBase();
            string[] Rows5 = qb5.GetData("select spectacles.Categor_s from spectacles where ID_s='" + Form9.ind + " '   ;");
            foreach (string line5 in Rows5)
            {
                string[] columns = line5.Split(';');
                comboBox1.Text = line5;
            }

            QueryDataBase qb6 = new QueryDataBase();
            string[] Rows6 = qb6.GetData("select spectacles.OsSmesh from spectacles where ID_s='" + Form9.ind + " '   ;");
            foreach (string line6 in Rows6)
            {
                string[] columns = line6.Split(';');
                maskedTextBox3.Text = line6;
            }
            QueryDataBase qb7 = new QueryDataBase();
            string[] Rows7 = qb7.GetData("select spectacles.Diopt from spectacles where ID_s='" + Form9.ind + " '   ;");
            foreach (string line7 in Rows7)
            {
                string[] columns = line7.Split(';');

                maskedTextBox4.Text = line7;
            }
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            try
            {



                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0)
                {

                    QueryDataBase qb = new QueryDataBase();


                    qb.GetData("UPDATE `optik`.`spectacles` SET `Model_s`='" + textBox1.Text + "', `Proizv_s`='" + textBox2.Text + "', `Price_s`='" + maskedTextBox1.Text + "', `Kol_s`='" + maskedTextBox2.Text + "', `Material_s`='" + comboBox6.Text + "', `OsSmesh`='" + maskedTextBox3.Text + "', `Categor_s`='" + comboBox1.Text + "', `Diopt`='" + maskedTextBox4.Text + "' WHERE `ID_s`='" +Form9.ind + "';");

                }
                else
                {
                    MessageBox.Show("Изменение не выполнено");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Неверны формат данных"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }
    }
}

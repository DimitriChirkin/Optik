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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select opr.model_o from opr where ID_o='" + Form10.ind + " '   ;");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                textBox1.Text = line;
            }

            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select opr.Proizv_o from opr where ID_o='" + Form10.ind + " '   ;");
            foreach (string line1 in Rows1)
            {
                string[] columns = line1.Split(';');
                textBox2.Text = line1;
            }

            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb2.GetData("select opr.Price_o from opr where ID_o='" + Form10.ind + " '   ;");
            foreach (string line2 in Rows2)
            {
                string[] columns = line2.Split(';');
                maskedTextBox1.Text = line2;
            }

            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb3.GetData("select opr.Kol_o from opr where ID_o='" + Form10.ind + " '   ;");
            foreach (string line3 in Rows3)
            {
                string[] columns = line3.Split(';');
                maskedTextBox2.Text = line3;
            }

            QueryDataBase qb4 = new QueryDataBase();
            string[] Rows4 = qb4.GetData("select opr.Material_o from opr where ID_o='" + Form10.ind + " '   ;");
            foreach (string line4 in Rows4)
            {
                string[] columns = line4.Split(';');
                comboBox3.Text = line4;
            }
  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {


                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0)
                {

                    QueryDataBase qb = new QueryDataBase();


                    qb.GetData("UPDATE `optik`.`opr` SET `Model_o`='" + textBox1.Text + "', `Proizv_o`='" + textBox2.Text + "', `Price_o`='" + maskedTextBox1.Text + "', `Kol_o`='" + maskedTextBox2.Text + "', `Material_o`='" + comboBox3.Text + "' WHERE `ID_o`='" + Form10.ind + "';");

                }
                else
                {
                    MessageBox.Show("Изменение не выполнено");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Неверны формат данных"); }
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }
    }
}

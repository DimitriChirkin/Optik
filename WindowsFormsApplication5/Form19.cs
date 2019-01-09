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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();

            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select employes.Name_e from employes where ID_e='" + Form7.ind + " '   ;");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                textBox1.Text = line;
            }
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select employes.Famyly_e from employes where ID_e='" + Form7.ind + " '   ;");
            foreach (string line1 in Rows1)
            {
                string[] columns = line1.Split(';');
                textBox2.Text = line1;
            }
            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb2.GetData("select employes.Position from employes where ID_e='" + Form7.ind + " '   ;");
            foreach (string line2 in Rows2)
            {
                string[] columns = line2.Split(';');
                comboBox1.Text = line2;
            }
            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb3.GetData("select employes.Phon_e from employes where ID_e='" + Form7.ind + " '   ;");
            foreach (string line3 in Rows3)
            {
                string[] columns = line3.Split(';');
                maskedTextBox1.Text = line3;
            }
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {




                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0)
                {

                    QueryDataBase qb = new QueryDataBase();


                    qb.GetData("UPDATE `optik`.`employes` SET  `Famyly_e`='" + textBox2.Text + "', `Name_e`='" + textBox1.Text + "', `Position`='" + comboBox1.Text + "', `Phon_e`='" + maskedTextBox1.Text + "' WHERE `ID_e`='" + Form7.ind+ "';");

                }
                else
                {
                    MessageBox.Show("Изменение не выполнено");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Неверны формат данных"); }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

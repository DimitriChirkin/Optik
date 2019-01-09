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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
     
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select clients.Name_c from clients where ID_c='" + Form6.ind + " '   ;");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                textBox1.Text = line;
            }
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select Clients.Famyly_c from Clients where ID_c='" + Form6.ind + " '   ;");
            foreach (string line1 in Rows1)
            {
                string[] columns = line1.Split(';');
                textBox2.Text = line1;
            }
            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb2.GetData("select Clients.E_mail from Clients where ID_c='" + Form6.ind + " '   ;");
            foreach (string line2 in Rows2)
            {
                string[] columns = line2.Split(';');
                textBox3.Text = line2;
            }
            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb3.GetData("select Clients.Phon_c from Clients where ID_c='" + Form6.ind + " '   ;");
            foreach (string line3 in Rows3)
            {
                string[] columns = line3.Split(';');
                maskedTextBox1.Text = line3;
            }
        }

        private void Form18_Load(object sender, EventArgs e)
        {
    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private  void button2_Click(object sender, EventArgs e)
        {
            try
            {





                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0)
                {

                    QueryDataBase qb = new QueryDataBase();


                    qb.GetData("UPDATE `optik`.`clients` SET `Famyly_c`='" + textBox1.Text + "', `Name_c`='" + textBox2.Text + "', `E_mail`='" + textBox3.Text + "', `Phon_c`='" + maskedTextBox1.Text + "' WHERE `ID_C`='" + Form6.ind + "';");

                }
                else
                {
                    MessageBox.Show("Изменение не выполнено");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Неверны формат данных"); }


            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

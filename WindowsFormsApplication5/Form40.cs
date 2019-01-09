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
    public partial class Form40 : Form
    {
        public Form40()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                InitializeComponent();
                QueryDataBase qb = new QueryDataBase();
                MessageBox.Show(textBox1.Text);
                string[] Rows = qb.GetData("select  s.Proizv_s , s.Model_s , s.Price_s  from ((ord join spectacles s on ord.ID_s=s.ID_s) join employes e on ord.ID_e=e.ID_e)join clients c on ord.ID_c=c.ID_c where ord.Data_or>'" + textBox1.Text+ "' and ord.Data_or<" + textBox2.Text + " ; ");
                foreach (string line in Rows)
                {
                    string[] columns = line.Split(';');
                    dataGridView1.Rows.Add(columns);
                }
                QueryDataBase qb1 = new QueryDataBase();
                string[] Rows1 = qb.GetData("select  a.Proizv_a , a.Model_a , a.Price_a  from ord1 join accessories a on ord1.ID_a=a.ID_a  where ord1.Data_or>'" + textBox1.Text + "' and ord1.Data_or<" + textBox2.Text + " ; ");
                foreach (string line in Rows1)
                {
                    string[] columns = line.Split(';');
                    dataGridView1.Rows.Add(columns);
                }



                label1.Text = "Все продажи ";
                double balans = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    double incom;
                    double.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom);
                    balans += incom;
                }
                label1.Text = label1.Text + balans.ToString();
            }
            catch (NullReferenceException) { }
            catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Введите правильный формат даты"); }
        }

        private void Form40_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

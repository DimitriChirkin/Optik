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
    public partial class Form9 : Form
    {
       
        public static int ind;

        public  Form9()
        {


            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select spectacles.ID_s,spectacles.Model_s,spectacles.Proizv_s,spectacles.Price_s,spectacles.kol_s,spectacles.Material_s,spectacles.OsSmesh,spectacles.Categor_s,spectacles.Diopt  from spectacles ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private  void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox1.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if ((dataGridView1[7, i].Value.ToString() != comboBox1.Text) || (dataGridView1[5, i].Value.ToString() != comboBox2.Text))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
         if (comboBox1.Text != "" && comboBox2.Text == "")
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1[7, i].Value.ToString() != comboBox1.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            else
           if (comboBox2.Text != "" && comboBox1.Text == "")
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1[5, i].Value.ToString() != comboBox2.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select spectacles.ID_s,spectacles.Model_s,spectacles.Proizv_s,spectacles.Price_s,spectacles.kol_s,spectacles.Material_s,spectacles.OsSmesh,spectacles.Categor_s,spectacles.Diopt  from spectacles ");
            foreach (string line in Rows)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QueryDataBase qb = new QueryDataBase();
            try
            {

                string[] Rows = qb.GetData("DELETE FROM `optik`.`spectacles` WHERE `ID_s`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Товар удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить товар"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select spectacles.ID_s,spectacles.Model_s,spectacles.Proizv_s,spectacles.Price_s,spectacles.kol_s,spectacles.Material_s,spectacles.OsSmesh,spectacles.Categor_s,spectacles.Diopt  from spectacles ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }

        }

        private static void button5_Click(object sender, EventArgs e)
        {
      
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

            Form20 F20 = new Form20();
            F20.Show();
        }

    
    }
}
    
   


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
    public partial class Form11 : Form
    {
        public static int ind;
        public Form11()
        {

            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select linzi.ID_l,linzi.Model_l,linzi.Proizv_l,linzi.Price_l,linzi.kol_l,linzi.Material_l,linzi.OsSmesh,linzi.Categor_l,linzi.Diopt  from linzi ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text !="" && comboBox2.Text != "")
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
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1[7, i].Value.ToString() != comboBox1.Text)
                    {
                        
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
           if (comboBox2.Text != "" && comboBox1.Text == "")
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1[5, i].Value.ToString() != comboBox2.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select linzi.ID_l,linzi.Model_l,linzi.Proizv_l,linzi.Price_l,linzi.kol_l,linzi.Material_l,linzi.OsSmesh,linzi.Categor_l,linzi.Diopt  from linzi ");
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
                string[] Rows = qb.GetData("DELETE FROM `optik`.`linzi` WHERE `ID_l`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Товар удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить товар"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select linzi.ID_l,linzi.Model_l,linzi.Proizv_l,linzi.Price_l,linzi.kol_l,linzi.Material_l,linzi.OsSmesh,linzi.Categor_l,linzi.Diopt  from linzi ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Form22 F22 = new Form22();
            F22.Show();
        }
    }
}

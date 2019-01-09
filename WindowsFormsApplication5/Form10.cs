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
    public partial class Form10 : Form
    {
        public static int ind;
        public Form10()
        {


            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select opr.ID_o,opr.Model_o,opr.Proizv_o,opr.Price_o,opr.kol_o,opr.Material_o from opr ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form10_Load(object sender, EventArgs e)
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

           /* if (comboBox1.Text != null && comboBox1 != null)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if ((dataGridView1[7, i].Value.ToString() != comboBox1.Text) && (dataGridView1[5, i].Value.ToString() != comboBox2.Text))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            else
         if (comboBox1.Text != null && comboBox2.Text == null)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1[7, i].Value.ToString() != comboBox1.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            else*/
           if (comboBox2.Text != null )
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1[5, i].Value.ToString() != comboBox2.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select opr.ID_o,opr.Model_o,opr.Proizv_o,opr.Price_o,opr.kol_o,opr.Material_o from opr ");
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
            try { 
            string[] Rows = qb.GetData("DELETE FROM `optik`.`opr` WHERE `ID_o`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
            dataGridView1.Rows.Clear();
            MessageBox.Show("Товар удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить товар"); }
    dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select opr.ID_o,opr.Model_o,opr.Proizv_o,opr.Price_o,opr.kol_o,opr.Material_o from opr ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
    dataGridView1.Rows.Add(columns);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Form21 F21 = new Form21();
            F21.Show();
        }
    }
    }


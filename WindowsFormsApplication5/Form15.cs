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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select ord.ID_or , s.Proizv_s , s.Model_s , s.Price_s , e.Famyly_e , c.Famyly_c , ord.Data_or from ((ord join spectacles s on ord.ID_s=s.ID_s) join employes e on ord.ID_e=e.ID_e)join clients c on ord.ID_c=c.ID_c  ; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            
                        for (int i = 0; i < dataGridView1.Rows.Count-1 ; i++)
                        {
                            int k = 0;
                            string s = dataGridView1[4, i].Value.ToString();
                           
                            if (s.Contains(textBox1.Text) )
                            {
                                k++;

                            }
                            if (k == 0)
                            { dataGridView1.Rows.RemoveAt(i); }

                        }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select ord.ID_or , s.Proizv_s , s.Model_s , s.Price_s , e.Famyly_e , c.Famyly_c , ord.Data_or from ((ord join spectacles s on ord.ID_s=s.ID_s) join employes e on ord.ID_e=e.ID_e)join clients c on ord.ID_c=c.ID_c  ; ");
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
                string[] Rows = qb.GetData("DELETE FROM `optik`.`ord` WHERE `ID_or`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Продажа удалена");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить продажу"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select ord.ID_or , s.Proizv_s , s.Model_s , s.Price_s , e.Famyly_e , c.Famyly_c , ord.Data_or from ((ord join spectacles s on ord.ID_s=s.ID_s) join employes e on ord.ID_e=e.ID_e)join clients c on ord.ID_c=c.ID_c  ; ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}


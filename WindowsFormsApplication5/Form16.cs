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
    public partial class Form16 : Form
    {
        public Form16()
        {

            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select ord1.ID_or1 , a.Proizv_a , a.Model_a , a.Price_a , e.Famyly_e , c.Famyly_c , ord1.Data_or from ((ord1 join accessories a on ord1.ID_a=a.ID_a) join employes e on ord1.ID_e=e.ID_e)join clients c on ord1.ID_c=c.ID_c  ; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select ord1.ID_or1 , a.Proizv_a , a.Model_a , a.Price_a , e.Famyly_e , c.Famyly_c , ord1.Data_or from ((ord1 join accessories a on ord1.ID_a=a.ID_a) join employes e on ord1.ID_e=e.ID_e)join clients c on ord1.ID_c=c.ID_c  ; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != null)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1[4, i].Value.ToString() != textBox1.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
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
                string[] Rows = qb.GetData("DELETE FROM `optik`.`ord1` WHERE `ID_or1`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Продажа удалена");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить продажу"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select ord1.ID_or1 , a.Proizv_a , a.Model_a , a.Price_a , e.Famyly_e , c.Famyly_c , ord1.Data_or from ((ord1 join accessories a on ord1.ID_a=a.ID_a) join employes e on ord1.ID_e=e.ID_e)join clients c on ord1.ID_c=c.ID_c  ; ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }
    }
}

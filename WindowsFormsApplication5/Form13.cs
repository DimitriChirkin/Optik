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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select ord.ID_or , s.Proizv_s , s.Model_s , s.Price_s , e.Famyly_e , c.Famyly_c , ord.Data_or from (((ord join spectacles s on ord.ID_s=s.ID_s) join employes e on ord.ID_e=e.ID_e)join clients c on ord.ID_c=c.ID_c )join accessories a on ord.ID_a=a.ID_a ; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select ord.ID_or , s.Proizv_s , s.Model_s , s.Price_s , e.Famyly_e , c.Famyly_c , ord.Data_or from (((ord join spectacles s on ord.ID_s=s.ID_s) join employes e on ord.ID_e=e.ID_e)join clients c on ord.ID_c=c.ID_c )join accessories a on ord.ID_a=a.ID_a ; ");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

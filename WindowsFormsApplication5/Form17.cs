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
    public partial class Form17 : Form
    {
        public Form17()
        {

            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select b.ID_b, l.Proizv_l , l.Model_l,l.Price_l,o.Proizv_o , o.Model_o,o.Price_o,e.Famyly_e,c.Famyly_c,b.Data_or,b.Prodano from(((buy b join linzi l on b.ID_l = l.ID_l) join opr o on o.ID_o = b.ID_o) join employes e on b.ID_e = e.ID_e) join Clients c on c.ID_c = b.ID_c; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select b.ID_b, l.Proizv_l , l.Model_l,l.Price_l,o.Proizv_o , o.Model_o,o.Price_o,e.Famyly_e,c.Famyly_c,b.Data_or,b.Prodano from(((buy b join linzi l on b.ID_l = l.ID_l) join opr o on o.ID_o = b.ID_o) join employes e on b.ID_e = e.ID_e) join Clients c on c.ID_c = b.ID_c; ");
            foreach (string line in Rows1)
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
                    if (dataGridView1[7, i].Value.ToString() != textBox1.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                string[] Rows = qb.GetData("DELETE FROM `optik`.`buy` WHERE `ID_b`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Продажа удалена");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить продажу"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select b.ID_b, l.Proizv_l , l.Model_l,l.Price_l,o.Proizv_o , o.Model_o,o.Price_o,e.Famyly_e,c.Famyly_c,b.Data_or from(((buy b join linzi l on b.ID_l = l.ID_l) join opr o on o.ID_o = b.ID_o) join employes e on b.ID_e = e.ID_e) join Clients c on c.ID_c = b.ID_c; ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ind1 = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            int ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[10].Value);
            
            if (ind != 1)
            {
             
                QueryDataBase qb = new QueryDataBase();
                qb.GetData("UPDATE `optik`.`buy` SET `Prodano`=1 WHERE `ID_b`='" + ind1 + "';");
            } 
        }
    }
}

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
    public partial class Form6 : Form
    {
        public static int Cli;
        public static int ind;
        public Form6()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select clients.ID_C,clients.Name_c,clients.Famyly_c,clients.E_mail,clients.Phon_c  from clients ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }

        }

        public  void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != null && textBox2 != null)
                for (int p = 0; p < dataGridView1.Rows.Count - 1; p++)
                    for (int q = 0; q < dataGridView1.Rows.Count - 1; q++)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int k = 0;
                        string s = dataGridView1[1, i].Value.ToString();
                        string r = dataGridView1[2, i].Value.ToString();
                        if (s.Contains(textBox1.Text) && r.Contains(textBox2.Text))
                        {
                            k++;

                        }
                        if (k == 0)
                        { dataGridView1.Rows.RemoveAt(i); }

                    }
            else

               if (textBox1.Text != null && textBox2.Text == null)
                for (int q = 0; q < dataGridView1.Rows.Count - 1; q++)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int k = 0;
                        string s = dataGridView1[1, i].Value.ToString();

                        if (s.Contains(textBox1.Text))
                        {
                            k++;

                        }
                        if (k == 0)
                        { dataGridView1.Rows.RemoveAt(i); }

                    }

            else
             if (textBox2.Text != null && textBox1.Text == null)
                for (int q = 0; q < dataGridView1.Rows.Count - 1; q++)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int k = 0;
                        string s = dataGridView1[2, i].Value.ToString();

                        if (s.Contains(textBox2.Text))
                        {
                            k++;

                        }
                        if (k == 0)
                        { dataGridView1.Rows.RemoveAt(i); }

                    }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select clients.ID_C,clients.Name_c,clients.Famyly_c,clients.E_mail,clients.Phon_c  from clients ");
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
                
                string[] Rows = qb.GetData("DELETE FROM `optik`.`clients` WHERE `ID_C`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Пользователь удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить пользователя"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select clients.ID_C,clients.Name_c,clients.Famyly_c,clients.E_mail,clients.Phon_c  from clients ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Form18 F18 = new Form18();
            F18.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cli = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }
    }
}

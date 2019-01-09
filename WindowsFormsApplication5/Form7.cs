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
    public partial class Form7 : Form
    {
        public static int ind;
        public static int Empl;
        public Form7()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select employes.ID_e,employes.Name_e,employes.Famyly_e,employes.Position,employes.Phon_e  from employes ");
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
             if (textBox1.Text != null && textBox2 != null)
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
                    int k=0;   
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
    

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select employes.ID_e,employes.Name_e,employes.Famyly_e,employes.Position,employes.Phon_e  from employes ");
            foreach (string line in Rows)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

                string[] Rows = qb.GetData("DELETE FROM `optik`.`employes` WHERE `ID_e`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Пользователь удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить пользователя"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("select employes.ID_e,employes.Name_e,employes.Famyly_e,employes.Position,employes.Phon_e  from employes ");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Form19 F19 = new Form19();
            F19.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Empl = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
           
           
        }
    }
}

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
    public partial class Form30 : Form
    {
        public static int Empl;
        public Form30()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Empl = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form31 F31 = new WindowsFormsApplication5.Form31();
            F31.Show();
            this.Close();
        }

        private void Form30_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

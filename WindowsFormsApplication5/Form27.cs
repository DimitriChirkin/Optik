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
    public partial class Form27 : Form
    {
        public static int Cli;
        public Form27()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cli = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void Form27_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Form24 F24 = new Form24();
            F24.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form27_Load(object sender, EventArgs e)
        {

        }
    }
}

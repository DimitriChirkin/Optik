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
    public partial class Form31 : Form
    {
        public static int Cli;
        public Form31()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           Cli = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form32 F32 = new WindowsFormsApplication5.Form32();
            F32.Show();
            this.Close();
        }

        private void Form31_Load(object sender, EventArgs e)
        {

        }
    }
}

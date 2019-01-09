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
    public partial class Form29 : Form
    {
        public static int acs;
        public Form29()
        {

            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select accessories.ID_a,accessories.Model_a,accessories.Proizv_a,accessories.Price_a,accessories.kol_a,accessories.Material_a,accessories.Categori_a  from accessories where Kol_a>0 ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form29_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            acs = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select accessories.ID_a,accessories.Model_a,accessories.Proizv_a,accessories.Price_a,accessories.kol_a,accessories.Material_a,accessories.Categori_a  from accessories where Kol_a>0 ");
            foreach (string line in Rows1)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }
    }
}

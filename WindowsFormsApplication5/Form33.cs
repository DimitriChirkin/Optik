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
    public partial class Form33 : Form
    {
        public static int linz;
        public Form33()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select linzi.ID_l,linzi.Model_l,linzi.Proizv_l,linzi.Price_l,linzi.kol_l,linzi.Material_l,linzi.OsSmesh,linzi.Categor_l,linzi.Diopt  from linzi  where kol_l>0 ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            } 
        }

        private void Form33_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select linzi.ID_l,linzi.Model_l,linzi.Proizv_l,linzi.Price_l,linzi.kol_l,linzi.Material_l,linzi.OsSmesh,linzi.Categor_l,linzi.Diopt  from linzi   where kol_l>0");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            linz = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

        }
    }
}

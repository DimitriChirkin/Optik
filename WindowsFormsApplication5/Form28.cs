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
    public partial class Form28 : Form
    {
        public static int spec;
        public Form28()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select spectacles.ID_s,spectacles.Model_s,spectacles.Proizv_s,spectacles.Price_s,spectacles.kol_s,spectacles.Material_s,spectacles.OsSmesh,spectacles.Categor_s,spectacles.Diopt  from spectacles where Kol_s>0 ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form28_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            spec = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select spectacles.ID_s,spectacles.Model_s,spectacles.Proizv_s,spectacles.Price_s,spectacles.kol_s,spectacles.Material_s,spectacles.OsSmesh,spectacles.Categor_s,spectacles.Diopt  from spectacles where Kol_s>0 ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }
    }
}

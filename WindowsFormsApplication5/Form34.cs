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
    public partial class Form34 : Form
    {
        public static int opr;
        public Form34()
        {

            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select opr.ID_o,opr.Model_o,opr.Proizv_o,opr.Price_o,opr.kol_o,opr.Material_o from opr where kol_o>0");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            InitializeComponent();
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows = qb1.GetData("select opr.ID_o,opr.Model_o,opr.Proizv_o,opr.Price_o,opr.kol_o,opr.Material_o from opr where kol_o>0 ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Form34_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            opr = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

        }
    }
}

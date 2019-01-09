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
    public partial class Form37 : Form
    {
        public Form37()
        {
            InitializeComponent();
        }

        private void Form37_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select Name_e, Famyly_e ,count(2) Kol_prodag from((employes e join ord o on o.ID_e = e.ID_e) join ord1 o1 on o1.ID_e = e.ID_e) join buy b on b.ID_e = e.ID_e group by Name_e, Famyly_e order by count(2) desc limit 1 ; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

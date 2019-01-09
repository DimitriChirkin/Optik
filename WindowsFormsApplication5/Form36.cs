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
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("select Proizv_s, Model_s ,count(2) Kol_prodag from ord o join spectacles s on o.ID_s = s.ID_s group by Proizv_s, Model_s order by count(2) desc limit 1; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb1.GetData("select Proizv_a, Model_a ,count(2) Kol_prodag from ord1 o join accessories a on o.ID_a = a.ID_a group by Proizv_a, Model_a order by count(2) desc limit 1; ");
            foreach (string line in Rows1)
            {
                string[] columns = line.Split(';');
                dataGridView2.Rows.Add(columns);
            }

            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb2.GetData("select Proizv_l, Model_l ,count(2) Kol_prodag from buy b join linzi l on b.ID_l = l.ID_l group by Proizv_l, Model_l order by count(2) desc limit 1; ");
            foreach (string line in Rows2)
            {
                string[] columns = line.Split(';');
                dataGridView3.Rows.Add(columns);
            }
            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb3.GetData("select Proizv_o, Model_o ,count(2) Kol_prodag from buy b join opr o on b.ID_o = o.ID_o group by Proizv_o, Model_o order by count(2) desc limit 1; ");
            foreach (string line in Rows3)
            {
                string[] columns = line.Split(';');
                dataGridView4.Rows.Add(columns);
            }
        }

        private void Form36_Load(object sender, EventArgs e)
        {

        }
    }
}

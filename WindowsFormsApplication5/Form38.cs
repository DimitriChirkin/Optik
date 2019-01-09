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
    public partial class Form38 : Form
    {
        public Form38()
        {try
            {
                InitializeComponent();
                QueryDataBase qb = new QueryDataBase();
                string[] Rows = qb.GetData("select  s.Proizv_s , s.Model_s , s.Price_s  from ((ord join spectacles s on ord.ID_s=s.ID_s) join employes e on ord.ID_e=e.ID_e)join clients c on ord.ID_c=c.ID_c where Data_or='"+DateTime.Now.ToShortDateString()+"' ; ");
                foreach (string line in Rows)
                {
                    string[] columns = line.Split(';');
                    dataGridView1.Rows.Add(columns);
                }
                QueryDataBase qb1 = new QueryDataBase();
                string[] Rows1 = qb1.GetData("select  a.Proizv_a , a.Model_a , a.Price_a  from ord1 join accessories a on ord1.ID_a=a.ID_a  where ord1.Data_or='"+ DateTime.Now.ToShortDateString() + "' ; ");
                foreach (string line in Rows1)
                {
                    string[] columns = line.Split(';');
                    dataGridView1.Rows.Add(columns);
                }

                QueryDataBase qb2 = new QueryDataBase();
                string[] Rows2 = qb2.GetData("SELECT concat(l.Proizv_l+' '+o.Proizv_o), concat(l.Proizv_l+' '+o.Proizv_o),(l.Price_l+o.Price_o) FROM (optik.buy b join linzi l on l.ID_l=b.ID_l) join opr o on o.ID_o=b.ID_o where b.Prodano = 1 and b.Data_or='" + DateTime.Now.ToShortDateString() + "' ;");
                foreach (string line in Rows2)
                {
                    string[] columns = line.Split(';');
                    dataGridView1.Rows.Add(columns);
                }

                label1.Text = "Все продажи ";
                double balans = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    double incom;
                    double.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom);
                    balans += incom;
                }
                label1.Text = label1.Text + balans.ToString();
            }
            catch (NullReferenceException) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form38_Load(object sender, EventArgs e)
        {

        }
    }
}

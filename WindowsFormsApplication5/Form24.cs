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
    public partial class Form24 : Form
    {
        public static int del;
        public int[] ID = new int[100];
        int a=0;
        public  char[] Type = new char[100]; 
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {for (int i = 0; i <= a-1; i++)
            {
                if (Type[i]=='s')
                {
                    if (ID[i] != 0)
                    {
                        QueryDataBase qb = new QueryDataBase();
                        if (ID[i] != 0)
                        {

                            string s = DateTime.Now.ToShortDateString();
                            qb.InsertData("INSERT INTO `optik`.`ord` ( `ID_s`, `ID_e`, `ID_c`, `Data_or`) VALUES ( '" + ID[i] + "', '" + Form26.Empl + "', '" + Form27.Cli + "', '" + s + "');");
                        }
                    }
                }
                
                if (Type[i] == 'a')
                {
                    
                    QueryDataBase qb1 = new QueryDataBase();
                    if (ID[i] != 0)
                    {
                        string s1 = DateTime.Now.ToShortDateString();
                        qb1.InsertData("INSERT INTO `optik`.`ord1` ( `ID_a`, `ID_e`, `ID_c`, `Data_or`) VALUES ( '" + ID[i] + "', '" + Form26.Empl + "', '" + Form27.Cli + "', '" + s1 + "');");
                    }
                }

            }
            MessageBox.Show("Продажа прошла успешно");
            System.IO.FileStream fs = new System.IO.FileStream(@"C:\Новая папка\2.txt", System.IO.FileMode.Create);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(fs);

            try
            {
                streamWriter.WriteLine("Чек");
                streamWriter.WriteLine("============================================================================================");

                streamWriter.WriteLine("Дата продажи-" + DateTime.Now.ToShortDateString() + "    " );

                streamWriter.WriteLine("============================================================================================");
                streamWriter.WriteLine("Работник              "+"Клиент            "+"Модель        "+"Производитель  "+"Цена ");


                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + "   |    ");
                    }
                   
                    streamWriter.WriteLine();
                }
                streamWriter.WriteLine("================================================================================================");
                streamWriter.WriteLine(label1.Text);
                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
            dataGridView1.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.RemoveAt(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form29.acs >= 0)
                {

                    QueryDataBase qb = new QueryDataBase();

                    string[] Rows = qb.GetData("select (select concat(Famyly_e,' ',Name_e) from employes where ID_e='" + Form26.Empl + "'),(select concat(Famyly_c,' ', Name_c) from clients where ID_C='" + Form27.Cli + "'), Model_a, Proizv_a, Price_a from accessories where ID_a='" + Form29.acs + "' ; ");
                    qb.GetData("UPDATE `optik`.`accessories` SET `Kol_a`=Kol_a-" + 1 + " WHERE `ID_a`='" + Form29.acs + "';");
                    Type[a] = 'a';
                    ID[a] = Form29.acs;
                    a++;
                    try
                    {
                        foreach (string line in Rows)
                        {
                            string[] columns = line.Split(';');
                            dataGridView1.Rows.Add(columns);
                        }
                      
                    }
                    catch (System.NullReferenceException)
                    { }
                    Form29.acs = -1;
                }
                if (Form28.spec >= 0)
                {

                    QueryDataBase qb1 = new QueryDataBase();
                    string[] Rows1 = qb1.GetData("select (select concat(Famyly_e,' ',Name_e) from employes where ID_e='" + Form26.Empl + "'),(select concat(Famyly_c,' ', Name_c) from clients where ID_C='" + Form27.Cli + "'), Model_s, Proizv_s, Price_s from spectacles where ID_s='" + Form28.spec + "' ; ");
                    qb1.GetData("UPDATE `optik`.`spectacles` SET `Kol_s`=Kol_s-" + 1 + " WHERE `ID_s`='" + Form28.spec + "';");
                    Type[a] ='s';
                    ID[a] = Form28.spec;
                    a++;
                    try
                    {
                        foreach (string line in Rows1)
                        {
                            string[] columns = line.Split(';');
                            dataGridView1.Rows.Add(columns);
                        }

                    }
                    catch (System.NullReferenceException)
                    { }
                    Form28.spec = -1;
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException) { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form28 F28 = new Form28();
            F28.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form29 F29 = new Form29();
            F29.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
                         
   
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label1.Text = "Цена к оплате ";
            double balans = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                double incom;
                double.TryParse((row.Cells[4].Value ?? "0").ToString().Replace(".", ","), out incom);
                balans += incom;
            }
            label1.Text = label1.Text + balans.ToString();

        }

        private void Form24_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i <= a - 1; i++)
            {
                if (Type[i] == 's')
                {
                    if (ID[i] != 0)
                    {
                        QueryDataBase qb = new QueryDataBase();
                        qb.GetData("UPDATE `optik`.`spectacles` SET `Kol_s`=Kol_s-" + 1 + " WHERE `ID_s`='" + Form28.spec + "';");

                    }
                }

                if (Type[i] == 'a')
                {

                    QueryDataBase qb1 = new QueryDataBase();
                    if (ID[i] != 0)
                    {
                        qb1.GetData("UPDATE `optik`.`accessories` SET `Kol_a`=Kol_a-" + 1 + " WHERE `ID_a`='" + Form29.acs + "';");

                    }
                }

            }
        }
    }
}

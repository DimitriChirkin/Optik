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
    public partial class Form32 : Form
    {
        
        public int ID;
       
        public int ID1 ;
        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form33 F33 = new Form33();
            F33.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form34 F34 = new Form34();
            F34.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (Form33.linz >= 0)
                    {

                        QueryDataBase qb = new QueryDataBase();

                        string[] Rows = qb.GetData("select (select concat(Famyly_e,' ',Name_e) from employes where ID_e='" + Form30.Empl + "'),(select concat(Famyly_c,' ', Name_c) from clients where ID_C='" + Form31.Cli + "'), Model_l, Proizv_l, Price_l from linzi where ID_l='" + Form33.linz + "' ; ");
                        qb.GetData("UPDATE `optik`.`linzi` SET `Kol_l`=Kol_l-" + 1 + " WHERE `ID_l`='" + Form33.linz + "';");
                        
                        ID = Form33.linz;
                        
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
                        Form33.linz = -1;
                    }
                    if (Form34.opr >= 0)
                    {

                        QueryDataBase qb1 = new QueryDataBase();
                        string[] Rows1 = qb1.GetData("select (select concat(Famyly_e,' ',Name_e) from employes where ID_e='" + Form30.Empl + "'),(select concat(Famyly_c,' ', Name_c) from clients where ID_C='" + Form31.Cli + "'), Model_o, Proizv_o, Price_o from opr where ID_o='" + Form34.opr + "' ; ");
                        qb1.GetData("UPDATE `optik`.`opr` SET `Kol_o`=Kol_o-" + 1 + " WHERE `ID_o`='" + Form34.opr + "';");
                       
                        ID1 = Form34.opr;
                        
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
                        Form34.opr = -1;
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException) { }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
               
                
                    if (Form34.opr != 0 && Form33.linz != 0)
                    {
                        QueryDataBase qb = new QueryDataBase();
                string s = DateTime.Now.ToShortDateString();
                        qb.InsertData("INSERT INTO `optik`.`buy` (`ID_l`, `ID_o`, `ID_e`, `ID_c`, `Data_or`,`Prodano`) VALUES ('" + ID + "', '"+ ID1 + "', '" + Form30.Empl + "', '"+Form31.Cli+"', '"+ s + "','0');");
                       
                    }
                    else
            { MessageBox.Show("Выберите линзы и оправу"); }
            MessageBox.Show("Продажа прошла успешно");
            ID = 0;
            ID1 = 0;

            System.IO.FileStream fs = new System.IO.FileStream(@"C:\1.txt", System.IO.FileMode.Create);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(fs);

            try
            {
                streamWriter.WriteLine("Чек");
                streamWriter.WriteLine("============================================================================================");

                streamWriter.WriteLine("Дата заказа-"+DateTime.Now.ToShortDateString()+"    "+"Дата изготовления-"+ DateTime.Now.AddDays(3).ToShortDateString());
                streamWriter.WriteLine("============================================================================================");

                streamWriter.WriteLine("Работник              " + "Клиент                  " + "Модель        " + "Производитель  " + "Цена ");


                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + "       ");
                    }

                    streamWriter.WriteLine();
                }
                streamWriter.WriteLine("============================================================================================");

                streamWriter.Write(label1.Text);
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

        private void Form32_FormClosing(object sender, FormClosingEventArgs e)
        {
            QueryDataBase qb = new QueryDataBase();
            qb.GetData("UPDATE `optik`.`linzi` SET `Kol_l`=Kol_l+" + 1 + " WHERE `ID_l`='" + ID+ "';");
            QueryDataBase qb1 = new QueryDataBase();
            qb1.GetData("UPDATE `optik`.`opr` SET `Kol_o`=Kol_o+" + 1 + " WHERE `ID_o`='" + ID1 + "';");

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
    }
    }


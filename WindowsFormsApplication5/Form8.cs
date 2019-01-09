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
    public partial class Form8 : Form
    {
        public static int ind1;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9() ;
            F9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10() ;
            F10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            F11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 F12 = new Form12();
            F12.Show();
        }
    }
}

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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form36 F36 = new WindowsFormsApplication5.Form36();
            F36.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form38 F38 = new WindowsFormsApplication5.Form38();
            F38.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form40 F40 = new Form40();
            F40.Show();
        }
    }
}

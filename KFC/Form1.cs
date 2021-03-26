using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuKFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            НАПИТКИ s = new НАПИТКИ();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            БУРГЕРЫ s = new БУРГЕРЫ();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            БАСКЕТЫ s = new БАСКЕТЫ();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

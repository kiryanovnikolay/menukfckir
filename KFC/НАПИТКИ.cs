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
    public partial class НАПИТКИ : Form
    {
        public НАПИТКИ()
        {
            InitializeComponent();
        }
        int click = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            click = click + 1;
            label1.Text = "Напитки:" + click;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click = click + 1;
            label1.Text = "Напитки:" + click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            click = click + 1;
            label1.Text = "Напитки:" + click;
        }
    }
}

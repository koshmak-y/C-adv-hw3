using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace hm4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
        private void changevalue(object sender, EventArgs e)
        {
            count++;
            textBox1.Text = Convert.ToString(count);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox1.Text = Convert.ToString(count);
        }
    }
}

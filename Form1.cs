using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(300, 300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Size = new Size(1, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
        }
    }
}

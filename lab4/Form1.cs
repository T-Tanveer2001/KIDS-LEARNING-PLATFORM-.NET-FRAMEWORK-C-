using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Form2 Check = new Form2();

                Check.Show();

                Hide();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Check = new Form3();

            Check.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Check = new Form4();

            Check.Show();

            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

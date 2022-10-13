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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            double Marks = 0;

            if (radioButton1.Checked == true)
            {
                Marks += 1;
            }
            if (radioButton4.Checked == true)
            {
                Marks += 1;
            }
            if (radioButton6.Checked == true)
            {
                Marks += 1;
            }
            if (radioButton7.Checked == true)
            {
                Marks += 1;
            }
           
            label16.Text = Marks.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();

            Check.Show();

            Hide();
        }
    }
}

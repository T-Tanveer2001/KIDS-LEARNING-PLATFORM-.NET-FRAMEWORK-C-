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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            double Marks = 0;

            if (radioButton1.Checked == true)
            {
                Marks += 1;
            }
            if (radioButton3.Checked == true)
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
            if (radioButton9.Checked == true)
            {
                Marks += 1;
            }

            label17.Text = Marks.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();

            Check.Show();

            Hide();
        }
    }
}

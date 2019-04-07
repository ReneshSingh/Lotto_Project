using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Lotto_machine gen;
        private OutPutWriter OW;
        private int num_balls = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] balls = new int[num_balls];
            gen = new Lotto_machine();
            OW = OutPutWriter.getInstance();
            gen.Lotto_numbers(balls);
            OW.ArchiveResults(balls);

            label1.Text = "Your lotto numbers are:";
            label2.Text = balls.GetValue(0).ToString();
            label3.Text = balls.GetValue(1).ToString();
            label4.Text = balls.GetValue(2).ToString();
            label5.Text = balls.GetValue(3).ToString();
            label6.Text = balls.GetValue(4).ToString();
            label7.Text = balls.GetValue(5).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

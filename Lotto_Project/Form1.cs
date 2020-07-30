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
        private List<Label> UILabels;
        private List<int> balls; 
        private Lotto_Statistics LottoRecords;
        private void toUI(List<int> balls, string message)
        {
            UILabels[0].Text = message;
            for (int i = 1; i < UILabels.Count(); i++)
                UILabels[i].Text = balls[i-1].ToString();
        }
        public Form1()
        {
            InitializeComponent();
            gen = new Lotto_machine();
            LottoRecords = Lotto_Statistics.getInstance();
            UILabels = new List<Label>();
            UILabels.Add(label1);
            UILabels.Add(label2);
            UILabels.Add(label3);
            UILabels.Add(label4);
            UILabels.Add(label5);
            UILabels.Add(label6);
            UILabels.Add(label7);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            balls = gen.Lotto_numbers(6);
            LottoRecords.AddLotteryDraw(balls);
            LottoRecords.LoteryStatistics(balls);
            toUI(balls, "Your Lotto numbers are:");
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
        private void button2_Click(object sender, EventArgs e)
        {
            balls = gen.Lotto_numbers(5);
            balls.Add(gen.newLottoNUmber(1,20));
            LottoRecords.AddPowerBallDraw(balls);
            LottoRecords.PowerBallStatistics(balls);
            toUI(balls, "Your Power Ball numbers are:");
            label7.Text += "\nPower\nBall";
        }
    }
}

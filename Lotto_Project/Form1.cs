using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOModule;
using LotteryTools;

namespace WindowsFormsApplication1
{
    /*! \class Form1
     * \brief THis is the UI controler class
     */
    public partial class Form1 : Form
    {
        private Lotto_machine gen; //!< \brief Instant of the lotto mechine which handles drawing the balls. 
        private List<Label> UILabels; //!< \brief Holds an aray of all the labels in the UI.
        private List<int> balls = null; //!< \brief Aray to hod the lotto balls been drawn. 
        private Lotto_Statistics LottoRecords; //!<  \brief Holds the statistics of all the draws. 
        /*! \brief Outputs the drawn balls to the UI and displays the message sent to it.
         * 
         * Gets the results from the lotto draw from the internal function and displays the balls drawn along with a message to the UI. 
         */
        private void toUI(List<int> balls, string message)
        {
            UILabels[0].Text = message;
            for (int i = 1; i < UILabels.Count(); i++)
                UILabels[i].Text = balls[i-1].ToString();
        }
        //! \brief UI setup. 
        public Form1()
        {
            InitializeComponent();
            gen = new Lotto_machine();
            displayMSG.Text = " ";
            LottoRecords = Lotto_Statistics.getInstance();
            UILabels = new List<Label>();
            UILabels.Add(displayMSG);
            UILabels.Add(label2);
            UILabels.Add(label3);
            UILabels.Add(label4);
            UILabels.Add(label5);
            UILabels.Add(label6);
            UILabels.Add(label7);
        }
        /*! \brief Performs a 6 ball lotto draw. 
         * 
         * This functions performs a 6 ball draw for a lottery and then sends the results of the draw to the UI output function. 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            displayMSG.Text = "Processing ...";
            button1.Enabled = false;
            if ((Convert.ToInt32(maxBalls.Value) - Convert.ToInt32(minBalls.Value) >= 6))
            {
                for (int i = 0; i < Convert.ToInt32(numDraws.Value); i++)
                {
                    balls = gen.Lotto_numbers(6, Convert.ToInt32(minBalls.Value), Convert.ToInt32(maxBalls.Value));
                    LottoRecords.AddLotteryDraw(balls);
                    LottoRecords.LoteryStatistics(balls);
                }
                toUI(balls, "Your Lotto numbers are:");
            }
            else
                displayMSG.Text = "Not enough balls in range.";
            button1.Enabled = true; 
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

        /*! \brief Performs a PowerBall draw
         * 
         * Performs the PowerBall  draw based on the users configurations for both the normal balls and the powerball 
         */
        private void button2_Click(object sender, EventArgs e)
        {
            displayMSG.Text = "Processing ...";
            button2.Enabled = false;
            if (Convert.ToInt32(maxBalls.Value) - Convert.ToInt32(minBalls.Value) >= 5)
            {
                for (int i = 0; i < Convert.ToInt32(numDraws.Value); i++)
                {
                    balls = gen.Lotto_numbers(5, Convert.ToInt32(minBalls.Value), Convert.ToInt32(maxBalls.Value));
                    balls.Add(gen.newLottoNUmber(Convert.ToInt32(minPowerBall.Value), Convert.ToInt32(maxPowerBall.Value)));
                    LottoRecords.AddPowerBallDraw(balls);
                    LottoRecords.PowerBallStatistics(balls);
                }
                toUI(balls, "Your Power Ball numbers are:");
                label7.Text += "\nPower\nBall";
            }
            else
                displayMSG.Text = "Not enough balls in range.";
            button2.Enabled = true;
        }
        private void maxBalls_ValueChanged(object sender, EventArgs e)
        {
            maxBalls.Minimum = minBalls.Minimum + 6;
        }
        /*! \brief Exports either the lotto or statistical data to the users indicated file and format.
         * 
         * Checks which dataset the user has chosen to export and then connects that dataset with the File IO class. 
         */
        private void ExportData_Click(object sender, EventArgs e)
        {
            Lotto_Statistics ls = Lotto_Statistics.getInstance();
            OutputModule output = OutputModule.getInstance();
            string separator = null, fileName;
            fileName = OutputModule.getFileName(out separator);
            if (PrintLottoDraws.Checked == true)
                output.ToSeparatedFile(ls.Lottery, ls.recordsHeaders,fileName);
            if (PrintLotteryStats.Checked == true)
                output.ToSeparatedFile(ls.LotteryCollection, ls.ballStatsHeaders,fileName);
            if (PrintPowerBallDraws.Checked == true)
                output.ToSeparatedFile(ls.PowerBall, ls.recordsHeaders,fileName);
            if (PrintPowerBallStats.Checked == true)
                output.ToSeparatedFile(ls.PowerBallCollection, ls.ballStatsHeaders,fileName);
        }
    }
}

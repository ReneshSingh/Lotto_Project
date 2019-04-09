using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Lotto_machine
    {
        private OutPutWriter OW;
        private int newBall = 0;
        public Lotto_machine()
        {
            OW = OutPutWriter.getInstance();
        }
        public int newLottoNUmber(int min = 1, int max = 50)
        //Randomly selects a lotto ball in the provided range of min & max. 
        {
            int ball;
            Random r = new Random();
            ball = r.Next(min, max);
            return ball;
        }
        private void uniquenessCheck(List<int> balls, int min, int max)
        {
            do
                newBall = newLottoNUmber(min, max);
            while (balls.Contains(newBall));
        }
        //Populates newBall with a number not found in the list provided. 
        public void Lotto_numbers(int[] balls, int min = 1, int max = 50)
        //Creates a list of lotto numbers
        {
            for (int i = 0; i < balls.Length; i++)
            {
                uniquenessCheck(balls.ToList(), min, max);
                OW.stats(newBall);
                balls[i] = newBall;
            }
        }
        public List<int> Lotto_numbers(int numBalls, int min = 1, int max = 50)
        //Creates a list of lotto numbers
        {
            List<int> balls = new List<int>();
            for (int i = 0; i < numBalls; i++)
            {
                uniquenessCheck(balls, min, max);
                balls.Add(newBall);
                OW.stats(newBall);
            }
            return balls;
        }
    }
}

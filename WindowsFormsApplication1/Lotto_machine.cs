using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Lotto_machine
    {
        private int newLottoNUmber(int min = 1, int max = 50)
        //Randomly selects a lotto ball in the provided range of min & max. 
        {
            int ball;
            Random r = new Random();
            ball = r.Next(min, max);
            return ball;
        }

        public void Lotto_numbers(int[] balls, int max = 50, int min = 1)
            //Creates a list of lotto numbers
        {
            int newBall, Num_balls = balls.GetLength(0);
            for (int i = 0; i < Num_balls; i++)
            {
                newBall = newLottoNUmber(min, max);
                if (balls.GetValue(i).Equals(newBall))
                    i = 0;
                else
                    balls.SetValue(newBall, i);
            }

        }
    }
}

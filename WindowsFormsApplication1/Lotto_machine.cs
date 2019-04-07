using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Lotto_machine
    {
        static private int newLottoNUmber(int min = 1, int max = 50)
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
            OutPutWriter OW = OutPutWriter.getInstance();
            int newBall = 0;
            for (int i = 0; i < balls.Length; i++)
            {
                newBall = newLottoNUmber(min, max);
                for (int j = 0; j < i; j++)
                    if (balls[i] == newBall)
                    {
                        newBall = newLottoNUmber(min, max);
                        j = 0;
                    }
                OW.stats(newBall);
                balls[i] = newBall;
            }
        }
    }
}

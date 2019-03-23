using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class OutPutWriter
    {
        public void ToFile(int[] balls)
        {
            int num_balls = balls.GetLength(0);
            string[] a = new string[num_balls];
            for (int i = 0; i < num_balls; i++)
                a.SetValue(balls.GetValue(i).ToString(), i);
            System.IO.File.AppendAllLines(@"...\LottoResults.txt", a);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class OutPutWriter
    {
        static private OutPutWriter OPW;
        static private bool instance = false;
        private List<String> Statistics;
        private string[] temp = null;
        //Constructor for singleton pattern, also reads statistics file into memory.
        private OutPutWriter()
        {
            instance = true;
            if (!System.IO.File.Exists(@".../Lotto_Statistics.csv"))
            {
                System.IO.File.Create(@".../Lotto_Statistics.csv");
                Statistics = new List<string>();
            }
            else
            {
                temp = System.IO.File.ReadAllLines(@".../Lotto_Statistics.csv");
                Statistics = temp.ToList();
            }
            Statistics.Sort();
        }
        //Cleans up and writes data to file. 
        ~OutPutWriter()
        {
            Statistics.Sort();
            System.IO.File.WriteAllLines(@".../Lotto_Statistics.csv", Statistics);
        }
        // Returns an instant of the OutPutWriter or creats it if it doesn’t exist. (part of the singleton patten).
        static public OutPutWriter getInstance()
        {
            if (!instance)
                OPW = new OutPutWriter();
            return OPW;
        }
        //Archives the results of a lotto draw. 
        //In the process of refactoring, such that it rights to a DB. 
        public void ArchiveResults(int[] balls)
        {
            int num_balls = balls.GetLength(0);
            string[] a = new string[num_balls];
            for (int i = 0; i < num_balls; i++)
                a.SetValue(balls.GetValue(i).ToString(), i);
            System.IO.File.AppendAllLines(@".../LottoResults.txt", a);
        }
        //Updates the statistics based on the ball drawn. 
        public void stats(int ball)
        {
            int n = 0;
            bool found = false;
            System.IO.File.WriteAllLines("E:/Lotto_Project/WindowsFormsApplication1/WindowsFormsApplication1/LottoResults.txt", Statistics);
            if (!Statistics.Any())
                foreach (string i in Statistics)
                {
                    n++;
                    if (temp[0] == ball.ToString())
                    {
                        int Occurrences;
                        Occurrences = Convert.ToInt32(temp[1]);
                        Occurrences++;
                        temp[1] = Occurrences.ToString();
                        Statistics[n] = temp[0] + "," + temp[1];
                        found = true;
                        break;
                    }
                }
            if (!found)
                Statistics.Add($"{ball},1");
            
        }
    }
}
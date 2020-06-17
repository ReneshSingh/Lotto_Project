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
        private List<String> Statistics, Draws;
        private string[] temp = null;
        //! \brief Constructor for singleton pattern, also reads statistics file into memory.
        private OutPutWriter()
        {
            instance = true;
            Draws = new List<String>();
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
            //Statistics.Sort();
        }
        //! \brief Cleans up and writes data to file. 
        ~OutPutWriter()
        {
            //Statistics.Sort();
            System.IO.File.WriteAllLines(@".../Lotto_Statistics.csv", Statistics);
            System.IO.File.AppendAllLines(@".../Lotto_Results.csv", Draws);
        }
        //! \brief Returns an instant of the OutPutWriter or creats it if it doesn’t exist. (part of the singleton patten).
        static public OutPutWriter getInstance()
        {
            if (!instance)
                OPW = new OutPutWriter();
            return OPW;
        }
        //! \brief Archives the results of a lotto draw. 
        public void ArchiveResults(int[] balls)
        {
            int num_balls = balls.GetLength(0);
            string b = null;
            for (int i = 0; i < num_balls; i++)
                b += balls.GetValue(i).ToString() + ",";
            Draws.Add(b);
        }
        //! \brief Updates the statistics based on the ball drawn. 
        public void stats(int ball)
        {
            bool found = false;
            if (Statistics.Any())
                for (int n = 0; n < Statistics.Count(); n++)
                {
                    temp = Statistics[n].Split(',');
                    if (temp[0] == ball.ToString())
                    {
                        int Occurrences = Convert.ToInt32(temp[1]);
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
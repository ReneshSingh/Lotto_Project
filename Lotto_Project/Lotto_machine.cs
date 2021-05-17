using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*! \namespace LotteryTools
 * \brief Provides classes to perform a lottery.
 */
namespace LotteryTools
{
    /*! \class Lotto_machine
     * \brief Provides classes to perform a lottery 
     * 
     * This class draws the lotto balls and manages everything to do with the draw. 
     */
    class Lotto_machine
    {
        //! \brief Constructor 
        public Lotto_machine()
        {
            
        }
        //! \brief Randomly selects a lotto ball in the provided range of min & max. 
        public  int newLottoNUmber(int min = 1, int max = 50)
        {
            int ball;
            Random r = new Random();
            ball = r.Next(min, max);
            return ball;
        }
        //! \brief Determines weather all values in the lotto draw is unique. 
        private int uniquenessCheck(List<int> balls, int min, int max)
        {
            int newBall = 0;
            do
                newBall = newLottoNUmber(min, max);
            while (balls.Contains(newBall));
            return newBall;
        }
        /*! \brief Performs the lotto draw
         * 
         * Populates the given list with unique values in the range indicated by the values min and max. 
         * \param  min the smallest possible value in the range.
         * \param max the number one larger than the upper bound of the range
         */
        public List<int> Lotto_numbers(int numBalls, int min = 1, int max = 50)
        {
            int newBall = 0;
            List<int> balls = new List<int>();
            for (int i = 0; i < numBalls; i++)
            {
                newBall = uniquenessCheck(balls, min, max);
                balls.Add(newBall);
            }
            return balls;
        }
    }
    /*! \brief Functions for statistical analysis on the Lotto numbers. 
     * 
     * Used for to perform statistical analysis on the Lotto numbers. 
     */
    class Lotto_Statistics
    {
        public List<List<int>> PowerBall; //!< \brief Collection of draws
        public List<List<int>> Lottery; //!< \brief Collection of draws
        public List <string> recordsHeaders; //!< \brief Stores the headers for the collection of draws.
        public List<string> ballStatsHeaders; //!< \brief Contains headers for the statistics for number of balls drawn.
        public Dictionary<int, int> PowerBallCollection; //!< \brief Records the number of occurrences of the ball
        public Dictionary<int, int> LotteryCollection; //!< \brief Records the number of occurrences of the ball
        static private Lotto_Statistics instance = null; //!< \brief Singleton instance of this calss to be shared or used.
        //! \brief Implementation of the singleton pattern.
        static public Lotto_Statistics getInstance() 
        {
            if (instance == null)
                instance = new Lotto_Statistics();
            return instance;
        }
        //! \brief Constructor 
        private Lotto_Statistics()
        {
            PowerBall = new List<List<int>>();
            Lottery = new List<List<int>>();
            PowerBallCollection = new Dictionary<int, int>();
            LotteryCollection = new Dictionary<int, int>();
            recordsHeaders = new List<string>();
            ballStatsHeaders = new List<string>();
            ballStatsHeaders.Add("Balls");
            ballStatsHeaders.Add("Occurrences");
            recordsHeaders.Add("Ball_1");
            recordsHeaders.Add("Ball_2");
            recordsHeaders.Add("Ball_3");
            recordsHeaders.Add("Ball_4");
            recordsHeaders.Add("Ball_5");
            recordsHeaders.Add("Ball_6/Power ball");

        }
        //! \brief Adds the draw to the record of draws.
        public void AddPowerBallDraw(List<int> Draw) 
        {
            PowerBall.Add(Draw);
        }
        //! \brief Adds the draw to the record of draws.
        public void AddLotteryDraw(List<int> Draw) 
        {
            Lottery.Add(Draw);
        }
        /*! \brief Updates the PowerBall record.
         * 
         * Updates the record with the ball drawn, if the ball has been drawn before it updates the record accordingly. 
         */
        public void PowerBallStatistics(int Ball)
        {
            int value = 1;
            if (PowerBallCollection.ContainsKey(Ball))
            {
                PowerBallCollection.TryGetValue(Ball, out value);
                value++;
                PowerBallCollection.Remove(Ball);
            }
            PowerBallCollection.Add(Ball, value);
        }
        /*! \brief Updates the PowerBall record.
         * 
         * Updates the record with the ball drawn, if the ball has been drawn before it updates the record accordingly. 
         */
        public void PowerBallStatistics(List<int> Draw)
        {
            foreach(int item in Draw)
            {
                PowerBallStatistics(item);
            }
        }
        /*! \brief Updates the Lotery record.
         * 
         * Updates the record with the ball drawn, if the ball has been drawn before it updates the record accordingly. 
         */
        public void LoteryStatistics(int Ball)
        {
            int value = 1;
            if (LotteryCollection.ContainsKey(Ball))
            {
                LotteryCollection.TryGetValue(Ball, out value);
                value++;
                LotteryCollection.Remove(Ball);
            }
            LotteryCollection.Add(Ball, value);
        }
        /*! \brief Updates the Lotery record.
         * 
         * Updates the record with the ball drawn, if the ball has been drawn before it updates the record accordingly. 
         */
        public void LoteryStatistics(List<int> Draw)
        {
            foreach (int item in Draw)
            {
                LoteryStatistics(item);
            }
        }
    }
}

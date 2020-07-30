using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*! \namespace 
 * \brief Provides classes to perform a lottery.
 */
namespace WindowsFormsApplication1
{
    /*! \class Lotto_machine
     * \brief Provides classes to perform a lottery 
     * 
     * This class draws the lotto balls and manages everything to do with the draw. 
     */
    class Lotto_machine
    {
        private int newBall = 0;
        //! \brief Constructor 
        public Lotto_machine()
        {
            
        }
        //! \brief Randomly selects a lotto ball in the provided range of min & max. 
        public int newLottoNUmber(int min = 1, int max = 50)
        {
            int ball;
            Random r = new Random();
            ball = r.Next(min, max);
            return ball;
        }
        //! \brief Determines weather all values in the lotto draw is unique. 
        private void uniquenessCheck(List<int> balls, int min, int max)
        {
            do
                newBall = newLottoNUmber(min, max);
            while (balls.Contains(newBall));
        }
        /*! \brief Performs the lotto draw
         * 
         * Populates the given list with unique values in the range indicated by the values min and max. 
         * \param  min the smallest possible value in the range.
         * \param max the number one larger than the upper bound of the range
         */
        public List<int> Lotto_numbers(int numBalls, int min = 1, int max = 50)
        {
            List<int> balls = new List<int>();
            for (int i = 0; i < numBalls; i++)
            {
                uniquenessCheck(balls, min, max);
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
        protected List<List<int>> PowerBall; //!< \brief Collection of draws
        protected List<List<int>> Lottery; //!< \brief Collection of draws
        private Dictionary<int, int> PowerBallCollection; //!< \brief Records the number of occurrences of the ball
        private Dictionary<int, int> LotteryCollection; //!< \brief Records the number of occurrences of the ball
        static private Lotto_Statistics instance = null;
        static public Lotto_Statistics getInstance() //!< \brief Implementation of the singleton pattern.
        {
            if (instance == null)
                instance = new Lotto_Statistics();
            return instance;
        }
        private Lotto_Statistics()
        {
            PowerBall = new List<List<int>>();
            Lottery = new List<List<int>>();
            PowerBallCollection = new Dictionary<int, int>();
            LotteryCollection = new Dictionary<int, int>();
        }
        public void AddPowerBallDraw(List<int> Draw) //!< \brief Adds the draw to the record of draws.
        {
            PowerBall.Add(Draw);
        }
        public void AddLotteryDraw(List<int> Draw) //!< \brief Adds the draw to the record of draws.
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
                PowerBallCollection.Add(Ball, value);
            }
            else
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
                LotteryCollection.Add(Ball, value);
            }
            else
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

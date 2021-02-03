using System;
using System.Collections;
namespace SnakeLadderApp
{
    class SnakeLadder
    {
        /// <summary>
        /// Constance variables
        /// </summary>
        /// <param name="args"></param>

        const int INIIAL_POSITION = 0;
        const int FINAL_POSITION = 100;
        const int LADDER = 1;
        const int SNAKE = 2;
        const int NO_PLAY = 3;
        /// <summary>
        /// Static method for dieRoall and position
        /// </summary>
        /// <param name="dieRoll"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        static int optionCheck(int dieRoll, int position)
        {
            Random randomNumber = new Random();
            int option = randomNumber.Next(1, 3);

            switch (option)
            {
                case NO_PLAY:
                    position = position;
                    break;
                case SNAKE:
                    position -= dieRoll;
                    break;
                case LADDER:
                    if (position + dieRoll > 100)
                        position = position;
                    else
                        position += dieRoll;
                    break;
            }
            if (position < 0)
                position = INIIAL_POSITION;
                return position;
        }

        static void Main(string[] args)
        {

            int position = 0;
            int NUMBER_OF_PLAYER = 1;
            //int count=0;
            ArrayList positions = new ArrayList();
            //var positions = new ArrayList();
            Console.WriteLine("Welcome to Snake and Ladder Simulation");
            while (position < FINAL_POSITION)
            {
                Random randomNumber = new Random();
                int dieRoll = randomNumber.Next(1,7);
                position = optionCheck(dieRoll, position);
                positions.Add(position);
               
            }
            //Console.WriteLine("final position: " + position + " number of times die rolled: " + count);
            Console.WriteLine("final position: " + position);
            Console.WriteLine(" number of times die rolled: " +positions.Count);//Report number of time dice was played to win the game
            Console.Write("position after every roll: "); 

            foreach (int i in positions)
            {
                Console.Write(i + " ");
            }
          
        }//main method
    }//snakeladder class
}//namespace

using System;

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
                    position += dieRoll;
                    break;
            }
            return position;
        }

        static void Main(string[] args)
        {

            int position = 0;
            int NUMBER_OF_PLAYER = 1;
            Console.WriteLine("Welcome to Snake and Ladder Simulation");
            Random randomNumber = new Random();
            int dieRoll = randomNumber.Next(1, 6);
            position = optionCheck(dieRoll, position);
            Console.WriteLine("Number got by rolling a die: " + dieRoll + " position: " + position);


        }
    }
}

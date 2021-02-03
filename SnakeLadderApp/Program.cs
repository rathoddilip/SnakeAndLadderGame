using System;

namespace SnakeLadderApp
{
    class SnakeLadder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
          
            int INTIAL_POSITION = 0;
            int NUMBER_OF_PLAYER = 1;
            Console.WriteLine("Welcome to Snake and Ladder Simulation");
            Random randomNumber = new Random();
            int dieRoll = randomNumber.Next(0, 1);
            Console.WriteLine("Number got by rolling a die: " + dieRoll);


        }
    }
}
